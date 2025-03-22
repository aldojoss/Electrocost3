namespace Electrocost3
{
    partial class FormAgregar
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtpFecha = new DateTimePicker();
            cmbTipo = new ComboBox();
            txtHorasUso = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            Error = new ErrorProvider(components);
            txtWatts = new TextBox();
            btnAceptarAgregar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnGuardarenArchivo = new FontAwesome.Sharp.IconButton();
            btnCargarArchivos = new FontAwesome.Sharp.IconButton();
            dgvAgregar = new DataGridView();
            BtnConfirmarUso = new FontAwesome.Sharp.IconButton();
            lblInfoAgregar = new Label();
            btnNuevoRegistro = new FontAwesome.Sharp.IconButton();
            btnCancelarOperacion = new FontAwesome.Sharp.IconButton();
            btnActualizar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            toolTip = new ToolTip(components);
            btnEliminarAparato = new FontAwesome.Sharp.IconButton();
            btnConfirmarEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)Error).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgregar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarForeColor = SystemColors.Window;
            dtpFecha.CalendarTitleBackColor = SystemColors.Control;
            dtpFecha.CalendarTitleForeColor = SystemColors.ButtonFace;
            dtpFecha.CalendarTrailingForeColor = Color.White;
            dtpFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(193, 512);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 31);
            dtpFecha.TabIndex = 26;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = SystemColors.Control;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cmbTipo.ForeColor = Color.Black;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Hogar", "Oficina", "Industrial" });
            cmbTipo.Location = new Point(193, 587);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(150, 33);
            cmbTipo.TabIndex = 25;
            // 
            // txtHorasUso
            // 
            txtHorasUso.BackColor = SystemColors.Control;
            txtHorasUso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtHorasUso.ForeColor = Color.Black;
            txtHorasUso.Location = new Point(193, 438);
            txtHorasUso.Name = "txtHorasUso";
            txtHorasUso.Size = new Size(150, 31);
            txtHorasUso.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Control;
            txtNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(193, 297);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(594, 48);
            label2.Name = "label2";
            label2.Size = new Size(165, 43);
            label2.TabIndex = 30;
            label2.Text = "Agregar";
            label2.Click += label2_Click;
            // 
            // Error
            // 
            Error.ContainerControl = this;
            // 
            // txtWatts
            // 
            txtWatts.Location = new Point(193, 363);
            txtWatts.Margin = new Padding(4, 5, 4, 5);
            txtWatts.Name = "txtWatts";
            txtWatts.Size = new Size(150, 31);
            txtWatts.TabIndex = 31;
            // 
            // btnAceptarAgregar
            // 
            btnAceptarAgregar.BackColor = Color.FromArgb(0, 175, 77);
            btnAceptarAgregar.FlatAppearance.BorderSize = 0;
            btnAceptarAgregar.FlatStyle = FlatStyle.Flat;
            btnAceptarAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptarAgregar.ForeColor = Color.White;
            btnAceptarAgregar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAceptarAgregar.IconColor = Color.White;
            btnAceptarAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAceptarAgregar.IconSize = 35;
            btnAceptarAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAceptarAgregar.Location = new Point(113, 680);
            btnAceptarAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAceptarAgregar.Name = "btnAceptarAgregar";
            btnAceptarAgregar.Size = new Size(137, 63);
            btnAceptarAgregar.TabIndex = 32;
            btnAceptarAgregar.Text = "Nuevo";
            btnAceptarAgregar.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnAceptarAgregar, "Enter");
            btnAceptarAgregar.UseVisualStyleBackColor = false;
            btnAceptarAgregar.Click += AgregarNuevo;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(51, 100, 205);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 39, 74);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 8F);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 30;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(391, 297);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 63);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnLimpiar, "Ctrl+A");
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += LimpiarControles;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 307);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 34;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 373);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 35;
            label4.Text = "Watts (W)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(49, 448);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 36;
            label9.Text = "Tiempo Uso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(97, 515);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 23);
            label10.TabIndex = 37;
            label10.Text = "Fecha";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(116, 597);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 23);
            label11.TabIndex = 38;
            label11.Text = "Tipo";
            // 
            // btnGuardarenArchivo
            // 
            btnGuardarenArchivo.BackColor = Color.FromArgb(51, 100, 205);
            btnGuardarenArchivo.FlatAppearance.BorderSize = 0;
            btnGuardarenArchivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnGuardarenArchivo.FlatStyle = FlatStyle.Flat;
            btnGuardarenArchivo.Font = new Font("Century Gothic", 8F);
            btnGuardarenArchivo.ForeColor = Color.White;
            btnGuardarenArchivo.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            btnGuardarenArchivo.IconColor = Color.White;
            btnGuardarenArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarenArchivo.IconSize = 30;
            btnGuardarenArchivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarenArchivo.Location = new Point(391, 373);
            btnGuardarenArchivo.Margin = new Padding(4, 5, 4, 5);
            btnGuardarenArchivo.Name = "btnGuardarenArchivo";
            btnGuardarenArchivo.Size = new Size(137, 63);
            btnGuardarenArchivo.TabIndex = 39;
            btnGuardarenArchivo.Text = "Nuevo";
            btnGuardarenArchivo.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnGuardarenArchivo, "Ctrl+C");
            btnGuardarenArchivo.UseVisualStyleBackColor = false;
            btnGuardarenArchivo.Click += GuardarEnArchivos;
            // 
            // btnCargarArchivos
            // 
            btnCargarArchivos.BackColor = Color.FromArgb(51, 100, 205);
            btnCargarArchivos.FlatAppearance.BorderSize = 0;
            btnCargarArchivos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnCargarArchivos.FlatStyle = FlatStyle.Flat;
            btnCargarArchivos.Font = new Font("Century Gothic", 8F);
            btnCargarArchivos.ForeColor = Color.White;
            btnCargarArchivos.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnCargarArchivos.IconColor = Color.White;
            btnCargarArchivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCargarArchivos.IconSize = 30;
            btnCargarArchivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarArchivos.Location = new Point(391, 448);
            btnCargarArchivos.Margin = new Padding(4, 5, 4, 5);
            btnCargarArchivos.Name = "btnCargarArchivos";
            btnCargarArchivos.Size = new Size(137, 63);
            btnCargarArchivos.TabIndex = 40;
            btnCargarArchivos.Text = "Cargar";
            btnCargarArchivos.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnCargarArchivos, "Ctrl+O");
            btnCargarArchivos.UseVisualStyleBackColor = false;
            btnCargarArchivos.Click += CargarDatos;
            // 
            // dgvAgregar
            // 
            dgvAgregar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgregar.BackgroundColor = Color.White;
            dgvAgregar.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAgregar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 100, 205);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 100, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAgregar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgregar.ColumnHeadersHeight = 40;
            dgvAgregar.EnableHeadersVisualStyles = false;
            dgvAgregar.GridColor = Color.White;
            dgvAgregar.Location = new Point(8, 5);
            dgvAgregar.Margin = new Padding(4, 5, 4, 5);
            dgvAgregar.Name = "dgvAgregar";
            dgvAgregar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAgregar.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(153, 180, 230);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvAgregar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvAgregar.Size = new Size(587, 328);
            dgvAgregar.TabIndex = 41;
            dgvAgregar.SelectionChanged += ActivarFunciones;
            // 
            // BtnConfirmarUso
            // 
            BtnConfirmarUso.BackColor = Color.FromArgb(0, 175, 77);
            BtnConfirmarUso.FlatAppearance.BorderSize = 0;
            BtnConfirmarUso.FlatStyle = FlatStyle.Flat;
            BtnConfirmarUso.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConfirmarUso.ForeColor = Color.White;
            BtnConfirmarUso.IconChar = FontAwesome.Sharp.IconChar.Check;
            BtnConfirmarUso.IconColor = Color.White;
            BtnConfirmarUso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnConfirmarUso.IconSize = 35;
            BtnConfirmarUso.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfirmarUso.Location = new Point(113, 680);
            BtnConfirmarUso.Margin = new Padding(4, 5, 4, 5);
            BtnConfirmarUso.Name = "BtnConfirmarUso";
            BtnConfirmarUso.Size = new Size(137, 63);
            BtnConfirmarUso.TabIndex = 43;
            BtnConfirmarUso.Text = "Aceptar";
            BtnConfirmarUso.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(BtnConfirmarUso, "Enter");
            BtnConfirmarUso.UseVisualStyleBackColor = false;
            BtnConfirmarUso.Click += ConfirmarRegistroNuevo;
            // 
            // lblInfoAgregar
            // 
            lblInfoAgregar.AutoSize = true;
            lblInfoAgregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfoAgregar.ForeColor = Color.White;
            lblInfoAgregar.Location = new Point(180, 197);
            lblInfoAgregar.Margin = new Padding(4, 0, 4, 0);
            lblInfoAgregar.Name = "lblInfoAgregar";
            lblInfoAgregar.Size = new Size(186, 27);
            lblInfoAgregar.TabIndex = 44;
            lblInfoAgregar.Text = "Agregar Nuevo";
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoRegistro.BackColor = Color.FromArgb(51, 100, 205);
            btnNuevoRegistro.FlatAppearance.BorderSize = 0;
            btnNuevoRegistro.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnNuevoRegistro.FlatStyle = FlatStyle.Flat;
            btnNuevoRegistro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoRegistro.ForeColor = Color.White;
            btnNuevoRegistro.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            btnNuevoRegistro.IconColor = Color.White;
            btnNuevoRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoRegistro.IconSize = 30;
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.Location = new Point(1007, 210);
            btnNuevoRegistro.Margin = new Padding(4, 5, 4, 5);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(214, 63);
            btnNuevoRegistro.TabIndex = 45;
            btnNuevoRegistro.Text = "Nuevo Registro";
            btnNuevoRegistro.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnNuevoRegistro, "Ctrl+N");
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            btnNuevoRegistro.Click += AgregarNuevoRegistro;
            // 
            // btnCancelarOperacion
            // 
            btnCancelarOperacion.BackColor = Color.FromArgb(51, 100, 205);
            btnCancelarOperacion.FlatAppearance.BorderSize = 0;
            btnCancelarOperacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 39, 74);
            btnCancelarOperacion.FlatStyle = FlatStyle.Flat;
            btnCancelarOperacion.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarOperacion.ForeColor = Color.White;
            btnCancelarOperacion.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCancelarOperacion.IconColor = Color.White;
            btnCancelarOperacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarOperacion.IconSize = 35;
            btnCancelarOperacion.Location = new Point(289, 680);
            btnCancelarOperacion.Margin = new Padding(4, 5, 4, 5);
            btnCancelarOperacion.Name = "btnCancelarOperacion";
            btnCancelarOperacion.Size = new Size(96, 63);
            btnCancelarOperacion.TabIndex = 46;
            btnCancelarOperacion.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnCancelarOperacion, "Esc");
            btnCancelarOperacion.UseVisualStyleBackColor = false;
            btnCancelarOperacion.Click += CancelarNuevoRegistro;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(51, 100, 205);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 8F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            btnActualizar.IconColor = Color.White;
            btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizar.IconSize = 30;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(391, 521);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(137, 63);
            btnActualizar.TabIndex = 47;
            btnActualizar.Text = "Guardar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnActualizar, "Ctrl+S");
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(dgvAgregar);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(634, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 341);
            panel1.TabIndex = 48;
            // 
            // btnEliminarAparato
            // 
            btnEliminarAparato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarAparato.BackColor = Color.FromArgb(250, 50, 50);
            btnEliminarAparato.FlatAppearance.BorderSize = 0;
            btnEliminarAparato.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 39, 74);
            btnEliminarAparato.FlatStyle = FlatStyle.Flat;
            btnEliminarAparato.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarAparato.ForeColor = Color.White;
            btnEliminarAparato.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminarAparato.IconColor = Color.White;
            btnEliminarAparato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarAparato.IconSize = 35;
            btnEliminarAparato.Location = new Point(922, 210);
            btnEliminarAparato.Margin = new Padding(4, 5, 4, 5);
            btnEliminarAparato.Name = "btnEliminarAparato";
            btnEliminarAparato.Size = new Size(64, 63);
            btnEliminarAparato.TabIndex = 49;
            btnEliminarAparato.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnEliminarAparato, "Ctrl+D");
            btnEliminarAparato.UseVisualStyleBackColor = false;
            btnEliminarAparato.Click += btnEliminarAparato_Click;
            // 
            // btnConfirmarEliminar
            // 
            btnConfirmarEliminar.BackColor = Color.FromArgb(250, 50, 50);
            btnConfirmarEliminar.FlatAppearance.BorderSize = 0;
            btnConfirmarEliminar.FlatStyle = FlatStyle.Flat;
            btnConfirmarEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarEliminar.ForeColor = Color.White;
            btnConfirmarEliminar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirmarEliminar.IconColor = Color.White;
            btnConfirmarEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmarEliminar.IconSize = 35;
            btnConfirmarEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarEliminar.Location = new Point(113, 680);
            btnConfirmarEliminar.Margin = new Padding(4, 5, 4, 5);
            btnConfirmarEliminar.Name = "btnConfirmarEliminar";
            btnConfirmarEliminar.Size = new Size(137, 63);
            btnConfirmarEliminar.TabIndex = 50;
            btnConfirmarEliminar.Text = "Eliminar";
            btnConfirmarEliminar.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnConfirmarEliminar, "Enter");
            btnConfirmarEliminar.UseVisualStyleBackColor = false;
            btnConfirmarEliminar.Click += btnConfirmarEliminar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 49, 77);
            ClientSize = new Size(1286, 833);
            Controls.Add(btnConfirmarEliminar);
            Controls.Add(btnEliminarAparato);
            Controls.Add(panel1);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelarOperacion);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(lblInfoAgregar);
            Controls.Add(BtnConfirmarUso);
            Controls.Add(btnCargarArchivos);
            Controls.Add(btnGuardarenArchivo);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptarAgregar);
            Controls.Add(txtWatts);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(txtHorasUso);
            Controls.Add(dtpFecha);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregar";
            Text = "FormAgregar";
            Load += FormAgregar_Load;
            KeyDown += Eventos_Atajos;
            ((System.ComponentModel.ISupportInitialize)Error).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgregar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpFecha;
        private ComboBox cmbTipo;
        private TextBox txtHorasUso;
        private TextBox txtNombre;
        private Label label2;
        private ErrorProvider Error;
        private TextBox txtWatts;
        private FontAwesome.Sharp.IconButton btnAceptarAgregar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGuardarenArchivo;
        private FontAwesome.Sharp.IconButton btnCargarArchivos;
        private DataGridView dgvAgregar;
        private FontAwesome.Sharp.IconButton BtnConfirmarUso;
        private Label lblInfoAgregar;
        private FontAwesome.Sharp.IconButton btnNuevoRegistro;
        private FontAwesome.Sharp.IconButton btnCancelarOperacion;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private Panel panel1;
        private ToolTip toolTip;
        private FontAwesome.Sharp.IconButton btnEliminarAparato;
        private FontAwesome.Sharp.IconButton btnConfirmarEliminar;
    }
}