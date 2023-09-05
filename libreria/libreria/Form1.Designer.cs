namespace libreria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonRecargar = new System.Windows.Forms.Button();
            this.buttonDeletePrestamo = new System.Windows.Forms.Button();
            this.buttonAddPrestamo = new System.Windows.Forms.Button();
            this.fechaDevolucionLabel = new System.Windows.Forms.Label();
            this.txtBoxDevolucionPrestamo = new System.Windows.Forms.TextBox();
            this.fechaPrestamoLabel = new System.Windows.Forms.Label();
            this.txtBoxFechaPrestamo = new System.Windows.Forms.TextBox();
            this.idSocioPrestamoLabel = new System.Windows.Forms.Label();
            this.txtBoxIDSocioPrestamo = new System.Windows.Forms.TextBox();
            this.idLibroPrestamoLabel = new System.Windows.Forms.Label();
            this.txtBoxIDLibroPrestamo = new System.Windows.Forms.TextBox();
            this.idPrestamoLabel = new System.Windows.Forms.Label();
            this.txtBoxIdPrestamo = new System.Windows.Forms.TextBox();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.buttonEliminarSocio = new System.Windows.Forms.Button();
            this.buttonAgregarSocio = new System.Windows.Forms.Button();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.apellidoSocioLabel = new System.Windows.Forms.Label();
            this.nombreSocioLabel = new System.Windows.Forms.Label();
            this.idSocioLabel = new System.Windows.Forms.Label();
            this.txtBoxTelefonoSocio = new System.Windows.Forms.TextBox();
            this.txtBoxApellidoSocio = new System.Windows.Forms.TextBox();
            this.txtBoxIdSocio = new System.Windows.Forms.TextBox();
            this.txtBoxNombreSocio = new System.Windows.Forms.TextBox();
            this.dataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.icbnLabel = new System.Windows.Forms.Label();
            this.textBoxICBN = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridLibro = new System.Windows.Forms.DataGridView();
            this.paginasLabel = new System.Windows.Forms.Label();
            this.lanzamientoLabel = new System.Windows.Forms.Label();
            this.generoLabel = new System.Windows.Forms.Label();
            this.autorLabel = new System.Windows.Forms.Label();
            this.nombreLibroLabel = new System.Windows.Forms.Label();
            this.idLibroLabel = new System.Windows.Forms.Label();
            this.textBoxIdLibro = new System.Windows.Forms.TextBox();
            this.textBoxPaginas = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxLanzamiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.librosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRecargar
            // 
            this.botonRecargar.Location = new System.Drawing.Point(853, 6);
            this.botonRecargar.Name = "botonRecargar";
            this.botonRecargar.Size = new System.Drawing.Size(75, 23);
            this.botonRecargar.TabIndex = 89;
            this.botonRecargar.Text = "Recargar";
            this.botonRecargar.UseVisualStyleBackColor = true;
            this.botonRecargar.Click += new System.EventHandler(this.botonRecargar_Click);
            // 
            // buttonDeletePrestamo
            // 
            this.buttonDeletePrestamo.Location = new System.Drawing.Point(847, 411);
            this.buttonDeletePrestamo.Name = "buttonDeletePrestamo";
            this.buttonDeletePrestamo.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePrestamo.TabIndex = 88;
            this.buttonDeletePrestamo.Text = "Eliminar";
            this.buttonDeletePrestamo.UseVisualStyleBackColor = true;
            this.buttonDeletePrestamo.Click += new System.EventHandler(this.buttonDeletePrestamo_Click);
            // 
            // buttonAddPrestamo
            // 
            this.buttonAddPrestamo.Location = new System.Drawing.Point(717, 367);
            this.buttonAddPrestamo.Name = "buttonAddPrestamo";
            this.buttonAddPrestamo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPrestamo.TabIndex = 87;
            this.buttonAddPrestamo.Text = "Agregar";
            this.buttonAddPrestamo.UseVisualStyleBackColor = true;
            this.buttonAddPrestamo.Click += new System.EventHandler(this.buttonAddPrestamo_Click);
            // 
            // fechaDevolucionLabel
            // 
            this.fechaDevolucionLabel.AutoSize = true;
            this.fechaDevolucionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fechaDevolucionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fechaDevolucionLabel.Location = new System.Drawing.Point(630, 316);
            this.fechaDevolucionLabel.Name = "fechaDevolucionLabel";
            this.fechaDevolucionLabel.Size = new System.Drawing.Size(139, 20);
            this.fechaDevolucionLabel.TabIndex = 86;
            this.fechaDevolucionLabel.Text = "Fecha devolucion";
            // 
            // txtBoxDevolucionPrestamo
            // 
            this.txtBoxDevolucionPrestamo.Location = new System.Drawing.Point(767, 316);
            this.txtBoxDevolucionPrestamo.Name = "txtBoxDevolucionPrestamo";
            this.txtBoxDevolucionPrestamo.Size = new System.Drawing.Size(107, 20);
            this.txtBoxDevolucionPrestamo.TabIndex = 85;
            // 
            // fechaPrestamoLabel
            // 
            this.fechaPrestamoLabel.AutoSize = true;
            this.fechaPrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fechaPrestamoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fechaPrestamoLabel.Location = new System.Drawing.Point(630, 279);
            this.fechaPrestamoLabel.Name = "fechaPrestamoLabel";
            this.fechaPrestamoLabel.Size = new System.Drawing.Size(130, 20);
            this.fechaPrestamoLabel.TabIndex = 84;
            this.fechaPrestamoLabel.Text = "Fecha prestamo";
            // 
            // txtBoxFechaPrestamo
            // 
            this.txtBoxFechaPrestamo.Location = new System.Drawing.Point(767, 281);
            this.txtBoxFechaPrestamo.Name = "txtBoxFechaPrestamo";
            this.txtBoxFechaPrestamo.Size = new System.Drawing.Size(107, 20);
            this.txtBoxFechaPrestamo.TabIndex = 83;
            // 
            // idSocioPrestamoLabel
            // 
            this.idSocioPrestamoLabel.AutoSize = true;
            this.idSocioPrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idSocioPrestamoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idSocioPrestamoLabel.Location = new System.Drawing.Point(631, 240);
            this.idSocioPrestamoLabel.Name = "idSocioPrestamoLabel";
            this.idSocioPrestamoLabel.Size = new System.Drawing.Size(73, 20);
            this.idSocioPrestamoLabel.TabIndex = 82;
            this.idSocioPrestamoLabel.Text = "ID Socio";
            this.idSocioPrestamoLabel.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtBoxIDSocioPrestamo
            // 
            this.txtBoxIDSocioPrestamo.Location = new System.Drawing.Point(740, 243);
            this.txtBoxIDSocioPrestamo.Name = "txtBoxIDSocioPrestamo";
            this.txtBoxIDSocioPrestamo.Size = new System.Drawing.Size(134, 20);
            this.txtBoxIDSocioPrestamo.TabIndex = 81;
            // 
            // idLibroPrestamoLabel
            // 
            this.idLibroPrestamoLabel.AutoSize = true;
            this.idLibroPrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idLibroPrestamoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idLibroPrestamoLabel.Location = new System.Drawing.Point(631, 198);
            this.idLibroPrestamoLabel.Name = "idLibroPrestamoLabel";
            this.idLibroPrestamoLabel.Size = new System.Drawing.Size(69, 20);
            this.idLibroPrestamoLabel.TabIndex = 80;
            this.idLibroPrestamoLabel.Text = "ID Libro";
            // 
            // txtBoxIDLibroPrestamo
            // 
            this.txtBoxIDLibroPrestamo.Location = new System.Drawing.Point(740, 200);
            this.txtBoxIDLibroPrestamo.Name = "txtBoxIDLibroPrestamo";
            this.txtBoxIDLibroPrestamo.Size = new System.Drawing.Size(134, 20);
            this.txtBoxIDLibroPrestamo.TabIndex = 79;
            // 
            // idPrestamoLabel
            // 
            this.idPrestamoLabel.AutoSize = true;
            this.idPrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idPrestamoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idPrestamoLabel.Location = new System.Drawing.Point(631, 414);
            this.idPrestamoLabel.Name = "idPrestamoLabel";
            this.idPrestamoLabel.Size = new System.Drawing.Size(103, 20);
            this.idPrestamoLabel.TabIndex = 78;
            this.idPrestamoLabel.Text = "ID Prestamo";
            this.idPrestamoLabel.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtBoxIdPrestamo
            // 
            this.txtBoxIdPrestamo.Location = new System.Drawing.Point(740, 413);
            this.txtBoxIdPrestamo.Name = "txtBoxIdPrestamo";
            this.txtBoxIdPrestamo.Size = new System.Drawing.Size(101, 20);
            this.txtBoxIdPrestamo.TabIndex = 77;
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(634, 35);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPrestamos.TabIndex = 76;
            // 
            // buttonEliminarSocio
            // 
            this.buttonEliminarSocio.Location = new System.Drawing.Point(514, 412);
            this.buttonEliminarSocio.Name = "buttonEliminarSocio";
            this.buttonEliminarSocio.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarSocio.TabIndex = 75;
            this.buttonEliminarSocio.Text = "Eliminar";
            this.buttonEliminarSocio.UseVisualStyleBackColor = true;
            this.buttonEliminarSocio.Click += new System.EventHandler(this.buttonEliminarSocio_Click);
            // 
            // buttonAgregarSocio
            // 
            this.buttonAgregarSocio.Location = new System.Drawing.Point(417, 367);
            this.buttonAgregarSocio.Name = "buttonAgregarSocio";
            this.buttonAgregarSocio.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarSocio.TabIndex = 74;
            this.buttonAgregarSocio.Text = "Agregar";
            this.buttonAgregarSocio.UseVisualStyleBackColor = true;
            this.buttonAgregarSocio.Click += new System.EventHandler(this.buttonAgregarSocio_Click);
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.telefonoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.telefonoLabel.Location = new System.Drawing.Point(328, 280);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(73, 20);
            this.telefonoLabel.TabIndex = 73;
            this.telefonoLabel.Text = "Telefono";
            // 
            // apellidoSocioLabel
            // 
            this.apellidoSocioLabel.AutoSize = true;
            this.apellidoSocioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.apellidoSocioLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.apellidoSocioLabel.Location = new System.Drawing.Point(328, 241);
            this.apellidoSocioLabel.Name = "apellidoSocioLabel";
            this.apellidoSocioLabel.Size = new System.Drawing.Size(68, 20);
            this.apellidoSocioLabel.TabIndex = 72;
            this.apellidoSocioLabel.Text = "Apellido";
            // 
            // nombreSocioLabel
            // 
            this.nombreSocioLabel.AutoSize = true;
            this.nombreSocioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreSocioLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nombreSocioLabel.Location = new System.Drawing.Point(328, 199);
            this.nombreSocioLabel.Name = "nombreSocioLabel";
            this.nombreSocioLabel.Size = new System.Drawing.Size(68, 20);
            this.nombreSocioLabel.TabIndex = 71;
            this.nombreSocioLabel.Text = "Nombre";
            // 
            // idSocioLabel
            // 
            this.idSocioLabel.AutoSize = true;
            this.idSocioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idSocioLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idSocioLabel.Location = new System.Drawing.Point(328, 412);
            this.idSocioLabel.Name = "idSocioLabel";
            this.idSocioLabel.Size = new System.Drawing.Size(73, 20);
            this.idSocioLabel.TabIndex = 70;
            this.idSocioLabel.Text = "ID Socio";
            this.idSocioLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtBoxTelefonoSocio
            // 
            this.txtBoxTelefonoSocio.Location = new System.Drawing.Point(407, 282);
            this.txtBoxTelefonoSocio.Name = "txtBoxTelefonoSocio";
            this.txtBoxTelefonoSocio.Size = new System.Drawing.Size(167, 20);
            this.txtBoxTelefonoSocio.TabIndex = 69;
            // 
            // txtBoxApellidoSocio
            // 
            this.txtBoxApellidoSocio.Location = new System.Drawing.Point(407, 244);
            this.txtBoxApellidoSocio.Name = "txtBoxApellidoSocio";
            this.txtBoxApellidoSocio.Size = new System.Drawing.Size(167, 20);
            this.txtBoxApellidoSocio.TabIndex = 68;
            // 
            // txtBoxIdSocio
            // 
            this.txtBoxIdSocio.Location = new System.Drawing.Point(407, 414);
            this.txtBoxIdSocio.Name = "txtBoxIdSocio";
            this.txtBoxIdSocio.Size = new System.Drawing.Size(101, 20);
            this.txtBoxIdSocio.TabIndex = 67;
            // 
            // txtBoxNombreSocio
            // 
            this.txtBoxNombreSocio.Location = new System.Drawing.Point(407, 201);
            this.txtBoxNombreSocio.Name = "txtBoxNombreSocio";
            this.txtBoxNombreSocio.Size = new System.Drawing.Size(167, 20);
            this.txtBoxNombreSocio.TabIndex = 66;
            // 
            // dataGridViewSocios
            // 
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocios.Location = new System.Drawing.Point(332, 32);
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewSocios.TabIndex = 65;
            // 
            // icbnLabel
            // 
            this.icbnLabel.AutoSize = true;
            this.icbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.icbnLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icbnLabel.Location = new System.Drawing.Point(37, 201);
            this.icbnLabel.Name = "icbnLabel";
            this.icbnLabel.Size = new System.Drawing.Size(49, 20);
            this.icbnLabel.TabIndex = 64;
            this.icbnLabel.Text = "ICBN";
            // 
            // textBoxICBN
            // 
            this.textBoxICBN.Location = new System.Drawing.Point(140, 200);
            this.textBoxICBN.Name = "textBoxICBN";
            this.textBoxICBN.Size = new System.Drawing.Size(140, 20);
            this.textBoxICBN.TabIndex = 63;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(205, 410);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 62;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(107, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridLibro
            // 
            this.dataGridLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibro.Location = new System.Drawing.Point(39, 32);
            this.dataGridLibro.Name = "dataGridLibro";
            this.dataGridLibro.Size = new System.Drawing.Size(240, 150);
            this.dataGridLibro.TabIndex = 60;
            // 
            // paginasLabel
            // 
            this.paginasLabel.AutoSize = true;
            this.paginasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.paginasLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.paginasLabel.Location = new System.Drawing.Point(37, 334);
            this.paginasLabel.Name = "paginasLabel";
            this.paginasLabel.Size = new System.Drawing.Size(69, 20);
            this.paginasLabel.TabIndex = 59;
            this.paginasLabel.Text = "Paginas";
            // 
            // lanzamientoLabel
            // 
            this.lanzamientoLabel.AutoSize = true;
            this.lanzamientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lanzamientoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lanzamientoLabel.Location = new System.Drawing.Point(35, 306);
            this.lanzamientoLabel.Name = "lanzamientoLabel";
            this.lanzamientoLabel.Size = new System.Drawing.Size(105, 20);
            this.lanzamientoLabel.TabIndex = 58;
            this.lanzamientoLabel.Text = "Lanzamiento";
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.generoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.generoLabel.Location = new System.Drawing.Point(37, 280);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(64, 20);
            this.generoLabel.TabIndex = 57;
            this.generoLabel.Text = "Genero";
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.autorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.autorLabel.Location = new System.Drawing.Point(37, 254);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(49, 20);
            this.autorLabel.TabIndex = 56;
            this.autorLabel.Text = "Autor";
            // 
            // nombreLibroLabel
            // 
            this.nombreLibroLabel.AutoSize = true;
            this.nombreLibroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreLibroLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nombreLibroLabel.Location = new System.Drawing.Point(37, 227);
            this.nombreLibroLabel.Name = "nombreLibroLabel";
            this.nombreLibroLabel.Size = new System.Drawing.Size(68, 20);
            this.nombreLibroLabel.TabIndex = 55;
            this.nombreLibroLabel.Text = "Nombre";
            // 
            // idLibroLabel
            // 
            this.idLibroLabel.AutoSize = true;
            this.idLibroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idLibroLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.idLibroLabel.Location = new System.Drawing.Point(23, 410);
            this.idLibroLabel.Name = "idLibroLabel";
            this.idLibroLabel.Size = new System.Drawing.Size(69, 20);
            this.idLibroLabel.TabIndex = 54;
            this.idLibroLabel.Text = "ID Libro";
            this.idLibroLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxIdLibro
            // 
            this.textBoxIdLibro.Location = new System.Drawing.Point(98, 410);
            this.textBoxIdLibro.Name = "textBoxIdLibro";
            this.textBoxIdLibro.Size = new System.Drawing.Size(101, 20);
            this.textBoxIdLibro.TabIndex = 53;
            // 
            // textBoxPaginas
            // 
            this.textBoxPaginas.Location = new System.Drawing.Point(140, 334);
            this.textBoxPaginas.Name = "textBoxPaginas";
            this.textBoxPaginas.Size = new System.Drawing.Size(140, 20);
            this.textBoxPaginas.TabIndex = 52;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(140, 226);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(140, 20);
            this.textBoxNombre.TabIndex = 51;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(140, 254);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(140, 20);
            this.textBoxAutor.TabIndex = 50;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(140, 280);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(140, 20);
            this.textBoxGenero.TabIndex = 49;
            // 
            // textBoxLanzamiento
            // 
            this.textBoxLanzamiento.Location = new System.Drawing.Point(140, 306);
            this.textBoxLanzamiento.Name = "textBoxLanzamiento";
            this.textBoxLanzamiento.Size = new System.Drawing.Size(140, 20);
            this.textBoxLanzamiento.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(713, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Prestamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(423, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Socios";
            // 
            // librosLabel
            // 
            this.librosLabel.AutoSize = true;
            this.librosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.librosLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.librosLabel.Location = new System.Drawing.Point(126, 9);
            this.librosLabel.Name = "librosLabel";
            this.librosLabel.Size = new System.Drawing.Size(56, 20);
            this.librosLabel.TabIndex = 45;
            this.librosLabel.Text = "Libros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.botonRecargar);
            this.Controls.Add(this.buttonDeletePrestamo);
            this.Controls.Add(this.buttonAddPrestamo);
            this.Controls.Add(this.fechaDevolucionLabel);
            this.Controls.Add(this.txtBoxDevolucionPrestamo);
            this.Controls.Add(this.fechaPrestamoLabel);
            this.Controls.Add(this.txtBoxFechaPrestamo);
            this.Controls.Add(this.idSocioPrestamoLabel);
            this.Controls.Add(this.txtBoxIDSocioPrestamo);
            this.Controls.Add(this.idLibroPrestamoLabel);
            this.Controls.Add(this.txtBoxIDLibroPrestamo);
            this.Controls.Add(this.idPrestamoLabel);
            this.Controls.Add(this.txtBoxIdPrestamo);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Controls.Add(this.buttonEliminarSocio);
            this.Controls.Add(this.buttonAgregarSocio);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.apellidoSocioLabel);
            this.Controls.Add(this.nombreSocioLabel);
            this.Controls.Add(this.idSocioLabel);
            this.Controls.Add(this.txtBoxTelefonoSocio);
            this.Controls.Add(this.txtBoxApellidoSocio);
            this.Controls.Add(this.txtBoxIdSocio);
            this.Controls.Add(this.txtBoxNombreSocio);
            this.Controls.Add(this.dataGridViewSocios);
            this.Controls.Add(this.icbnLabel);
            this.Controls.Add(this.textBoxICBN);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridLibro);
            this.Controls.Add(this.paginasLabel);
            this.Controls.Add(this.lanzamientoLabel);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.nombreLibroLabel);
            this.Controls.Add(this.idLibroLabel);
            this.Controls.Add(this.textBoxIdLibro);
            this.Controls.Add(this.textBoxPaginas);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.textBoxLanzamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.librosLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRecargar;
        private System.Windows.Forms.Button buttonDeletePrestamo;
        private System.Windows.Forms.Button buttonAddPrestamo;
        private System.Windows.Forms.Label fechaDevolucionLabel;
        private System.Windows.Forms.TextBox txtBoxDevolucionPrestamo;
        private System.Windows.Forms.Label fechaPrestamoLabel;
        private System.Windows.Forms.TextBox txtBoxFechaPrestamo;
        private System.Windows.Forms.Label idSocioPrestamoLabel;
        private System.Windows.Forms.TextBox txtBoxIDSocioPrestamo;
        private System.Windows.Forms.Label idLibroPrestamoLabel;
        private System.Windows.Forms.TextBox txtBoxIDLibroPrestamo;
        private System.Windows.Forms.Label idPrestamoLabel;
        private System.Windows.Forms.TextBox txtBoxIdPrestamo;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.Button buttonEliminarSocio;
        private System.Windows.Forms.Button buttonAgregarSocio;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label apellidoSocioLabel;
        private System.Windows.Forms.Label nombreSocioLabel;
        private System.Windows.Forms.Label idSocioLabel;
        private System.Windows.Forms.TextBox txtBoxTelefonoSocio;
        private System.Windows.Forms.TextBox txtBoxApellidoSocio;
        private System.Windows.Forms.TextBox txtBoxIdSocio;
        private System.Windows.Forms.TextBox txtBoxNombreSocio;
        private System.Windows.Forms.DataGridView dataGridViewSocios;
        private System.Windows.Forms.Label icbnLabel;
        private System.Windows.Forms.TextBox textBoxICBN;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridLibro;
        private System.Windows.Forms.Label paginasLabel;
        private System.Windows.Forms.Label lanzamientoLabel;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.Label nombreLibroLabel;
        private System.Windows.Forms.Label idLibroLabel;
        private System.Windows.Forms.TextBox textBoxIdLibro;
        private System.Windows.Forms.TextBox textBoxPaginas;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.TextBox textBoxLanzamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label librosLabel;
    }
}

