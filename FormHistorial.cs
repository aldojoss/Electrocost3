using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Electrocost3
{
    public partial class FormHistorial : Form
    {

        private List<AparatosElectricos> ListAparatos;


        public FormHistorial(List<AparatosElectricos> ListAparatos)
        {
            InitializeComponent();

            MostrarEnData(ListAparatos);
            this.ListAparatos = ListAparatos;
            InicializarElementos();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {

        }
        private void MostrarEnData(List<AparatosElectricos> ListAparatos)
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = ListAparatos;
        }

        private void InicializarElementos()
        {
            lblTextoInfo.Text = "Lista";
            cboFiltraciones.Items.AddRange(["Predeterminado", "Mayor consumo", "Alfabetico", "Tipo"]);

            btnDescargarPDF.Enabled = false;
            btnDescargarPDF.BackColor = Color.Gray;
            btnVerDetalles.Enabled = false;
            btnVerDetalles.BackColor = Color.Gray;
            this.KeyPreview = true;
        }

        private void SeleccionFiltro(object sender, EventArgs e)
        {

            MetodosDeExtension.Filtraciones(cboFiltraciones, lblTextoInfo, dgvHistorial, ListAparatos);

        }

        private void MostrarDetalles()
        {
            try
            {
                if (ListAparatos != null)
                {
                    int Index = dgvHistorial.CurrentRow.Index;

                    dgvHistorial.DataSource = null;
                    dgvHistorial.DataSource = ListAparatos[Index].Historial;
                    lblTextoInfo.Text = $"Detalles {ListAparatos[Index].Nombre}";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio mal!");
                return;
            }
        }

        private void VerDetallesSeleccion(object sender, EventArgs e)
        {
            MostrarDetalles();
        }

        private void ActivarControles(object sender, EventArgs e)
        {
           
            btnVerDetalles.Enabled = true;
            btnVerDetalles.BackColor = Color.FromArgb(51, 100, 205);
            btnDescargarPDF.Enabled = true;
            btnDescargarPDF.BackColor = Color.FromArgb(51, 100, 205);
        }

        private void MostrarDatosCompleto(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = ListAparatos;
            lblTextoInfo.Text = "Lista";
        }

        private void Eventos_Atajos(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                btnVerDetalles.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnAnterior.PerformClick();
            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            // Abre el cuadro de diálogo para guardar el archivo PDF
            using (System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo";

                // Si el usuario selecciona una ruta, se procede con la creación del PDF
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;

                    // Llamar al método estático para generar el PDF
                    MetodosDeExtension.GenerarPdf(ListAparatos, rutaArchivo);

                    MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
