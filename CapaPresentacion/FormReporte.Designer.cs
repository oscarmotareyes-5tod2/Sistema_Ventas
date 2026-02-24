namespace CapaPresentacion
{
    partial class FormReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sistemaVentasDataSetFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSetFactura = new CapaPresentacion.SistemaVentasDataSetFactura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaVentasDataSetFacturaBindingSource
            // 
            this.sistemaVentasDataSetFacturaBindingSource.DataSource = this.sistemaVentasDataSetFactura;
            this.sistemaVentasDataSetFacturaBindingSource.Position = 0;
            // 
            // sistemaVentasDataSetFactura
            // 
            this.sistemaVentasDataSetFactura.DataSetName = "SistemaVentasDataSetFactura";
            this.sistemaVentasDataSetFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sistemaVentasDataSetFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Facturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 535);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(653, 377);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 33);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            this.Load += new System.EventHandler(this.FormReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource sistemaVentasDataSetFacturaBindingSource;
        private SistemaVentasDataSetFactura sistemaVentasDataSetFactura;
    }
}