namespace SistemaVeterinaria.Principal
{
    partial class FrmVacunas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSoles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVacunacion = new System.Windows.Forms.DataGridView();
            this.txtVacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDetalle = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarM = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarPorDni = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunacion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtSoles);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvVacunacion);
            this.groupBox2.Controls.Add(this.txtVacuna);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateFecha);
            this.groupBox2.Controls.Add(this.txtDetalle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(127, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(576, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Vacuna";
            // 
            // txtSoles
            // 
            this.txtSoles.Location = new System.Drawing.Point(431, 91);
            this.txtSoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoles.MaxLength = 2;
            this.txtSoles.Name = "txtSoles";
            this.txtSoles.Size = new System.Drawing.Size(44, 23);
            this.txtSoles.TabIndex = 84;
            this.txtSoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoles_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "S/.";
            // 
            // dgvVacunacion
            // 
            this.dgvVacunacion.AllowUserToAddRows = false;
            this.dgvVacunacion.AllowUserToDeleteRows = false;
            this.dgvVacunacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunacion.Location = new System.Drawing.Point(17, 129);
            this.dgvVacunacion.Name = "dgvVacunacion";
            this.dgvVacunacion.ReadOnly = true;
            this.dgvVacunacion.RowHeadersWidth = 51;
            this.dgvVacunacion.Size = new System.Drawing.Size(547, 151);
            this.dgvVacunacion.TabIndex = 79;
            this.dgvVacunacion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVacunacion_CellMouseClick);
            // 
            // txtVacuna
            // 
            this.txtVacuna.BackColor = System.Drawing.SystemColors.Window;
            this.txtVacuna.Location = new System.Drawing.Point(168, 26);
            this.txtVacuna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVacuna.Name = "txtVacuna";
            this.txtVacuna.Size = new System.Drawing.Size(160, 23);
            this.txtVacuna.TabIndex = 23;
            this.txtVacuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVacuna_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nombre de Vacuna:";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "yyyy-MM-dd";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(431, 60);
            this.dateFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(134, 23);
            this.dateFecha.TabIndex = 77;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(86, 53);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(242, 61);
            this.txtDetalle.TabIndex = 15;
            this.txtDetalle.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Detalle :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(436, 609);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(85, 41);
            this.btnGuardar.TabIndex = 70;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(346, 609);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(85, 41);
            this.btnNuevo.TabIndex = 69;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(525, 609);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(85, 41);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtNombres);
            this.groupBox3.Controls.Add(this.txtDni);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(127, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(576, 82);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Propietario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(169, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 23);
            this.btnBuscar.TabIndex = 86;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(363, 40);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(160, 23);
            this.txtNombres.TabIndex = 12;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(77, 43);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(88, 23);
            this.txtDni.TabIndex = 11;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(280, 43);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Nombres:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 43);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Dni :";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnBuscarM);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtEstado);
            this.groupBox4.Controls.Add(this.txtNacimiento);
            this.groupBox4.Controls.Add(this.txtSexo);
            this.groupBox4.Controls.Add(this.txtPeso);
            this.groupBox4.Controls.Add(this.txtRaza);
            this.groupBox4.Controls.Add(this.txtEspecie);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(127, 172);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(576, 144);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Mascota";
            // 
            // btnBuscarM
            // 
            this.btnBuscarM.Depth = 0;
            this.btnBuscarM.Location = new System.Drawing.Point(169, 25);
            this.btnBuscarM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarM.Name = "btnBuscarM";
            this.btnBuscarM.Primary = true;
            this.btnBuscarM.Size = new System.Drawing.Size(74, 23);
            this.btnBuscarM.TabIndex = 86;
            this.btnBuscarM.Text = "Buscar";
            this.btnBuscarM.UseVisualStyleBackColor = true;
            this.btnBuscarM.Click += new System.EventHandler(this.btnBuscarM_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEstado.Location = new System.Drawing.Point(377, 82);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(160, 23);
            this.txtEstado.TabIndex = 21;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNacimiento.Location = new System.Drawing.Point(377, 52);
            this.txtNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(160, 23);
            this.txtNacimiento.TabIndex = 20;
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSexo.Location = new System.Drawing.Point(377, 22);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(160, 23);
            this.txtSexo.TabIndex = 19;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPeso.Location = new System.Drawing.Point(77, 105);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(166, 23);
            this.txtPeso.TabIndex = 18;
            // 
            // txtRaza
            // 
            this.txtRaza.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRaza.Location = new System.Drawing.Point(77, 79);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(166, 23);
            this.txtRaza.TabIndex = 17;
            // 
            // txtEspecie
            // 
            this.txtEspecie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEspecie.Location = new System.Drawing.Point(77, 52);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(166, 23);
            this.txtEspecie.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(77, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(88, 23);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Peso(kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raza:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Especie:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Nombre:";
            // 
            // btnListar
            // 
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(614, 609);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = true;
            this.btnListar.Size = new System.Drawing.Size(85, 41);
            this.btnListar.TabIndex = 85;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 611);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Buscar Dni:";
            // 
            // btnBuscarPorDni
            // 
            this.btnBuscarPorDni.Depth = 0;
            this.btnBuscarPorDni.Location = new System.Drawing.Point(223, 612);
            this.btnBuscarPorDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPorDni.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarPorDni.Name = "btnBuscarPorDni";
            this.btnBuscarPorDni.Primary = true;
            this.btnBuscarPorDni.Size = new System.Drawing.Size(88, 38);
            this.btnBuscarPorDni.TabIndex = 93;
            this.btnBuscarPorDni.Text = "Buscar";
            this.btnBuscarPorDni.UseVisualStyleBackColor = true;
            this.btnBuscarPorDni.Click += new System.EventHandler(this.btnBuscarPorDni_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(128, 630);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.MaxLength = 8;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(91, 20);
            this.txtBuscar.TabIndex = 92;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // FrmVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscarPorDni);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVacunas";
            this.Text = "Registro Vacunas";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunacion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.DataGridView dgvVacunacion;
        private System.Windows.Forms.TextBox txtVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialRaisedButton btnListar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarM;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarPorDni;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtSoles;
        private System.Windows.Forms.Label label4;
    }
}