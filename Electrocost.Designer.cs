namespace Electrocost3
{
    partial class Electrocost
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electrocost));
            btnsidebar = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            SideBarTransition = new System.Windows.Forms.Timer(components);
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pninicio = new Panel();
            btninicio = new Button();
            pnagregar = new Panel();
            btnagregar = new Button();
            pnhistorial = new Panel();
            btnhistorial = new Button();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            mainpanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)btnsidebar).BeginInit();
            panel2.SuspendLayout();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pninicio.SuspendLayout();
            pnagregar.SuspendLayout();
            pnhistorial.SuspendLayout();
            SuspendLayout();
            // 
            // btnsidebar
            // 
            btnsidebar.Image = (Image)resources.GetObject("btnsidebar.Image");
            btnsidebar.Location = new Point(0, 0);
            btnsidebar.Name = "btnsidebar";
            btnsidebar.Size = new Size(66, 39);
            btnsidebar.SizeMode = PictureBoxSizeMode.Zoom;
            btnsidebar.TabIndex = 0;
            btnsidebar.TabStop = false;
            btnsidebar.Click += btnsidebar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 100, 205);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnsidebar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1549, 39);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(72, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 1;
            label1.Text = "Electrocost";
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += SideBarTransition_Tick;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(26, 32, 40);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(pninicio);
            sidebar.Controls.Add(pnagregar);
            sidebar.Controls.Add(pnhistorial);
            sidebar.Controls.Add(iconButton3);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 39);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(251, 827);
            sidebar.TabIndex = 3;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 128);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pninicio
            // 
            pninicio.Controls.Add(btninicio);
            pninicio.Location = new Point(3, 137);
            pninicio.Name = "pninicio";
            pninicio.Size = new Size(249, 127);
            pninicio.TabIndex = 0;
            // 
            // btninicio
            // 
            btninicio.BackColor = Color.FromArgb(26, 32, 40);
            btninicio.Cursor = Cursors.Hand;
            btninicio.FlatAppearance.BorderSize = 0;
            btninicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btninicio.FlatStyle = FlatStyle.Flat;
            btninicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninicio.ForeColor = SystemColors.Window;
            btninicio.Image = Properties.Resources.icons8_home_32__1_;
            btninicio.ImageAlign = ContentAlignment.MiddleLeft;
            btninicio.Location = new Point(3, 3);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(239, 113);
            btninicio.TabIndex = 1;
            btninicio.Text = "Inicio";
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += btninicio_Click_1;
            btninicio.MouseLeave += btniniciosalida_changedcolor;
            btninicio.MouseHover += btninicioentrada_changedcolor;
            // 
            // pnagregar
            // 
            pnagregar.Controls.Add(btnagregar);
            pnagregar.Location = new Point(3, 270);
            pnagregar.Name = "pnagregar";
            pnagregar.Size = new Size(249, 127);
            pnagregar.TabIndex = 1;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(26, 32, 40);
            btnagregar.Cursor = Cursors.Hand;
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnagregar.ForeColor = SystemColors.Window;
            btnagregar.Image = Properties.Resources.icons8_plus_math_32;
            btnagregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnagregar.Location = new Point(3, 3);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(239, 113);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            btnagregar.MouseLeave += btnagregar2_colorchanged;
            btnagregar.MouseHover += btnagregar1_colorchanged;
            // 
            // pnhistorial
            // 
            pnhistorial.Controls.Add(btnhistorial);
            pnhistorial.Location = new Point(3, 403);
            pnhistorial.Name = "pnhistorial";
            pnhistorial.Size = new Size(246, 135);
            pnhistorial.TabIndex = 1;
            // 
            // btnhistorial
            // 
            btnhistorial.BackColor = Color.FromArgb(26, 32, 40);
            btnhistorial.Cursor = Cursors.Hand;
            btnhistorial.FlatAppearance.BorderSize = 0;
            btnhistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 151, 66);
            btnhistorial.FlatStyle = FlatStyle.Flat;
            btnhistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnhistorial.ForeColor = SystemColors.Window;
            btnhistorial.Image = Properties.Resources.icons8_apps_tab_32__1_;
            btnhistorial.ImageAlign = ContentAlignment.MiddleLeft;
            btnhistorial.Location = new Point(3, 3);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.Size = new Size(234, 122);
            btnhistorial.TabIndex = 3;
            btnhistorial.Text = "Historial";
            btnhistorial.UseVisualStyleBackColor = false;
            btnhistorial.Click += btnhistorial_Click;
            btnhistorial.MouseLeave += btnhistorial2_colorchanged;
            btnhistorial.MouseHover += btnhistorial1_colorchanged;
            // 
            // iconButton3
            // 
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 39, 74);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(4, 546);
            iconButton3.Margin = new Padding(4, 5, 4, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(244, 113);
            iconButton3.TabIndex = 9;
            iconButton3.Text = "Salir";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += CerrarAplicacion;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.FromArgb(49, 62, 82);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(251, 39);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1298, 827);
            mainpanel.TabIndex = 4;
            // 
            // Electrocost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 866);
            Controls.Add(mainpanel);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Electrocost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Electrocost_Load;
            ((System.ComponentModel.ISupportInitialize)btnsidebar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pninicio.ResumeLayout(false);
            pnagregar.ResumeLayout(false);
            pnhistorial.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnsidebar;
        private Panel panel2;
        private System.Windows.Forms.Timer SideBarTransition;
        private FlowLayoutPanel sidebar;
        private Panel pninicio;
        private Button btninicio;
        private Panel pnhistorial;
        private Button btnhistorial;
        private Panel pnagregar;
        private Button btnagregar;
        private Panel mainpanel;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}
