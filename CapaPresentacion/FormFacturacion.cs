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
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            CN_venta cn = new CN_venta();
            dgvVenta.DataSource = cn.Listar();
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            Listar();
            dgvVenta.Columns["Activo"].Visible = false;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }


    
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow != null)
            {
                int idVenta = Convert.ToInt32(dgvVenta.CurrentRow.Cells["Id_Venta"].Value);

                FormReporte frm = new FormReporte(idVenta);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una venta.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}
