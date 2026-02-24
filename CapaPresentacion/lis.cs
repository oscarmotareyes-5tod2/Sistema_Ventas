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
    public partial class lis : Form
    {
        public lis()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.ShowDialog();

        }

        private void btncat_Click(object sender, EventArgs e)
        {
            FormCategoria  categoria= new FormCategoria();
            categoria.ShowDialog();
        }


        private void lis_Load (object sender, EventArgs e)
        {

        }

        private void btnproducto_Click(object sender, EventArgs e)
        {

            FormProducto producto = new FormProducto();
            producto.ShowDialog();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {

            FormVenta Venta = new FormVenta();
            Venta.ShowDialog();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            FormFacturacion Facturacion = new FormFacturacion();
            Facturacion.ShowDialog();
        }
    }
}
