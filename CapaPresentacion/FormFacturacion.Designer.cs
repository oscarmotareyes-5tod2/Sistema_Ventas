namespace CapaPresentacion
{
    partial class FormFacturacion
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
            this.Ltitulo = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // Ltitulo
            // 
            this.Ltitulo.AutoSize = true;
            this.Ltitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo.Location = new System.Drawing.Point(332, 28);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(126, 24);
            this.Ltitulo.TabIndex = 0;
            this.Ltitulo.Text = "Facturación:";
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(171, 55);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(460, 241);
            this.dgvVenta.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(337, 331);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(85, 31);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DimGray;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Location = new System.Drawing.Point(61, 393);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 31);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "🔙 Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.Ltitulo);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ltitulo;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnRegresar;
    }
}