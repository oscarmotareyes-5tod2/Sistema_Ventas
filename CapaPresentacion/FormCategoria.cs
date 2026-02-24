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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FormCategoria : Form
    {

        private BLL bl = new BLL();
        private int idSeleccionado = 0;

   
        public FormCategoria()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            dgvCategoria.DataSource = bl.Listar();
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {

            
            Categoria c = new Categoria
            {
                Id_Categoria = idSeleccionado,
                Nombre_Categoria = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };


            bl.Guardar(c);
            Limpiar();
            Listar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);

            Categoria categoria = new Categoria()
            {
                Id_Categoria = id,
                Nombre_Categoria = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            BLL cn = new BLL();
            cn.Actualizar(categoria);

            MessageBox.Show("Categoría actualizada correctamente");

            Listar(); 
            Limpiar(); 
            dgvCategoria.Refresh();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la Categoria es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion de la Categoria es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione una categoría para eliminar");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);

            BLL cn = new BLL();
            cn.Eliminar(id);

            MessageBox.Show("Categoría eliminada correctamente");

            Listar();
            Limpiar();
            dgvCategoria.Refresh();
        }


        private void FormCategoria_Load(object sender, EventArgs e)
        {
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Columns["Id_Categoria"].Visible = false;


        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
            if (dgvCategoria.CurrentRow != null)
            {
                txtId.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}

