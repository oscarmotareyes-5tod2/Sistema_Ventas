namespace CapaPresentacion
{
    partial class FormCliente
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
            this.Lnombre = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ltitulo
            // 
            this.Ltitulo.AutoSize = true;
            this.Ltitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo.Location = new System.Drawing.Point(281, 20);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(184, 24);
            this.Ltitulo.TabIndex = 0;
            this.Ltitulo.Text = "Formulario Cliente ";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.Location = new System.Drawing.Point(18, 36);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(47, 13);
            this.Lnombre.TabIndex = 1;
            this.Lnombre.Text = "Nombre:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(18, 103);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(52, 13);
            this.LTelefono.TabIndex = 2;
            this.LTelefono.Text = "Telefono:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Location = new System.Drawing.Point(18, 69);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(55, 13);
            this.LDireccion.TabIndex = 3;
            this.LDireccion.Text = "Dirección:";
            // 
            // LCorreo
            // 
            this.LCorreo.AutoSize = true;
            this.LCorreo.Location = new System.Drawing.Point(18, 134);
            this.LCorreo.Name = "LCorreo";
            this.LCorreo.Size = new System.Drawing.Size(41, 13);
            this.LCorreo.TabIndex = 4;
            this.LCorreo.Text = "Correo:";
            this.LCorreo.Click += new System.EventHandler(this.LCorreo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(26, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 20);
            this.txtId.TabIndex = 6;
            this.txtId.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(71, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(71, 100);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(71, 131);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 9;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(269, 88);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(463, 198);
            this.dgvClientes.TabIndex = 10;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(26, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(107, 263);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(704, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 26);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 263);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.DimGray;
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrincipal.Location = new System.Drawing.Point(26, 386);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(75, 26);
            this.btnPrincipal.TabIndex = 15;
            this.btnPrincipal.Text = "🔙 Regresar";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lnombre);
            this.groupBox1.Controls.Add(this.LTelefono);
            this.groupBox1.Controls.Add(this.LDireccion);
            this.groupBox1.Controls.Add(this.LCorreo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Location = new System.Drawing.Point(46, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Ltitulo);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ltitulo;
        private System.Windows.Forms.Label Lnombre;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}