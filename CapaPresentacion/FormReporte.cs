using Microsoft.Reporting.WinForms;
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

namespace CapaPresentacion
{
    public partial class FormReporte : Form
    {
        private int _idVenta;
        public FormReporte(int idVenta)
        {
            InitializeComponent();
            _idVenta = idVenta;
        }
       
        private void CargarReporte()
        {
            CD_Venta cd = new CD_Venta();
            DataTable dt = cd.MostrarFactura(_idVenta);

            reportViewer1.LocalReport.ReportPath = @"C:\Users\oscar\source\repos\CapaPresentacion\CapaPresentacion\Reportes\Facturas.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        


        private void FormReporte_Load(object sender, EventArgs e)
        {
            CargarReporte();
            this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormFacturacion ff = new FormFacturacion();
            ff.Show();
            this.Hide();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
