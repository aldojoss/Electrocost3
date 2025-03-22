namespace Electrocost3
{
    partial class FormHistorial
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
            label3 = new Label();
            label1 = new Label();
            cboFiltraciones = new ComboBox();
            btnDescargarPDF = new FontAwesome.Sharp.IconButton();
            iconFilter = new FontAwesome.Sharp.IconPictureBox();
            btnVerDetalles = new FontAwesome.Sharp.IconButton();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            lblTextoInfo = new Label();
            dgvHistorial = new DataGridView();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)iconFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(554, 48);
            label3.Name = "label3";
            label3.Size = new Size(174, 47);
            label3.TabIndex = 11;
            label3.Text = "Historial";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(734, 237);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 12;
            label1.Text = "Filtrar por :";
            // 
            // cboFiltraciones
            // 
            cboFiltraciones.Anchor = AnchorStyles.Top;
            cboFiltraciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltraciones.FormattingEnabled = true;
            cboFiltraciones.Location = new Point(849, 234);
            cboFiltraciones.Margin = new Padding(4, 5, 4, 5);
            cboFiltraciones.Name = "cboFiltraciones";
            cboFiltraciones.Size = new Size(156, 33);
            cboFiltraciones.TabIndex = 13;
            cboFiltraciones.SelectedIndexChanged += SeleccionFiltro;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.Anchor = AnchorStyles.Top;
            btnDescargarPDF.BackColor = Color.FromArgb(51, 100, 205);
            btnDescargarPDF.FlatAppearance.BorderSize = 0;
            btnDescargarPDF.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnDescargarPDF.FlatStyle = FlatStyle.Flat;
            btnDescargarPDF.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDescargarPDF.ForeColor = Color.White;
            btnDescargarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnDescargarPDF.IconColor = Color.White;
            btnDescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDescargarPDF.IconSize = 30;
            btnDescargarPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnDescargarPDF.Location = new Point(473, 226);
            btnDescargarPDF.Margin = new Padding(4, 5, 4, 5);
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.Size = new Size(199, 63);
            btnDescargarPDF.TabIndex = 36;
            btnDescargarPDF.Text = "Descargar PDF";
            btnDescargarPDF.TextAlign = ContentAlignment.MiddleRight;
            btnDescargarPDF.UseVisualStyleBackColor = false;
            btnDescargarPDF.Click += btnDescargarPDF_Click;
            // 
            // iconFilter
            // 
            iconFilter.Anchor = AnchorStyles.Top;
            iconFilter.BackColor = Color.FromArgb(33, 49, 77);
            iconFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            iconFilter.IconColor = Color.White;
            iconFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFilter.IconSize = 46;
            iconFilter.Location = new Point(680, 226);
            iconFilter.Margin = new Padding(4, 5, 4, 5);
            iconFilter.Name = "iconFilter";
            iconFilter.Size = new Size(46, 53);
            iconFilter.TabIndex = 37;
            iconFilter.TabStop = false;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.Anchor = AnchorStyles.Top;
            btnVerDetalles.BackColor = Color.FromArgb(51, 100, 205);
            btnVerDetalles.FlatAppearance.BorderSize = 0;
            btnVerDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnVerDetalles.FlatStyle = FlatStyle.Flat;
            btnVerDetalles.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerDetalles.ForeColor = Color.White;
            btnVerDetalles.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnVerDetalles.IconColor = Color.White;
            btnVerDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerDetalles.IconSize = 30;
            btnVerDetalles.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerDetalles.Location = new Point(328, 226);
            btnVerDetalles.Margin = new Padding(4, 5, 4, 5);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(137, 63);
            btnVerDetalles.TabIndex = 38;
            btnVerDetalles.Text = "Detalles";
            btnVerDetalles.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnVerDetalles, "Ctrl+V");
            btnVerDetalles.UseVisualStyleBackColor = false;
            btnVerDetalles.Click += VerDetallesSeleccion;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top;
            btnAnterior.BackColor = Color.FromArgb(51, 100, 205);
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            btnAnterior.IconColor = Color.White;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 30;
            btnAnterior.Location = new Point(236, 226);
            btnAnterior.Margin = new Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(84, 63);
            btnAnterior.TabIndex = 39;
            btnAnterior.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btnAnterior, "Esc");
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += MostrarDatosCompleto;
            // 
            // lblTextoInfo
            // 
            lblTextoInfo.Anchor = AnchorStyles.Top;
            lblTextoInfo.AutoSize = true;
            lblTextoInfo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoInfo.ForeColor = Color.White;
            lblTextoInfo.Location = new Point(473, 306);
            lblTextoInfo.Margin = new Padding(4, 0, 4, 0);
            lblTextoInfo.Name = "lblTextoInfo";
            lblTextoInfo.Size = new Size(354, 27);
            lblTextoInfo.TabIndex = 40;
            lblTextoInfo.Text = "No hay datos que mostrar aún";
            // 
            // dgvHistorial
            // 
            dgvHistorial.Anchor = AnchorStyles.Top;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 100, 205);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 100, 205);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeight = 40;
            dgvHistorial.EnableHeadersVisualStyles = false;
            dgvHistorial.GridColor = Color.White;
            dgvHistorial.Location = new Point(240, 360);
            dgvHistorial.Margin = new Padding(4, 5, 4, 5);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorial.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(153, 180, 230);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvHistorial.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.Size = new Size(774, 393);
            dgvHistorial.TabIndex = 42;
            dgvHistorial.SelectionChanged += ActivarControles;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 49, 77);
            ClientSize = new Size(1286, 833);
            Controls.Add(dgvHistorial);
            Controls.Add(lblTextoInfo);
            Controls.Add(btnAnterior);
            Controls.Add(btnVerDetalles);
            Controls.Add(iconFilter);
            Controls.Add(btnDescargarPDF);
            Controls.Add(cboFiltraciones);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHistorial";
            Text = "FormHistorial";
            Load += FormHistorial_Load;
            KeyDown += Eventos_Atajos;
            ((System.ComponentModel.ISupportInitialize)iconFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private ComboBox cboFiltraciones;
        private FontAwesome.Sharp.IconButton btnDescargarPDF;
        private FontAwesome.Sharp.IconPictureBox iconFilter;
        private FontAwesome.Sharp.IconButton btnVerDetalles;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private Label lblTextoInfo;
        private DataGridView dgvHistorial;
        private ToolTip toolTip;
    }
}