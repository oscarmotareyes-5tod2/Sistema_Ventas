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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.Show();
            this.Hide();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FormCategoria categoria = new FormCategoria();
            categoria.Show();
            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVenta venta = new FormVenta();
            venta.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProducto producto = new FormProducto();
            producto.Show();
            this.Hide();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion frm = new FormFacturacion();
            frm.Show();
            this.Hide();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
