namespace CapaPresentacion
{
    partial class FormProducto
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Ltitulo = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Lprecio = new System.Windows.Forms.Label();
            this.Lstock = new System.Windows.Forms.Label();
            this.Lcategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(87, 133);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(98, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ltitulo
            // 
            this.Ltitulo.AutoSize = true;
            this.Ltitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo.Location = new System.Drawing.Point(263, 14);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(191, 24);
            this.Ltitulo.TabIndex = 1;
            this.Ltitulo.Text = "Fomulario Producto";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(15, 35);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(47, 13);
            this.Lnombre.TabIndex = 2;
            this.Lnombre.Text = "Nombre:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(285, 75);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(432, 201);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // Lprecio
            // 
            this.Lprecio.AutoSize = true;
            this.Lprecio.Location = new System.Drawing.Point(15, 69);
            this.Lprecio.Name = "Lprecio";
            this.Lprecio.Size = new System.Drawing.Size(40, 13);
            this.Lprecio.TabIndex = 4;
            this.Lprecio.Text = "Precio:";
            // 
            // Lstock
            // 
            this.Lstock.AutoSize = true;
            this.Lstock.Location = new System.Drawing.Point(15, 101);
            this.Lstock.Name = "Lstock";
            this.Lstock.Size = new System.Drawing.Size(38, 13);
            this.Lstock.TabIndex = 5;
            this.Lstock.Text = "Stock:";
            // 
            // Lcategoria
            // 
            this.Lcategoria.AutoSize = true;
            this.Lcategoria.Location = new System.Drawing.Point(15, 136);
            this.Lcategoria.Name = "Lcategoria";
            this.Lcategoria.Size = new System.Drawing.Size(55, 13);
            this.Lcategoria.TabIndex = 6;
            this.Lcategoria.Text = "Categoria:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(85, 66);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(85, 101);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(43, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(124, 253);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(205, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(713, 381);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(46, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(23, 20);
            this.txtId.TabIndex = 14;
            this.txtId.Visible = false;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrincipal.Location = new System.Drawing.Point(41, 376);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 28);
            this.btnPrincipal.TabIndex = 15;
            this.btnPrincipal.Text = "🔙 Regresar";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lnombre);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.Lprecio);
            this.groupBox1.Controls.Add(this.Lstock);
            this.groupBox1.Controls.Add(this.Lcategoria);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Location = new System.Drawing.Point(63, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.Ltitulo);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Ltitulo;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label Lprecio;
        private System.Windows.Forms.Label Lstock;
        private System.Windows.Forms.Label Lcategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}