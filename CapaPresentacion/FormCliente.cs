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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        }
        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\+?[\d-]{7,15}$");
        }

      
        private void FormCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
            txtId.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Columns["Id_Cliente"].Visible = false;
            dgvClientes.Columns["Activo"].Visible = false;

        }

        private void CargarClientes()
        {
            CN_cliente cn = new CN_cliente();
            dgvClientes.DataSource = cn.Listar();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            CN_cliente cn = new CN_cliente();

            Cliente c = new Cliente()
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };
   
            if (!EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("Teléfono no válido (7–15 dígitos).", "Error");
                return;
            }

            if (!EsEmailValido(txtCorreo.Text))
            {
                MessageBox.Show("Email no válido.", "Error");
                return;
            }

            cn.Insertar(c);
            MessageBox.Show("Cliente guardado correctamente");
            CargarClientes();

            Limpiar();

        }
        

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvClientes.Rows[e.RowIndex].Cells["Id_Cliente"].Value.ToString();
                txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvClientes.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CN_cliente cn = new CN_cliente();

            Cliente c = new Cliente()
            {
                Id_Cliente = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            cn.Actualizar(c);

            MessageBox.Show("Cliente actualizado correctamente");

            CargarClientes();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar este cliente?",
            "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CN_cliente cn = new CN_cliente();
                int id = Convert.ToInt32(txtId.Text);

                cn.Eliminar(id);

                MessageBox.Show("Cliente eliminado correctamente");

                CargarClientes();
                Limpiar();
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
