using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
            
        }
        private void FormProducto_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            CargarProductos();
            CargarCategorias();
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Columns["Id_Producto"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Id_Categoria"].Visible = false;



        }
        private void CargarCategorias()
        {
          BLL  cn = new BLL();

            cmbCategoria.DataSource = cn.Listar();
            cmbCategoria.DisplayMember = "Nombre_Categoria";
            cmbCategoria.ValueMember = "Id_Categoria";
        }

        private void CargarProductos()
        {
            CN_producto cn = new CN_producto();
            dgvProductos.DataSource = cn.Listar();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Nombre_Producto = txtNombre.Text,
                Precio_Producto = Convert.ToDecimal(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                Categoria =Convert.ToString(cmbCategoria.SelectedValue)
            };

            CN_producto cn = new CN_producto();
            cn.Insertar(p);

            MessageBox.Show("Producto guardado correctamente");

            CargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (dgvProductos.CurrentRow != null)
            {
                txtId.Text = dgvProductos.CurrentRow.Cells["Id_Producto"].Value.ToString();
                txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio_Producto"].Value.ToString();
                txtStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();

                cmbCategoria.SelectedValue =
                dgvProductos.CurrentRow.Cells["Id_Categoria"].Value;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_producto cn = new CN_producto();

            Producto p = new Producto()
            {
                Id_Producto = Convert.ToInt32(txtId.Text),
                Nombre_Producto = txtNombre.Text,
                Precio_Producto = Convert.ToDecimal(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                Categoria = Convert.ToString(cmbCategoria.SelectedValue)
            };

            cn.Actualizar(p);

            MessageBox.Show("Producto actualizado correctamente");

            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CN_producto cn = new CN_producto();

            int id = Convert.ToInt32(txtId.Text);

            cn.Eliminar(id);

            MessageBox.Show("Producto eliminado correctamente");

            CargarProductos();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}

