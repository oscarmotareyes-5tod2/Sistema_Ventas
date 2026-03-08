namespace CapaPresentacion
{
    partial class FormVenta
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
            this.LCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.LDetalle = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnActualizarDetalle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(18, 32);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(42, 13);
            this.LCliente.TabIndex = 0;
            this.LCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(66, 29);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(89, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(18, 68);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(40, 13);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(64, 62);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(91, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(10, 31);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(53, 13);
            this.LProducto.TabIndex = 6;
            this.LProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(69, 23);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(85, 21);
            this.cmbProducto.TabIndex = 7;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Location = new System.Drawing.Point(10, 67);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(40, 13);
            this.LPrecio.TabIndex = 8;
            this.LPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(69, 64);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(85, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(10, 105);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(52, 13);
            this.LCantidad.TabIndex = 10;
            this.LCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(66, 98);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(85, 20);
            this.nudCantidad.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(297, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(271, 60);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(445, 268);
            this.dgvDetalle.TabIndex = 13;
            this.dgvDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellClick);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(10, 134);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(34, 13);
            this.Total.TabIndex = 14;
            this.Total.Text = "Total:";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(66, 131);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(609, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // LDetalle
            // 
            this.LDetalle.AutoSize = true;
            this.LDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalle.Location = new System.Drawing.Point(423, 35);
            this.LDetalle.Name = "LDetalle";
            this.LDetalle.Size = new System.Drawing.Size(132, 13);
            this.LDetalle.TabIndex = 17;
            this.LDetalle.Text = "Detalle de las Ventas:";
            this.LDetalle.Click += new System.EventHandler(this.LDetalle_Click);
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(138, 415);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(549, 83);
            this.dgvVenta.TabIndex = 18;
            this.dgvVenta.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(693, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrincipal.Location = new System.Drawing.Point(33, 405);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipal.TabIndex = 20;
            this.btnPrincipal.Text = "🔙 Regresar";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(401, 348);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDetalle.TabIndex = 21;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnActualizarDetalle
            // 
            this.btnActualizarDetalle.Location = new System.Drawing.Point(508, 348);
            this.btnActualizarDetalle.Name = "btnActualizarDetalle";
            this.btnActualizarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarDetalle.TabIndex = 22;
            this.btnActualizarDetalle.Text = "Actualizar";
            this.btnActualizarDetalle.UseVisualStyleBackColor = true;
            this.btnActualizarDetalle.Click += new System.EventHandler(this.btnActualizarDetalle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LCliente);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.LFecha);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Location = new System.Drawing.Point(72, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LProducto);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.LPrecio);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.LCantidad);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Location = new System.Drawing.Point(72, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 162);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Venta";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizarDetalle);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.LDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label LDetalle;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnActualizarDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}