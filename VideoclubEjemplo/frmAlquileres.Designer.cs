
namespace VideoclubEjemplo
{
    partial class frmAlquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlquileres));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAlquilar = new System.Windows.Forms.TabPage();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnCogerPrestada = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cmbTitulo = new System.Windows.Forms.ComboBox();
            this.txtArgumento = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstilo = new System.Windows.Forms.TextBox();
            this.txtProtagonista = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.pcbCaratula = new System.Windows.Forms.PictureBox();
            this.txtCaratula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblCodPeli = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpDevolver = new System.Windows.Forms.TabPage();
            this.txtTituloAlquiler = new System.Windows.Forms.TextBox();
            this.txtCodigoAlquiler = new System.Windows.Forms.TextBox();
            this.btnDevolverPelicula = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.codAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alquilerPorSocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new VideoclubEjemplo.dsBD();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.alquilerPorSocioTableAdapter = new VideoclubEjemplo.dsBDTableAdapters.AlquilerPorSocioTableAdapter();
            this.peliculasTableAdapter = new VideoclubEjemplo.dsBDTableAdapters.peliculasTableAdapter();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresTableAdapter = new VideoclubEjemplo.dsBDTableAdapters.alquileresTableAdapter();
            this.categoriasTableAdapter1 = new VideoclubEjemplo.dsBDTableAdapters.categoriasTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tpAlquilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCaratula)).BeginInit();
            this.tpDevolver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerPorSocioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAlquilar);
            this.tabControl1.Controls.Add(this.tpDevolver);
            this.tabControl1.Location = new System.Drawing.Point(12, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAlquilar
            // 
            this.tpAlquilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpAlquilar.Controls.Add(this.nudStock);
            this.tpAlquilar.Controls.Add(this.btnCogerPrestada);
            this.tpAlquilar.Controls.Add(this.txtAño);
            this.tpAlquilar.Controls.Add(this.cmbTitulo);
            this.tpAlquilar.Controls.Add(this.txtArgumento);
            this.tpAlquilar.Controls.Add(this.txtCategoria);
            this.tpAlquilar.Controls.Add(this.label11);
            this.tpAlquilar.Controls.Add(this.txtEstilo);
            this.tpAlquilar.Controls.Add(this.txtProtagonista);
            this.tpAlquilar.Controls.Add(this.txtDirector);
            this.tpAlquilar.Controls.Add(this.pcbCaratula);
            this.tpAlquilar.Controls.Add(this.txtCaratula);
            this.tpAlquilar.Controls.Add(this.label10);
            this.tpAlquilar.Controls.Add(this.label9);
            this.tpAlquilar.Controls.Add(this.lbl9);
            this.tpAlquilar.Controls.Add(this.lblCodPeli);
            this.tpAlquilar.Controls.Add(this.label8);
            this.tpAlquilar.Controls.Add(this.label7);
            this.tpAlquilar.Controls.Add(this.label6);
            this.tpAlquilar.Controls.Add(this.label5);
            this.tpAlquilar.Controls.Add(this.label4);
            this.tpAlquilar.Controls.Add(this.label3);
            this.tpAlquilar.Location = new System.Drawing.Point(4, 22);
            this.tpAlquilar.Name = "tpAlquilar";
            this.tpAlquilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlquilar.Size = new System.Drawing.Size(774, 311);
            this.tpAlquilar.TabIndex = 0;
            this.tpAlquilar.Text = "ALQUILAR";
            // 
            // nudStock
            // 
            this.nudStock.Enabled = false;
            this.nudStock.Location = new System.Drawing.Point(557, 23);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(48, 20);
            this.nudStock.TabIndex = 31;
            // 
            // btnCogerPrestada
            // 
            this.btnCogerPrestada.Enabled = false;
            this.btnCogerPrestada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCogerPrestada.Location = new System.Drawing.Point(23, 253);
            this.btnCogerPrestada.Name = "btnCogerPrestada";
            this.btnCogerPrestada.Size = new System.Drawing.Size(569, 28);
            this.btnCogerPrestada.TabIndex = 30;
            this.btnCogerPrestada.Text = "Coger Prestada";
            this.btnCogerPrestada.UseVisualStyleBackColor = true;
            this.btnCogerPrestada.Click += new System.EventHandler(this.btnCogerPrestada_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(260, 23);
            this.txtAño.Name = "txtAño";
            this.txtAño.ReadOnly = true;
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 29;
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.FormattingEnabled = true;
            this.cmbTitulo.Location = new System.Drawing.Point(126, 53);
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.Size = new System.Drawing.Size(338, 21);
            this.cmbTitulo.TabIndex = 28;
            this.cmbTitulo.SelectedIndexChanged += new System.EventHandler(this.cmbTitulo_SelectedIndexChanged);
            // 
            // txtArgumento
            // 
            this.txtArgumento.Location = new System.Drawing.Point(126, 154);
            this.txtArgumento.Multiline = true;
            this.txtArgumento.Name = "txtArgumento";
            this.txtArgumento.ReadOnly = true;
            this.txtArgumento.Size = new System.Drawing.Size(466, 93);
            this.txtArgumento.TabIndex = 27;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(395, 129);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(197, 20);
            this.txtCategoria.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(320, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Categoria";
            // 
            // txtEstilo
            // 
            this.txtEstilo.Location = new System.Drawing.Point(126, 128);
            this.txtEstilo.Name = "txtEstilo";
            this.txtEstilo.ReadOnly = true;
            this.txtEstilo.Size = new System.Drawing.Size(188, 20);
            this.txtEstilo.TabIndex = 24;
            // 
            // txtProtagonista
            // 
            this.txtProtagonista.Location = new System.Drawing.Point(126, 102);
            this.txtProtagonista.Name = "txtProtagonista";
            this.txtProtagonista.ReadOnly = true;
            this.txtProtagonista.Size = new System.Drawing.Size(466, 20);
            this.txtProtagonista.TabIndex = 23;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(126, 76);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.ReadOnly = true;
            this.txtDirector.Size = new System.Drawing.Size(466, 20);
            this.txtDirector.TabIndex = 22;
            // 
            // pcbCaratula
            // 
            this.pcbCaratula.Location = new System.Drawing.Point(632, 90);
            this.pcbCaratula.Name = "pcbCaratula";
            this.pcbCaratula.Size = new System.Drawing.Size(113, 157);
            this.pcbCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCaratula.TabIndex = 20;
            this.pcbCaratula.TabStop = false;
            // 
            // txtCaratula
            // 
            this.txtCaratula.Location = new System.Drawing.Point(632, 54);
            this.txtCaratula.Name = "txtCaratula";
            this.txtCaratula.ReadOnly = true;
            this.txtCaratula.Size = new System.Drawing.Size(113, 20);
            this.txtCaratula.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "caratula";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stock";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(221, 24);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(31, 15);
            this.lbl9.TabIndex = 16;
            this.lbl9.Text = "Año";
            // 
            // lblCodPeli
            // 
            this.lblCodPeli.AutoSize = true;
            this.lblCodPeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPeli.Location = new System.Drawing.Point(95, 24);
            this.lblCodPeli.Name = "lblCodPeli";
            this.lblCodPeli.Size = new System.Drawing.Size(15, 15);
            this.lblCodPeli.TabIndex = 15;
            this.lblCodPeli.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Argumento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estilo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Protagonista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "CodPeli";
            // 
            // tpDevolver
            // 
            this.tpDevolver.BackColor = System.Drawing.Color.LightGreen;
            this.tpDevolver.Controls.Add(this.txtTituloAlquiler);
            this.tpDevolver.Controls.Add(this.txtCodigoAlquiler);
            this.tpDevolver.Controls.Add(this.btnDevolverPelicula);
            this.tpDevolver.Controls.Add(this.label13);
            this.tpDevolver.Controls.Add(this.label12);
            this.tpDevolver.Location = new System.Drawing.Point(4, 22);
            this.tpDevolver.Name = "tpDevolver";
            this.tpDevolver.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolver.Size = new System.Drawing.Size(774, 311);
            this.tpDevolver.TabIndex = 1;
            this.tpDevolver.Text = "DEVOLVER";
            // 
            // txtTituloAlquiler
            // 
            this.txtTituloAlquiler.Enabled = false;
            this.txtTituloAlquiler.Location = new System.Drawing.Point(285, 108);
            this.txtTituloAlquiler.Name = "txtTituloAlquiler";
            this.txtTituloAlquiler.Size = new System.Drawing.Size(419, 20);
            this.txtTituloAlquiler.TabIndex = 33;
            // 
            // txtCodigoAlquiler
            // 
            this.txtCodigoAlquiler.Enabled = false;
            this.txtCodigoAlquiler.Location = new System.Drawing.Point(285, 43);
            this.txtCodigoAlquiler.Name = "txtCodigoAlquiler";
            this.txtCodigoAlquiler.Size = new System.Drawing.Size(268, 20);
            this.txtCodigoAlquiler.TabIndex = 32;
            // 
            // btnDevolverPelicula
            // 
            this.btnDevolverPelicula.Enabled = false;
            this.btnDevolverPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverPelicula.Location = new System.Drawing.Point(559, 43);
            this.btnDevolverPelicula.Name = "btnDevolverPelicula";
            this.btnDevolverPelicula.Size = new System.Drawing.Size(145, 43);
            this.btnDevolverPelicula.TabIndex = 31;
            this.btnDevolverPelicula.Text = "Devolver Película";
            this.btnDevolverPelicula.UseVisualStyleBackColor = true;
            this.btnDevolverPelicula.Click += new System.EventHandler(this.btnDevolverPelicula_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(137, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Titulo de la película: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(137, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Código alquiler: ";
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.AutoGenerateColumns = false;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlquilerDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaAlquilerDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.socio});
            this.dgvAlquileres.DataSource = this.alquilerPorSocioBindingSource;
            this.dgvAlquileres.Location = new System.Drawing.Point(16, 463);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlquileres.Size = new System.Drawing.Size(774, 150);
            this.dgvAlquileres.TabIndex = 1;
            this.dgvAlquileres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquileres_CellDoubleClick);
            // 
            // codAlquilerDataGridViewTextBoxColumn
            // 
            this.codAlquilerDataGridViewTextBoxColumn.DataPropertyName = "codAlquiler";
            this.codAlquilerDataGridViewTextBoxColumn.HeaderText = "codAlquiler";
            this.codAlquilerDataGridViewTextBoxColumn.Name = "codAlquilerDataGridViewTextBoxColumn";
            this.codAlquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // fechaAlquilerDataGridViewTextBoxColumn
            // 
            this.fechaAlquilerDataGridViewTextBoxColumn.DataPropertyName = "fechaAlquiler";
            this.fechaAlquilerDataGridViewTextBoxColumn.HeaderText = "fechaAlquiler";
            this.fechaAlquilerDataGridViewTextBoxColumn.Name = "fechaAlquilerDataGridViewTextBoxColumn";
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "fechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "fechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // socio
            // 
            this.socio.DataPropertyName = "socio";
            this.socio.HeaderText = "socio";
            this.socio.Name = "socio";
            this.socio.Visible = false;
            // 
            // alquilerPorSocioBindingSource
            // 
            this.alquilerPorSocioBindingSource.DataMember = "AlquilerPorSocio";
            this.alquilerPorSocioBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSocio.Location = new System.Drawing.Point(240, 22);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(59, 43);
            this.btnBuscarSocio.TabIndex = 2;
            this.btnBuscarSocio.Text = "...";
            this.btnBuscarSocio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarSocio.UseVisualStyleBackColor = true;
            this.btnBuscarSocio.Click += new System.EventHandler(this.btnBuscarSocio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod.Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(91, 19);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 5;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(443, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(443, 58);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 7;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(565, 58);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 8;
            // 
            // alquilerPorSocioTableAdapter
            // 
            this.alquilerPorSocioTableAdapter.ClearBeforeFill = true;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.dsBD;
            // 
            // alquileresTableAdapter
            // 
            this.alquileresTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasTableAdapter1
            // 
            this.categoriasTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 625);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarSocio);
            this.Controls.Add(this.dgvAlquileres);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlquileres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquileres";
            this.Load += new System.EventHandler(this.frmAlquileres_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAlquilar.ResumeLayout(false);
            this.tpAlquilar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCaratula)).EndInit();
            this.tpDevolver.ResumeLayout(false);
            this.tpDevolver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerPorSocioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAlquilar;
        private System.Windows.Forms.TabPage tpDevolver;
        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblCodPeli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCaratula;
        private System.Windows.Forms.PictureBox pcbCaratula;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtProtagonista;
        private System.Windows.Forms.TextBox txtEstilo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArgumento;
        private System.Windows.Forms.ComboBox cmbTitulo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnCogerPrestada;
        private dsBD dsBD;
        private System.Windows.Forms.BindingSource alquilerPorSocioBindingSource;
        private dsBDTableAdapters.AlquilerPorSocioTableAdapter alquilerPorSocioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socio;
        private dsBDTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDevolverPelicula;
        private System.Windows.Forms.TextBox txtTituloAlquiler;
        private System.Windows.Forms.TextBox txtCodigoAlquiler;
        private dsBDTableAdapters.alquileresTableAdapter alquileresTableAdapter;
        private dsBDTableAdapters.categoriasTableAdapter categoriasTableAdapter1;
    }
}