namespace GuarderíaCanina
{
    partial class FormClientesMascotas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            groupBoxClientes = new GroupBox();
            btnRegistrarCliente = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            txtIdCliente = new TextBox();
            lblIdCliente = new Label();
            groupBoxMascotas = new GroupBox();
            cmbClientesMascotas = new ComboBox();
            lblClienteMascota = new Label();
            btnAgregarMascota = new Button();
            txtPeso = new TextBox();
            lblPeso = new Label();
            numEdad = new NumericUpDown();
            lblEdad = new Label();
            txtRaza = new TextBox();
            lblRaza = new Label();
            txtNombreMascota = new TextBox();
            lblNombreMascota = new Label();
            lstClientes = new ListBox();
            lblListaClientes = new Label();
            btnIrReservas = new Button();
            groupBoxClientes.SuspendLayout();
            groupBoxMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(52, 73, 94);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(875, 66);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🐕 CLIENTES Y MASCOTAS 🐕";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxClientes
            // 
            groupBoxClientes.BackColor = Color.FromArgb(236, 240, 241);
            groupBoxClientes.Controls.Add(btnRegistrarCliente);
            groupBoxClientes.Controls.Add(txtTelefono);
            groupBoxClientes.Controls.Add(lblTelefono);
            groupBoxClientes.Controls.Add(txtNombreCliente);
            groupBoxClientes.Controls.Add(lblNombreCliente);
            groupBoxClientes.Controls.Add(txtIdCliente);
            groupBoxClientes.Controls.Add(lblIdCliente);
            groupBoxClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxClientes.Location = new Point(18, 84);
            groupBoxClientes.Name = "groupBoxClientes";
            groupBoxClientes.Size = new Size(394, 225);
            groupBoxClientes.TabIndex = 1;
            groupBoxClientes.TabStop = false;
            groupBoxClientes.Text = "Registro de Clientes";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.FromArgb(46, 204, 113);
            btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            btnRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistrarCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarCliente.ForeColor = Color.White;
            btnRegistrarCliente.Location = new Point(18, 173);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(359, 36);
            btnRegistrarCliente.TabIndex = 6;
            btnRegistrarCliente.Text = "✓ Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.Location = new Point(18, 136);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(359, 23);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.Location = new Point(18, 114);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 15);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Segoe UI", 9F);
            txtNombreCliente.Location = new Point(201, 56);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(176, 23);
            txtNombreCliente.TabIndex = 3;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreCliente.Location = new Point(201, 35);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(56, 15);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 9F);
            txtIdCliente.Location = new Point(18, 56);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(167, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIdCliente.Location = new Point(18, 35);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(23, 15);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "ID:";
            // 
            // groupBoxMascotas
            // 
            groupBoxMascotas.BackColor = Color.FromArgb(236, 240, 241);
            groupBoxMascotas.Controls.Add(cmbClientesMascotas);
            groupBoxMascotas.Controls.Add(lblClienteMascota);
            groupBoxMascotas.Controls.Add(btnAgregarMascota);
            groupBoxMascotas.Controls.Add(txtPeso);
            groupBoxMascotas.Controls.Add(lblPeso);
            groupBoxMascotas.Controls.Add(numEdad);
            groupBoxMascotas.Controls.Add(lblEdad);
            groupBoxMascotas.Controls.Add(txtRaza);
            groupBoxMascotas.Controls.Add(lblRaza);
            groupBoxMascotas.Controls.Add(txtNombreMascota);
            groupBoxMascotas.Controls.Add(lblNombreMascota);
            groupBoxMascotas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxMascotas.Location = new Point(18, 328);
            groupBoxMascotas.Name = "groupBoxMascotas";
            groupBoxMascotas.Size = new Size(394, 351);
            groupBoxMascotas.TabIndex = 2;
            groupBoxMascotas.TabStop = false;
            groupBoxMascotas.Text = "Registro de Mascotas";
            // 
            // cmbClientesMascotas
            // 
            cmbClientesMascotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientesMascotas.Font = new Font("Segoe UI", 9F);
            cmbClientesMascotas.FormattingEnabled = true;
            cmbClientesMascotas.Location = new Point(18, 56);
            cmbClientesMascotas.Name = "cmbClientesMascotas";
            cmbClientesMascotas.Size = new Size(359, 23);
            cmbClientesMascotas.TabIndex = 10;
            // 
            // lblClienteMascota
            // 
            lblClienteMascota.AutoSize = true;
            lblClienteMascota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClienteMascota.Location = new Point(18, 35);
            lblClienteMascota.Name = "lblClienteMascota";
            lblClienteMascota.Size = new Size(112, 15);
            lblClienteMascota.TabIndex = 9;
            lblClienteMascota.Text = "Seleccione Cliente:";
            // 
            // btnAgregarMascota
            // 
            btnAgregarMascota.BackColor = Color.FromArgb(52, 152, 219);
            btnAgregarMascota.FlatAppearance.BorderSize = 0;
            btnAgregarMascota.FlatStyle = FlatStyle.Flat;
            btnAgregarMascota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarMascota.ForeColor = Color.White;
            btnAgregarMascota.Location = new Point(18, 298);
            btnAgregarMascota.Name = "btnAgregarMascota";
            btnAgregarMascota.Size = new Size(359, 36);
            btnAgregarMascota.TabIndex = 8;
            btnAgregarMascota.Text = "+ Agregar Mascota";
            btnAgregarMascota.UseVisualStyleBackColor = false;
            btnAgregarMascota.Click += btnAgregarMascota_Click;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9F);
            txtPeso.Location = new Point(201, 255);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(176, 23);
            txtPeso.TabIndex = 7;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPeso.Location = new Point(201, 228);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(61, 15);
            lblPeso.TabIndex = 6;
            lblPeso.Text = "Peso (kg):";
            lblPeso.Click += lblPeso_Click;
            // 
            // numEdad
            // 
            numEdad.Font = new Font("Segoe UI", 9F);
            numEdad.Location = new Point(18, 255);
            numEdad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(166, 23);
            numEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdad.Location = new Point(18, 228);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(72, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad (años):";
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 9F);
            txtRaza.Location = new Point(18, 188);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(359, 23);
            txtRaza.TabIndex = 3;
            txtRaza.TextChanged += txtRaza_TextChanged;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRaza.Location = new Point(18, 160);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(36, 15);
            lblRaza.TabIndex = 2;
            lblRaza.Text = "Raza:";
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Font = new Font("Segoe UI", 9F);
            txtNombreMascota.Location = new Point(18, 118);
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.Size = new Size(359, 23);
            txtNombreMascota.TabIndex = 1;
            // 
            // lblNombreMascota
            // 
            lblNombreMascota.AutoSize = true;
            lblNombreMascota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreMascota.Location = new Point(18, 91);
            lblNombreMascota.Name = "lblNombreMascota";
            lblNombreMascota.Size = new Size(122, 15);
            lblNombreMascota.TabIndex = 0;
            lblNombreMascota.Text = "Nombre de Mascota:";
            // 
            // lstClientes
            // 
            lstClientes.Font = new Font("Consolas", 9F);
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 14;
            lstClientes.Location = new Point(429, 103);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(429, 522);
            lstClientes.TabIndex = 3;
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaClientes.Location = new Point(429, 82);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(165, 19);
            lblListaClientes.TabIndex = 4;
            lblListaClientes.Text = "📋 Clientes Registrados";
            // 
            // btnIrReservas
            // 
            btnIrReservas.BackColor = Color.FromArgb(155, 89, 182);
            btnIrReservas.FlatAppearance.BorderSize = 0;
            btnIrReservas.FlatStyle = FlatStyle.Flat;
            btnIrReservas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIrReservas.ForeColor = Color.White;
            btnIrReservas.Location = new Point(429, 638);
            btnIrReservas.Name = "btnIrReservas";
            btnIrReservas.Size = new Size(429, 42);
            btnIrReservas.TabIndex = 5;
            btnIrReservas.Text = "➜ Ir a Reservas y Servicios";
            btnIrReservas.UseVisualStyleBackColor = false;
            btnIrReservas.Click += btnIrReservas_Click;
            // 
            // FormClientesMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(875, 691);
            Controls.Add(btnIrReservas);
            Controls.Add(lblListaClientes);
            Controls.Add(lstClientes);
            Controls.Add(groupBoxMascotas);
            Controls.Add(groupBoxClientes);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormClientesMascotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guardería Canina - Clientes y Mascotas";
            FormClosing += FormClientesMascotas_FormClosing;
            Load += FormClientesMascotas_Load;
            groupBoxClientes.ResumeLayout(false);
            groupBoxClientes.PerformLayout();
            groupBoxMascotas.ResumeLayout(false);
            groupBoxMascotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.GroupBox groupBoxMascotas;
        private System.Windows.Forms.ComboBox cmbClientesMascotas;
        private System.Windows.Forms.Label lblClienteMascota;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Button btnIrReservas;
    }
}