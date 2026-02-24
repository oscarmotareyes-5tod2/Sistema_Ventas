using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();

            dgvDetalle.AutoGenerateColumns = true;
            dgvDetalle.DataSource = carrito;
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Enabled = false;

            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Listar();

            dgvDetalle.Columns["Id_detalle"].Visible= false;
            dgvDetalle.Columns["Id_venta"].Visible = false;
            dgvDetalle.Columns["Id_Producto"].Visible = false;

        }

        private void Listar()
        {
            CN_venta cn = new CN_venta();
            dgvVenta.DataSource = cn.Listar();
        }

        BindingList<Detalle_Venta> carrito = new BindingList<Detalle_Venta>();


        private void CargarClientes()
        {
            CN_cliente cn = new CN_cliente();

            cmbCliente.DataSource = cn.Listar();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id_cliente";
        }

        private void CargarProductos()
        {
            CN_producto cn = new CN_producto();

            cmbProducto.DataSource = cn.Listar();
            cmbProducto.DisplayMember = "Nombre_Producto";
            cmbProducto.ValueMember = "Id_Producto";
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            string nombreProducto = cmbProducto.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int cantidad = Convert.ToInt32(nudCantidad.Value);

            carrito.Add(new Detalle_Venta()
            {
                Id_producto = idProducto,
                N_Producto = nombreProducto,
                Precio = precio,
                Cant = cantidad,
                Subtotal = precio * cantidad
            });

            CalcularTotal();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Ventas venta = new Ventas()
                {
                    Fecha_venta = dtpFecha.Value,
                    Id_cliente = Convert.ToInt32(cmbCliente.SelectedValue),
                    Total_general = Convert.ToDecimal(txtTotal.Text),
                    
                    Activo = true,
                    Detalles = carrito.ToList()
                };

                CN_venta cn = new CN_venta();
                int idVenta = cn.Insertar(venta);

                MessageBox.Show("Venta registrada correctamente");

                Ventas vental = new Ventas();
                                             
                FormReporte frm = new FormReporte(idVenta);
                frm.ShowDialog();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Listar();
        }

        private void CalcularTotal()
        {

            decimal total = 0;

            foreach (var item in carrito)
            {
                total += item.Precio * item.Cant;
            }

            txtTotal.Text = total.ToString("0.00");
        }

        private void LimpiarFormulario()
        {
            carrito.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbProducto.SelectedValue != null)
            {
                CN_producto cn = new CN_producto();
                Producto productoSeleccionado = (Producto)cmbProducto.SelectedItem;

                int idProducto = productoSeleccionado.Id_Producto;
                txtPrecio.Text = productoSeleccionado.Precio_Producto.ToString("0.00");

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir?","Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }

            else 
            {
                MessageBox.Show("Cancelaste la acción","Acción",MessageBoxButtons.OK,
                    MessageBoxIcon.Question);
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
       
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }

        private void LDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                Detalle_Venta detalleSeleccionado =
                    (Detalle_Venta)dgvDetalle.CurrentRow.DataBoundItem;

                carrito.Remove(detalleSeleccionado);

                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Seleccione un producto del detalle para eliminar.");
            }
        }

        Detalle_Venta detalleEditar = null;

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                detalleEditar =
                    (Detalle_Venta)dgvDetalle.CurrentRow.DataBoundItem;

                txtPrecio.Text = detalleEditar.Precio.ToString();
                nudCantidad.Value = detalleEditar.Cant;
            }
        }

        private void btnActualizarDetalle_Click(object sender, EventArgs e)
        {
            if (detalleEditar != null)
            {
                detalleEditar.Precio = Convert.ToDecimal(txtPrecio.Text);
                detalleEditar.Cant = Convert.ToInt32(nudCantidad.Value);
                detalleEditar.Subtotal = detalleEditar.Precio * detalleEditar.Cant;

                dgvDetalle.Refresh();
                CalcularTotal();

                detalleEditar = null;
            }
            else
            {
                MessageBox.Show("Seleccione un detalle para actualizar.");
            }
        }
    }

}
