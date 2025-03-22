using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrocost3
{
    public partial class FormInicio : Form
    {
    
        public FormInicio(List<AparatosElectricos> lista)
        {
            InitializeComponent();
            MostrarEnData(lista);
            InicializarElementos(lista);
        }

       //timer para mostrar la hora y fech en label
        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();

        }
        //mostramos informacion general de los aparatos electricos
        private void InicializarElementos(List<AparatosElectricos> lista)
        {
            lblnumAparatos.Text = lista.Count.ToString();
            lblconsumokwh.Text = ObtenerConsumoKwh(lista).ToString();
            lblcostos.Text = ObtenerCostoCordobas(lista).ToString();

        }
       
        public void MostrarEnData(List<AparatosElectricos> ListAparatos)
        {

            dgvListaObjetos.DataSource = null;
            dgvListaObjetos.DataSource = ListAparatos;
        }

        
        private double ObtenerConsumoKwh(List<AparatosElectricos> list)
        {
            double consumokwh = 0;
            foreach (var item in list)
            {
                foreach (var item1 in item.Historial)
                {
                    consumokwh += item1.ConsumoKwh;
                }
            }
            return consumokwh;
        }

        private double ObtenerCostoCordobas(List<AparatosElectricos> list)
        {
            double consumototal = 0;
            foreach (var item in list)
            {
                foreach (var item1 in item.Historial)
                {
                    consumototal += item1.CostoCordobas;
                }
            }
            return consumototal;
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void lblfecha_Click(object sender, EventArgs e)
        {

        }


    }
}
