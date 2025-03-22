namespace Electrocost3
{
    public partial class Electrocost : Form
    {
        FormAgregar? fagregar;
        FormHistorial? fhistorial;
        FormInicio? finicio;
        public Electrocost()
        {
            InitializeComponent();

            fagregar = new FormAgregar();
            finicio = new FormInicio(fagregar.ObtenerListadeAparatos());

            MostrarFormularioEnPanel(finicio, mainpanel); //metodo para mostrar el forminicio en el panel

        }


        //Configuramos el panel para que muestre el formulario
        private void MostrarFormularioEnPanel(Form formulario, Panel panel)
        {

            panel.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            formulario.Show();
        }



        bool sidebarExpand = true;//animacion de trancicion
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 67)
                {
                    sidebarExpand = false;
                    SideBarTransition.Stop();

                    mainpanel.Width = sidebar.Width;
                    pninicio.Width = sidebar.Width;
                    pnagregar.Width = sidebar.Width;
                    pnhistorial.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 251)
                {
                    sidebarExpand = true;
                    SideBarTransition.Stop();
                    mainpanel.Width = sidebar.Width;
                    pninicio.Width = sidebar.Width;
                    pnagregar.Width = sidebar.Width;
                    pnhistorial.Width = sidebar.Width;
                }
            }


        }

        private void btnsidebar_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }



        //Boton inicio
        private void btninicio_Click_1(object sender, EventArgs e)
        {
            List<AparatosElectricos> newlist = fagregar.ObtenerListadeAparatos();

            var forminicio = new FormInicio(newlist);

            MostrarFormularioEnPanel(forminicio, mainpanel);

        }

        //boton historial
        private void btnhistorial_Click(object sender, EventArgs e)
        {
            List<AparatosElectricos> newlist = fagregar.ObtenerListadeAparatos();


            var formHistorial = new FormHistorial(newlist);

            MostrarFormularioEnPanel(formHistorial, mainpanel);
        }

        //boton agregar
        private void btnagregar_Click(object sender, EventArgs e)
        {

            MostrarFormularioEnPanel(fagregar, mainpanel);
        }



        //animaciones al pasar el mouse por encima en botones

        private void btniniciosalida_changedcolor(object sender, EventArgs e)
        {
            btninicio.BackColor = Color.Transparent;
        }

        private void btninicioentrada_changedcolor(object sender, EventArgs e)
        {
            btninicio.BackColor = Color.Green;
        }

        private void btnagregar1_colorchanged(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.Green;
        }

        private void btnagregar2_colorchanged(object sender, EventArgs e)
        {
            btnagregar.BackColor = Color.Transparent;
        }

        private void btnhistorial1_colorchanged(object sender, EventArgs e)
        {
            btnhistorial.BackColor = Color.Green;
        }

        private void btnhistorial2_colorchanged(object sender, EventArgs e)
        {
            btnhistorial.BackColor = Color.Transparent;
        }


        private void CerrarAplicacion(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("¿Esta seguro que desea cerrar el programa?",
                "Confirmar cierre", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirmacion == DialogResult.OK)
            {
                Application.Exit();
            }
        }





        private void lblfecha_Click(object sender, EventArgs e)
        {

        }
        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btninicio_Click(object sender, EventArgs e)
        {
        }

        private void Electrocost_Load(object sender, EventArgs e)
        {

        }
    }
}
