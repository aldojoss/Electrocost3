namespace Electrocost3
{
    partial class FormInicio
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            horafecha = new System.Windows.Forms.Timer(components);
            lblfecha = new Label();
            lblhora = new Label();
            panel1 = new Panel();
            iconElectromestico = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            label1 = new Label();
            lblnumAparatos = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            iconWatts = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            lblconsumokwh = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            iconCosto = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            lblcostos = new Label();
            dgvListaObjetos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconElectromestico).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconWatts).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaObjetos).BeginInit();
            SuspendLayout();
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // lblfecha
            // 
            lblfecha.Anchor = AnchorStyles.Right;
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfecha.ForeColor = Color.DarkGray;
            lblfecha.Location = new Point(887, 653);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(107, 45);
            lblfecha.TabIndex = 3;
            lblfecha.Text = "label2";
            lblfecha.Click += lblfecha_Click;
            // 
            // lblhora
            // 
            lblhora.Anchor = AnchorStyles.Right;
            lblhora.AutoSize = true;
            lblhora.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhora.ForeColor = Color.FromArgb(74, 144, 226);
            lblhora.Location = new Point(781, 525);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(316, 128);
            lblhora.TabIndex = 2;
            lblhora.Text = "label2";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(iconElectromestico);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lblnumAparatos);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(113, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 239);
            panel1.TabIndex = 6;
            // 
            // iconElectromestico
            // 
            iconElectromestico.BackColor = Color.FromArgb(33, 49, 77);
            iconElectromestico.ForeColor = SystemColors.Window;
            iconElectromestico.IconChar = FontAwesome.Sharp.IconChar.BlenderPhone;
            iconElectromestico.IconColor = SystemColors.Window;
            iconElectromestico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconElectromestico.IconSize = 98;
            iconElectromestico.Location = new Point(37, 62);
            iconElectromestico.Margin = new Padding(4, 5, 4, 5);
            iconElectromestico.Name = "iconElectromestico";
            iconElectromestico.Size = new Size(99, 98);
            iconElectromestico.TabIndex = 9;
            iconElectromestico.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 95, 205);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(169, 52);
            panel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 9;
            label1.Text = "Equipos";
            // 
            // lblnumAparatos
            // 
            lblnumAparatos.AutoSize = true;
            lblnumAparatos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnumAparatos.ForeColor = Color.White;
            lblnumAparatos.Location = new Point(76, 165);
            lblnumAparatos.Name = "lblnumAparatos";
            lblnumAparatos.Size = new Size(72, 23);
            lblnumAparatos.TabIndex = 25;
            lblnumAparatos.Text = "label2";
            lblnumAparatos.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(iconWatts);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblconsumokwh);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(548, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 239);
            panel2.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(51, 95, 205);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(169, 52);
            panel5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 10;
            label4.Text = "Watts";
            // 
            // iconWatts
            // 
            iconWatts.BackColor = Color.FromArgb(33, 49, 77);
            iconWatts.ForeColor = SystemColors.Window;
            iconWatts.IconChar = FontAwesome.Sharp.IconChar.Bolt;
            iconWatts.IconColor = SystemColors.Window;
            iconWatts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconWatts.IconSize = 98;
            iconWatts.Location = new Point(37, 62);
            iconWatts.Margin = new Padding(4, 5, 4, 5);
            iconWatts.Name = "iconWatts";
            iconWatts.Size = new Size(99, 98);
            iconWatts.TabIndex = 26;
            iconWatts.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 168);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 26;
            label2.Text = "KWH";
            label2.Click += label2_Click_1;
            // 
            // lblconsumokwh
            // 
            lblconsumokwh.AutoSize = true;
            lblconsumokwh.Font = new Font("Century Gothic", 9.75F);
            lblconsumokwh.ForeColor = Color.White;
            lblconsumokwh.Location = new Point(70, 168);
            lblconsumokwh.Name = "lblconsumokwh";
            lblconsumokwh.Size = new Size(72, 23);
            lblconsumokwh.TabIndex = 25;
            lblconsumokwh.Text = "label2";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(iconCosto);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblcostos);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(968, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 239);
            panel3.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(51, 95, 205);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(169, 52);
            panel6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 23);
            label5.TabIndex = 11;
            label5.Text = "Costo";
            // 
            // iconCosto
            // 
            iconCosto.BackColor = Color.FromArgb(33, 49, 77);
            iconCosto.ForeColor = SystemColors.Window;
            iconCosto.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            iconCosto.IconColor = SystemColors.Window;
            iconCosto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCosto.IconSize = 98;
            iconCosto.Location = new Point(36, 62);
            iconCosto.Margin = new Padding(4, 5, 4, 5);
            iconCosto.Name = "iconCosto";
            iconCosto.Size = new Size(99, 98);
            iconCosto.TabIndex = 27;
            iconCosto.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 173);
            label3.Name = "label3";
            label3.Size = new Size(37, 23);
            label3.TabIndex = 27;
            label3.Text = "C$";
            // 
            // lblcostos
            // 
            lblcostos.AutoSize = true;
            lblcostos.Font = new Font("Century Gothic", 9.75F);
            lblcostos.ForeColor = Color.White;
            lblcostos.Location = new Point(69, 173);
            lblcostos.Name = "lblcostos";
            lblcostos.Size = new Size(72, 23);
            lblcostos.TabIndex = 25;
            lblcostos.Text = "label2";
            // 
            // dgvListaObjetos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(153, 180, 230);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(153, 180, 230);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvListaObjetos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaObjetos.Anchor = AnchorStyles.Left;
            dgvListaObjetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaObjetos.BackgroundColor = Color.White;
            dgvListaObjetos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListaObjetos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 100, 205);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 100, 205);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaObjetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaObjetos.ColumnHeadersHeight = 40;
            dgvListaObjetos.EnableHeadersVisualStyles = false;
            dgvListaObjetos.GridColor = Color.White;
            dgvListaObjetos.Location = new Point(113, 383);
            dgvListaObjetos.Margin = new Padding(4, 5, 4, 5);
            dgvListaObjetos.Name = "dgvListaObjetos";
            dgvListaObjetos.ReadOnly = true;
            dgvListaObjetos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaObjetos.RowHeadersVisible = false;
            dgvListaObjetos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvListaObjetos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvListaObjetos.Size = new Size(587, 328);
            dgvListaObjetos.TabIndex = 42;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 49, 77);
            ClientSize = new Size(1263, 768);
            Controls.Add(dgvListaObjetos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblfecha);
            Controls.Add(lblhora);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio";
            Text = "FormInicio";
            Load += FormInicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconElectromestico).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconWatts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaObjetos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer horafecha;
        private Label lblfecha;
        private Label lblhora;
        private Panel panel1;
        private Label lblnumAparatos;
        private Panel panel2;
        private Label lblconsumokwh;
        private Panel panel3;
        private Label lblcostos;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconElectromestico;
        private FontAwesome.Sharp.IconPictureBox iconWatts;
        private Panel panel5;
        private Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconCosto;
        private Label label1;
        private Label label4;
        private Label label5;
        private DataGridView dgvListaObjetos;
    }
}