namespace CapaPresentacion
{
    partial class lis
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
            this.btncat = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnfactura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncat
            // 
            this.btncat.BackColor = System.Drawing.Color.MistyRose;
            this.btncat.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncat.Location = new System.Drawing.Point(213, 70);
            this.btncat.Name = "btncat";
            this.btncat.Size = new System.Drawing.Size(172, 80);
            this.btncat.TabIndex = 0;
            this.btncat.Text = "Categoria";
            this.btncat.UseVisualStyleBackColor = false;
            this.btncat.Click += new System.EventHandler(this.btncat_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.BackColor = System.Drawing.Color.MistyRose;
            this.btnproducto.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.Location = new System.Drawing.Point(391, 69);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(170, 80);
            this.btnproducto.TabIndex = 1;
            this.btnproducto.Text = "Producto";
            this.btnproducto.UseVisualStyleBackColor = false;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.Color.MistyRose;
            this.btnventa.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Location = new System.Drawing.Point(567, 69);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(166, 79);
            this.btnventa.TabIndex = 2;
            this.btnventa.Text = "Venta";
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.MistyRose;
            this.btncliente.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Location = new System.Drawing.Point(37, 69);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(170, 81);
            this.btncliente.TabIndex = 3;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnfactura
            // 
            this.btnfactura.BackColor = System.Drawing.Color.MistyRose;
            this.btnfactura.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfactura.Location = new System.Drawing.Point(739, 70);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(159, 78);
            this.btnfactura.TabIndex = 4;
            this.btnfactura.Text = "Factura";
            this.btnfactura.UseVisualStyleBackColor = false;
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.descargar__2_2;
            this.pictureBox1.Location = new System.Drawing.Point(124, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1041, 422);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Font = new System.Drawing.Font("Monotype Corsiva", 45F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(292, 320);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(452, 72);
            this.titulo.TabIndex = 6;
            this.titulo.Text = "Sistema Ventas ❤︎";
            // 
            // lis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 618);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnfactura);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.btnproducto);
            this.Controls.Add(this.btncat);
            this.Name = "lis";
            this.Text = "Formli";
            this.Load += new System.EventHandler(this.lis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncat;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
    }
}