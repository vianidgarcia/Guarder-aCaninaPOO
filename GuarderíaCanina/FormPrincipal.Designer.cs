namespace GuarderíaCanina
{
    partial class FormPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.groupBoxMascotas = new System.Windows.Forms.GroupBox();
            this.cmbClientesMascotas = new System.Windows.Forms.ComboBox();
            this.lblClienteMascota = new System.Windows.Forms.Label();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.tabReservas = new System.Windows.Forms.TabPage();
            this.groupBoxNuevaReserva = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.cmbMascotasReservas = new System.Windows.Forms.ComboBox();
            this.lblMascotaReserva = new System.Windows.Forms.Label();
            this.cmbClientesReservas = new System.Windows.Forms.ComboBox();
            this.lblClienteReserva = new System.Windows.Forms.Label();
            this.txtReservas = new System.Windows.Forms.TextBox();
            this.lblListaReservas = new System.Windows.Forms.Label();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.groupBoxGestionServicios = new System.Windows.Forms.GroupBox();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.lstServicios = new System.Windows.Forms.ListBox();
            this.lblServiciosReserva = new System.Windows.Forms.Label();
            this.groupBoxAgregarServicio = new System.Windows.Forms.GroupBox();
            this.panelPaseo = new System.Windows.Forms.Panel();
            this.chkEsGrupal = new System.Windows.Forms.CheckBox();
            this.numPrecioHora = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioHora = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.lblHoras = new System.Windows.Forms.Label();
            this.panelLimpieza = new System.Windows.Forms.Panel();
            this.numPrecioBaseLimpieza = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioBaseLimpieza = new System.Windows.Forms.Label();
            this.chkIncluyeCorte = new System.Windows.Forms.CheckBox();
            this.panelHospedaje = new System.Windows.Forms.Panel();
            this.numPrecioDia = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioDia = new System.Windows.Forms.Label();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.lblDias = new System.Windows.Forms.Label();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.cmbReservasServicios = new System.Windows.Forms.ComboBox();
            this.lblReservaServicio = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.groupBoxMascotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.groupBoxClientes.SuspendLayout();
            this.tabReservas.SuspendLayout();
            this.groupBoxNuevaReserva.SuspendLayout();
            this.tabServicios.SuspendLayout();
            this.groupBoxGestionServicios.SuspendLayout();
            this.groupBoxAgregarServicio.SuspendLayout();
            this.panelPaseo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            this.panelLimpieza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBaseLimpieza)).BeginInit();
            this.panelHospedaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1000, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🐕 SISTEMA DE GUARDERÍA CANINA 🐕";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClientes);
            this.tabControl.Controls.Add(this.tabReservas);
            this.tabControl.Controls.Add(this.tabServicios);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(12, 82);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(976, 618);
            this.tabControl.TabIndex = 1;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.White;
            this.tabClientes.Controls.Add(this.groupBoxMascotas);
            this.tabClientes.Controls.Add(this.groupBoxClientes);
            this.tabClientes.Controls.Add(this.lstClientes);
            this.tabClientes.Controls.Add(this.lblListaClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 32);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(968, 582);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "👥 Clientes y Mascotas";
            // 
            // groupBoxMascotas
            // 
            this.groupBoxMascotas.Controls.Add(this.cmbClientesMascotas);
            this.groupBoxMascotas.Controls.Add(this.lblClienteMascota);
            this.groupBoxMascotas.Controls.Add(this.btnAgregarMascota);
            this.groupBoxMascotas.Controls.Add(this.txtPeso);
            this.groupBoxMascotas.Controls.Add(this.lblPeso);
            this.groupBoxMascotas.Controls.Add(this.numEdad);
            this.groupBoxMascotas.Controls.Add(this.lblEdad);
            this.groupBoxMascotas.Controls.Add(this.txtRaza);
            this.groupBoxMascotas.Controls.Add(this.lblRaza);
            this.groupBoxMascotas.Controls.Add(this.txtNombreMascota);
            this.groupBoxMascotas.Controls.Add(this.lblNombreMascota);
            this.groupBoxMascotas.Location = new System.Drawing.Point(20, 190);
            this.groupBoxMascotas.Name = "groupBoxMascotas";
            this.groupBoxMascotas.Size = new System.Drawing.Size(450, 360);
            this.groupBoxMascotas.TabIndex = 3;
            this.groupBoxMascotas.TabStop = false;
            this.groupBoxMascotas.Text = "Agregar Mascota";
            // 
            // cmbClientesMascotas
            // 
            this.cmbClientesMascotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesMascotas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbClientesMascotas.FormattingEnabled = true;
            this.cmbClientesMascotas.Location = new System.Drawing.Point(20, 55);
            this.cmbClientesMascotas.Name = "cmbClientesMascotas";
            this.cmbClientesMascotas.Size = new System.Drawing.Size(410, 28);
            this.cmbClientesMascotas.TabIndex = 10;
            // 
            // lblClienteMascota
            // 
            this.lblClienteMascota.AutoSize = true;
            this.lblClienteMascota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClienteMascota.Location = new System.Drawing.Point(20, 32);
            this.lblClienteMascota.Name = "lblClienteMascota";
            this.lblClienteMascota.Size = new System.Drawing.Size(137, 20);
            this.lblClienteMascota.TabIndex = 9;
            this.lblClienteMascota.Text = "Seleccione Cliente:";
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregarMascota.FlatAppearance.BorderSize = 0;
            this.btnAgregarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMascota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMascota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMascota.Location = new System.Drawing.Point(20, 295);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(410, 45);
            this.btnAgregarMascota.TabIndex = 8;
            this.btnAgregarMascota.Text = "Agregar Mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = false;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPeso.Location = new System.Drawing.Point(240, 245);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(190, 27);
            this.txtPeso.TabIndex = 7;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPeso.Location = new System.Drawing.Point(240, 222);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(79, 20);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // numEdad
            // 
            this.numEdad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numEdad.Location = new System.Drawing.Point(20, 245);
            this.numEdad.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(190, 27);
            this.numEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdad.Location = new System.Drawing.Point(20, 222);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(95, 20);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad (años):";
            // 
            // txtRaza
            // 
            this.txtRaza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRaza.Location = new System.Drawing.Point(20, 180);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(410, 27);
            this.txtRaza.TabIndex = 3;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRaza.Location = new System.Drawing.Point(20, 157);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(45, 20);
            this.lblRaza.TabIndex = 2;
            this.lblRaza.Text = "Raza:";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreMascota.Location = new System.Drawing.Point(20, 115);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(410, 27);
            this.txtNombreMascota.TabIndex = 1;
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreMascota.Location = new System.Drawing.Point(20, 92);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(140, 20);
            this.lblNombreMascota.TabIndex = 0;
            this.lblNombreMascota.Text = "Nombre Mascota:";
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.btnRegistrarCliente);
            this.groupBoxClientes.Controls.Add(this.txtTelefono);
            this.groupBoxClientes.Controls.Add(this.lblTelefono);
            this.groupBoxClientes.Controls.Add(this.txtNombreCliente);
            this.groupBoxClientes.Controls.Add(this.lblNombreCliente);
            this.groupBoxClientes.Controls.Add(this.txtIdCliente);
            this.groupBoxClientes.Controls.Add(this.lblIdCliente);
            this.groupBoxClientes.Location = new System.Drawing.Point(20, 20);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(450, 150);
            this.groupBoxClientes.TabIndex = 2;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Registrar Cliente";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(305, 95);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(125, 35);
            this.btnRegistrarCliente.TabIndex = 6;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(305, 55);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(305, 32);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreCliente.Location = new System.Drawing.Point(162, 55);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(125, 27);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.Location = new System.Drawing.Point(162, 32);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(71, 20);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCliente.Location = new System.Drawing.Point(20, 55);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(125, 27);
            this.txtIdCliente.TabIndex = 1;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdCliente.Location = new System.Drawing.Point(20, 32);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(79, 20);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // lstClientes
            // 
            this.lstClientes.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 18;
            this.lstClientes.Location = new System.Drawing.Point(490, 45);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(460, 508);
            this.lstClientes.TabIndex = 1;
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListaClientes.Location = new System.Drawing.Point(490, 20);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(175, 23);
            this.lblListaClientes.TabIndex = 0;
            this.lblListaClientes.Text = "Clientes Registrados:";
            // 
            // tabReservas
            // 
            this.tabReservas.BackColor = System.Drawing.Color.White;
            this.tabReservas.Controls.Add(this.groupBoxNuevaReserva);
            this.tabReservas.Controls.Add(this.txtReservas);
            this.tabReservas.Controls.Add(this.lblListaReservas);
            this.tabReservas.Location = new System.Drawing.Point(4, 32);
            this.tabReservas.Name = "tabReservas";
            this.tabReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservas.Size = new System.Drawing.Size(968, 582);
            this.tabReservas.TabIndex = 1;
            this.tabReservas.Text = "📅 Reservas";
            // 
            // groupBoxNuevaReserva
            // 
            this.groupBoxNuevaReserva.Controls.Add(this.dtpFechaIngreso);
            this.groupBoxNuevaReserva.Controls.Add(this.lblFechaIngreso);
            this.groupBoxNuevaReserva.Controls.Add(this.btnCrearReserva);
            this.groupBoxNuevaReserva.Controls.Add(this.cmbMascotasReservas);
            this.groupBoxNuevaReserva.Controls.Add(this.lblMascotaReserva);
            this.groupBoxNuevaReserva.Controls.Add(this.cmbClientesReservas);
            this.groupBoxNuevaReserva.Controls.Add(this.lblClienteReserva);
            this.groupBoxNuevaReserva.Location = new System.Drawing.Point(20, 20);
            this.groupBoxNuevaReserva.Name = "groupBoxNuevaReserva";
            this.groupBoxNuevaReserva.Size = new System.Drawing.Size(450, 250);
            this.groupBoxNuevaReserva.TabIndex = 2;
            this.groupBoxNuevaReserva.TabStop = false;
            this.groupBoxNuevaReserva.Text = "Crear Nueva Reserva";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(20, 175);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(410, 27);
            this.dtpFechaIngreso.TabIndex = 6;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaIngreso.Location = new System.Drawing.Point(20, 152);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(127, 20);
            this.lblFechaIngreso.TabIndex = 5;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCrearReserva.FlatAppearance.BorderSize = 0;
            this.btnCrearReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReserva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrearReserva.ForeColor = System.Drawing.Color.White;
            this.btnCrearReserva.Location = new System.Drawing.Point(20, 212);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(410, 32);
            this.btnCrearReserva.TabIndex = 4;
            this.btnCrearReserva.Text = "Crear Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.btnCrearReserva_Click);
            // 
            // cmbMascotasReservas
            // 
            this.cmbMascotasReservas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMascotasReservas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMascotasReservas.FormattingEnabled = true;
            this.cmbMascotasReservas.Location = new System.Drawing.Point(20, 115);
            this.cmbMascotasReservas.Name = "cmbMascotasReservas";
            this.cmbMascotasReservas.Size = new System.Drawing.Size(410, 28);
            this.cmbMascotasReservas.TabIndex = 3;
            // 
            // lblMascotaReserva
            // 
            this.lblMascotaReserva.AutoSize = true;
            this.lblMascotaReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMascotaReserva.Location = new System.Drawing.Point(20, 92);
            this.lblMascotaReserva.Name = "lblMascotaReserva";
            this.lblMascotaReserva.Size = new System.Drawing.Size(153, 20);
            this.lblMascotaReserva.TabIndex = 2;
            this.lblMascotaReserva.Text = "Seleccione Mascota:";
            // 
            // cmbClientesReservas
            // 
            this.cmbClientesReservas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesReservas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbClientesReservas.FormattingEnabled = true;
            this.cmbClientesReservas.Location = new System.Drawing.Point(20, 55);
            this.cmbClientesReservas.Name = "cmbClientesReservas";
            this.cmbClientesReservas.Size = new System.Drawing.Size(410, 28);
            this.cmbClientesReservas.TabIndex = 1;
            this.cmbClientesReservas.SelectedIndexChanged += new System.EventHandler(this.cmbClientesReservas_SelectedIndexChanged);
            // 
            // lblClienteReserva
            // 
            this.lblClienteReserva.AutoSize = true;
            this.lblClienteReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblClienteReserva.Location = new System.Drawing.Point(20, 32);
            this.lblClienteReserva.Name = "lblClienteReserva";
            this.lblClienteReserva.Size = new System.Drawing.Size(137, 20);
            this.lblClienteReserva.TabIndex = 0;
            this.lblClienteReserva.Text = "Seleccione Cliente:";
            // 
            // txtReservas
            // 
            this.txtReservas.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtReservas.Location = new System.Drawing.Point(490, 45);
            this.txtReservas.Multiline = true;
            this.txtReservas.Name = "txtReservas";
            this.txtReservas.ReadOnly = true;
            this.txtReservas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReservas.Size = new System.Drawing.Size(460, 508);
            this.txtReservas.TabIndex = 1;
            // 
            // lblListaReservas
            // 
            this.lblListaReservas.AutoSize = true;
            this.lblListaReservas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListaReservas.Location = new System.Drawing.Point(490, 20);
            this.lblListaReservas.Name = "lblListaReservas";
            this.lblListaReservas.Size = new System.Drawing.Size(186, 23);
            this.lblListaReservas.TabIndex = 0;
            this.lblListaReservas.Text = "Reservas Registradas:";
            // 
            // tabServicios
            // 
            this.tabServicios.BackColor = System.Drawing.Color.White;
            this.tabServicios.Controls.Add(this.groupBoxGestionServicios);
            this.tabServicios.Controls.Add(this.groupBoxAgregarServicio);
            this.tabServicios.Location = new System.Drawing.Point(4, 32);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Size = new System.Drawing.Size(968, 582);
            this.tabServicios.TabIndex = 2;
            this.tabServicios.Text = "🛎️ Servicios";
            // 
            // groupBoxGestionServicios
            // 
            this.groupBoxGestionServicios.Controls.Add(this.btnEliminarServicio);
            this.groupBoxGestionServicios.Controls.Add(this.lstServicios);
            this.groupBoxGestionServicios.Controls.Add(this.lblServiciosReserva);
            this.groupBoxGestionServicios.Location = new System.Drawing.Point(490, 20);
            this.groupBoxGestionServicios.Name = "groupBoxGestionServicios";
            this.groupBoxGestionServicios.Size = new System.Drawing.Size(460, 535);
            this.groupBoxGestionServicios.TabIndex = 1;
            this.groupBoxGestionServicios.TabStop = false;
            this.groupBoxGestionServicios.Text = "Servicios de la Reserva";
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarServicio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarServicio.Location = new System.Drawing.Point(20, 475);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(420, 40);
            this.btnEliminarServicio.TabIndex = 2;
            this.btnEliminarServicio.Text = "Eliminar Servicio Seleccionado";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // lstServicios
            // 
            this.lstServicios.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.ItemHeight = 18;
            this.lstServicios.Location = new System.Drawing.Point(20, 55);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(420, 400);
            this.lstServicios.TabIndex = 1;
            // 
            // lblServiciosReserva
            // 
            this.lblServiciosReserva.AutoSize = true;
            this.lblServiciosReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblServiciosReserva.Location = new System.Drawing.Point(20, 32);
            this.lblServiciosReserva.Name = "lblServiciosReserva";
            this.lblServiciosReserva.Size = new System.Drawing.Size(253, 20);
            this.lblServiciosReserva.TabIndex = 0;
            this.lblServiciosReserva.Text = "Servicios contratados en la reserva:";
            // 
            // groupBoxAgregarServicio
            // 
            this.groupBoxAgregarServicio.Controls.Add(this.panelPaseo);
            this.groupBoxAgregarServicio.Controls.Add(this.panelLimpieza);
            this.groupBoxAgregarServicio.Controls.Add(this.panelHospedaje);
            this.groupBoxAgregarServicio.Controls.Add(this.btnAgregarServicio);
            this.groupBoxAgregarServicio.Controls.Add(this.cmbTipoServicio);
            this.groupBoxAgregarServicio.Controls.Add(this.lblTipoServicio);
            this.groupBoxAgregarServicio.Controls.Add(this.cmbReservasServicios);
            this.groupBoxAgregarServicio.Controls.Add(this.lblReservaServicio);
            this.groupBoxAgregarServicio.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAgregarServicio.Name = "groupBoxAgregarServicio";
            this.groupBoxAgregarServicio.Size = new System.Drawing.Size(450, 535);
            this.groupBoxAgregarServicio.TabIndex = 0;
            this.groupBoxAgregarServicio.TabStop = false;
            this.groupBoxAgregarServicio.Text = "Agregar Servicio";
            // 
            // panelPaseo
            // 
            this.panelPaseo.Controls.Add(this.chkEsGrupal);
            this.panelPaseo.Controls.Add(this.numPrecioHora);
            this.panelPaseo.Controls.Add(this.lblPrecioHora);
            this.panelPaseo.Controls.Add(this.numHoras);
            this.panelPaseo.Controls.Add(this.lblHoras);
            this.panelPaseo.Location = new System.Drawing.Point(20, 180);
            this.panelPaseo.Name = "panelPaseo";
            this.panelPaseo.Size = new System.Drawing.Size(410, 280);
            this.panelPaseo.TabIndex = 7;
            this.panelPaseo.Visible = false;
            // 
            // chkEsGrupal
            // 
            this.chkEsGrupal.AutoSize = true;
            this.chkEsGrupal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkEsGrupal.Location = new System.Drawing.Point(20, 172);
            this.chkEsGrupal.Name = "chkEsGrupal";
            this.chkEsGrupal.Size = new System.Drawing.Size(228, 24);
            this.chkEsGrupal.TabIndex = 4;
            this.chkEsGrupal.Text = "Paseo Grupal (Costo +25%)";
            this.chkEsGrupal.UseVisualStyleBackColor = true;
            // 
            // numPrecioHora
            // 
            this.numPrecioHora.DecimalPlaces = 2;
            this.numPrecioHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPrecioHora.Location = new System.Drawing.Point(20, 125);
            this.numPrecioHora.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecioHora.Name = "numPrecioHora";
            this.numPrecioHora.Size = new System.Drawing.Size(370, 27);
            this.numPrecioHora.TabIndex = 3;
            this.numPrecioHora.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblPrecioHora
            // 
            this.lblPrecioHora.AutoSize = true;
            this.lblPrecioHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioHora.Location = new System.Drawing.Point(20, 102);
            this.lblPrecioHora.Name = "lblPrecioHora";
            this.lblPrecioHora.Size = new System.Drawing.Size(108, 20);
            this.lblPrecioHora.TabIndex = 2;
            this.lblPrecioHora.Text = "Precio x Hora:";
            // 
            // numHoras
            // 
            this.numHoras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHoras.Location = new System.Drawing.Point(20, 60);
            this.numHoras.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(370, 27);
            this.numHoras.TabIndex = 1;
            this.numHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoras.Location = new System.Drawing.Point(20, 37);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(130, 20);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Duración (horas):";
            // 
            // panelLimpieza
            // 
            this.panelLimpieza.Controls.Add(this.numPrecioBaseLimpieza);
            this.panelLimpieza.Controls.Add(this.lblPrecioBaseLimpieza);
            this.panelLimpieza.Controls.Add(this.chkIncluyeCorte);
            this.panelLimpieza.Location = new System.Drawing.Point(20, 180);
            this.panelLimpieza.Name = "panelLimpieza";
            this.panelLimpieza.Size = new System.Drawing.Size(410, 280);
            this.panelLimpieza.TabIndex = 6;
            this.panelLimpieza.Visible = false;
            // 
            // numPrecioBaseLimpieza
            // 
            this.numPrecioBaseLimpieza.DecimalPlaces = 2;
            this.numPrecioBaseLimpieza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPrecioBaseLimpieza.Location = new System.Drawing.Point(20, 60);
            this.numPrecioBaseLimpieza.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecioBaseLimpieza.Name = "numPrecioBaseLimpieza";
            this.numPrecioBaseLimpieza.Size = new System.Drawing.Size(370, 27);
            this.numPrecioBaseLimpieza.TabIndex = 2;
            this.numPrecioBaseLimpieza.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblPrecioBaseLimpieza
            // 
            this.lblPrecioBaseLimpieza.AutoSize = true;
            this.lblPrecioBaseLimpieza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioBaseLimpieza.Location = new System.Drawing.Point(20, 37);
            this.lblPrecioBaseLimpieza.Name = "lblPrecioBaseLimpieza";
            this.lblPrecioBaseLimpieza.Size = new System.Drawing.Size(92, 20);
            this.lblPrecioBaseLimpieza.TabIndex = 1;
            this.lblPrecioBaseLimpieza.Text = "Precio Base:";
            // 
            // chkIncluyeCorte
            // 
            this.chkIncluyeCorte.AutoSize = true;
            this.chkIncluyeCorte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkIncluyeCorte.Location = new System.Drawing.Point(20, 107);
            this.chkIncluyeCorte.Name = "chkIncluyeCorte";
            this.chkIncluyeCorte.Size = new System.Drawing.Size(195, 24);
            this.chkIncluyeCorte.TabIndex = 0;
            this.chkIncluyeCorte.Text = "Incluye Corte (+$15.00)";
            this.chkIncluyeCorte.UseVisualStyleBackColor = true;
            // 
            // panelHospedaje
            // 
            this.panelHospedaje.Controls.Add(this.numPrecioDia);
            this.panelHospedaje.Controls.Add(this.lblPrecioDia);
            this.panelHospedaje.Controls.Add(this.numDias);
            this.panelHospedaje.Controls.Add(this.lblDias);
            this.panelHospedaje.Location = new System.Drawing.Point(20, 180);
            this.panelHospedaje.Name = "panelHospedaje";
            this.panelHospedaje.Size = new System.Drawing.Size(410, 280);
            this.panelHospedaje.TabIndex = 5;
            this.panelHospedaje.Visible = false;
            // 
            // numPrecioDia
            // 
            this.numPrecioDia.DecimalPlaces = 2;
            this.numPrecioDia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPrecioDia.Location = new System.Drawing.Point(20, 125);
            this.numPrecioDia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecioDia.Name = "numPrecioDia";
            this.numPrecioDia.Size = new System.Drawing.Size(370, 27);
            this.numPrecioDia.TabIndex = 3;
            this.numPrecioDia.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblPrecioDia
            // 
            this.lblPrecioDia.AutoSize = true;
            this.lblPrecioDia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioDia.Location = new System.Drawing.Point(20, 102);
            this.lblPrecioDia.Name = "lblPrecioDia";
            this.lblPrecioDia.Size = new System.Drawing.Size(100, 20);
            this.lblPrecioDia.TabIndex = 2;
            this.lblPrecioDia.Text = "Precio x Día:";
            // 
            // numDias
            // 
            this.numDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numDias.Location = new System.Drawing.Point(20, 60);
            this.numDias.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(370, 27);
            this.numDias.TabIndex = 1;
            this.numDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDias.Location = new System.Drawing.Point(20, 37);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(124, 20);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Cantidad de Días:";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarServicio.Location = new System.Drawing.Point(20, 475);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(410, 40);
            this.btnAgregarServicio.TabIndex = 4;
            this.btnAgregarServicio.Text = "Agregar Servicio a Reserva";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "Hospedaje",
            "Limpieza",
            "Paseo"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(20, 115);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(410, 28);
            this.cmbTipoServicio.TabIndex = 3;
            this.cmbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServicio_SelectedIndexChanged);
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoServicio.Location = new System.Drawing.Point(20, 92);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(126, 20);
            this.lblTipoServicio.TabIndex = 2;
            this.lblTipoServicio.Text = "Tipo de Servicio:";
            // 
            // cmbReservasServicios
            // 
            this.cmbReservasServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReservasServicios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbReservasServicios.FormattingEnabled = true;
            this.cmbReservasServicios.Location = new System.Drawing.Point(20, 55);
            this.cmbReservasServicios.Name = "cmbReservasServicios";
            this.cmbReservasServicios.Size = new System.Drawing.Size(410, 28);
            this.cmbReservasServicios.TabIndex = 1;
            this.cmbReservasServicios.SelectedIndexChanged += new System.EventHandler(this.cmbReservasServicios_SelectedIndexChanged);
            // 
            // lblReservaServicio
            // 
            this.lblReservaServicio.AutoSize = true;
            this.lblReservaServicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReservaServicio.Location = new System.Drawing.Point(20, 32);
            this.lblReservaServicio.Name = "lblReservaServicio";
            this.lblReservaServicio.Size = new System.Drawing.Size(142, 20);
            this.lblReservaServicio.TabIndex = 0;
            this.lblReservaServicio.Text = "Seleccione Reserva:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 712);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardería Canina - Sistema de Gestión";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            this.groupBoxMascotas.ResumeLayout(false);
            this.groupBoxMascotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.groupBoxClientes.ResumeLayout(false);
            this.groupBoxClientes.PerformLayout();
            this.tabReservas.ResumeLayout(false);
            this.tabReservas.PerformLayout();
            this.groupBoxNuevaReserva.ResumeLayout(false);
            this.groupBoxNuevaReserva.PerformLayout();
            this.tabServicios.ResumeLayout(false);
            this.groupBoxGestionServicios.ResumeLayout(false);
            this.groupBoxGestionServicios.PerformLayout();
            this.groupBoxAgregarServicio.ResumeLayout(false);
            this.groupBoxAgregarServicio.PerformLayout();
            this.panelPaseo.ResumeLayout(false);
            this.panelPaseo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            this.panelLimpieza.ResumeLayout(false);
            this.panelLimpieza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioBaseLimpieza)).EndInit();
            this.panelHospedaje.ResumeLayout(false);
            this.panelHospedaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabReservas;
        private System.Windows.Forms.TabPage tabServicios;

        // Tab Clientes
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.GroupBox groupBoxMascotas;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label lblClienteMascota;
        private System.Windows.Forms.ComboBox cmbClientesMascotas;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.ListBox lstClientes;

        // Tab Reservas
        private System.Windows.Forms.GroupBox groupBoxNuevaReserva;
        private System.Windows.Forms.Label lblClienteReserva;
        private System.Windows.Forms.ComboBox cmbClientesReservas;
        private System.Windows.Forms.Label lblMascotaReserva;
        private System.Windows.Forms.ComboBox cmbMascotasReservas;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.Label lblListaReservas;
        private System.Windows.Forms.TextBox txtReservas;

        // Tab Servicios
        private System.Windows.Forms.GroupBox groupBoxAgregarServicio;
        private System.Windows.Forms.GroupBox groupBoxGestionServicios;
        private System.Windows.Forms.Label lblReservaServicio;
        private System.Windows.Forms.ComboBox cmbReservasServicios;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Panel panelHospedaje;
        private System.Windows.Forms.Panel panelLimpieza;
        private System.Windows.Forms.Panel panelPaseo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.Label lblPrecioDia;
        private System.Windows.Forms.NumericUpDown numPrecioDia;
        private System.Windows.Forms.CheckBox chkIncluyeCorte;
        private System.Windows.Forms.Label lblPrecioBaseLimpieza;
        private System.Windows.Forms.NumericUpDown numPrecioBaseLimpieza;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.Label lblPrecioHora;
        private System.Windows.Forms.NumericUpDown numPrecioHora;
        private System.Windows.Forms.CheckBox chkEsGrupal;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Label lblServiciosReserva;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.Button btnEliminarServicio;
    }
}