using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Electrocost3
{
    public partial class FormAgregar : Form
    {
        public List<AparatosElectricos> ListAparatos = new List<AparatosElectricos>();
        private AparatosElectricos Nuevoaparato = null;
        private string NombreArchivo;
        public FormAgregar()
        {
            InitializeComponent();
            InicializarBotones();

        }

        //Deshabilitamos los botones que no se usaran, hasta cuando sean requeridos
        private void InicializarBotones()
        {
            this.KeyPreview = true;
            MetodosDeExtension.InicializarBotones(BtnConfirmarUso, btnConfirmarEliminar, btnNuevoRegistro, btnCancelarOperacion, btnEliminarAparato);

        }
        //metodo para obtener la lista padre, facilita su acceso a los otros form
        public List<AparatosElectricos> ObtenerListadeAparatos()
        {
            return new List<AparatosElectricos>(ListAparatos);
        }
        public double ObtenerConsumoKhw()
        {
            double consumototal = 0;
            foreach (var item in ListAparatos)
            {
                foreach (var item1 in item.Historial)
                {
                    consumototal += item1.ConsumoKwh;
                }
            }

            return consumototal;
        }
        public double ObtenerCostoCordobas()
        {
            double costocordobas = 0;
            foreach (var item in ListAparatos)
            {
                foreach (var item1 in item.Historial)
                {
                    costocordobas += item1.CostoCordobas;
                }
            }

            return costocordobas;
        }
        private void MostrarData(List<AparatosElectricos> _list)
        {
            dgvAgregar.DataSource = null;
            dgvAgregar.DataSource = _list;
        }

        //Metodo que agrega nuevo electrodomestico
        private void AgregarNuevo(object sender, EventArgs e)
        {
            if (txtNombre.ValidarCamposVacios(Error) != true)
            {
                return;
            }
            else if (txtWatts.ValidarCamposNumeros(Error) != true)
            {
                return;
            }
            else if (txtHorasUso.ValidarCamposNumeros(Error) != true)
            {
                return;
            }
            else if (cmbTipo.ValidarSelecComboBox(Error) != true)
            {
                return;
            }
            else if (MetodosDeExtension.ValidacionesRango(txtNombre, txtWatts, txtHorasUso) != true)
            {
                return;
            }
            else
            {
                MetodosDeExtension.AgregarNuevoAparato(ListAparatos, Nuevoaparato, txtNombre, txtWatts, txtHorasUso, dtpFecha, cmbTipo);
                MostrarData(ListAparatos);
                MessageBox.Show("Electrodomestico Agregado!");
            }
        }

        private void LimpiarControles(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtWatts.Clear();
            txtHorasUso.Clear();
            cmbTipo.SelectedIndex = -1;
            Error.SetError(txtNombre, "");
            Error.SetError(txtWatts, "");
            Error.SetError(txtHorasUso, "");
        }

        //Boton Guardar nuevo archivo
        private void GuardarEnArchivos(object sender, EventArgs e)
        {
            GuardarLista(ListAparatos);
        }


        private void GuardarLista(List<AparatosElectricos> _Lista)
        {
           MetodosDeExtension.GuardarNuevoArchivo(_Lista);
        }

        private (List<AparatosElectricos>,string) CargarLista()
        {
           return  MetodosDeExtension.CargarArchivo();
        }

        //Boton Cargar
        private void CargarDatos(object sender, EventArgs e)
        {
            var (listaCargada, nombreArchivo) = CargarLista(); // Desempaquetamos la tupla

            if (listaCargada != null && listaCargada.Count > 0) // Validar si se cargó una lista
            {
                ListAparatos = listaCargada;
                dgvAgregar.DataSource = null;
                dgvAgregar.DataSource = ListAparatos;
                MessageBox.Show("Datos cargados. Revise el historial.");

                // Ahora puedes almacenar el nombre del archivo cargado
                NombreArchivo = nombreArchivo;
            }
            else if (listaCargada == null)
            {
                MessageBox.Show("No se realizaron cambios. Operación cancelada.", "Carga Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListAparatos = new List<AparatosElectricos>();
                dgvAgregar.DataSource = null;
                MessageBox.Show("La lista cargada está vacía. Puede comenzar a agregar nuevos aparatos.", "Lista Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        //Metodo para Agregar nuevo uso
        //Desactiva y cambia el color de algunos botones para las validaciones
        private void NuevoUso()
        {
            
            MetodosDeExtension.NuevoUso(dgvAgregar, txtNombre, txtWatts, cmbTipo, btnAceptarAgregar, btnLimpiar, btnGuardarenArchivo, btnCargarArchivos, btnCancelarOperacion, BtnConfirmarUso, lblInfoAgregar);
        }

        
        private void AgregarNuevoUso(List<AparatosElectricos> _List)
        {
            try
            {
                if (_List != null)
                {
                    int Index = dgvAgregar.CurrentRow.Index;

                    int HorasUso = Convert.ToInt32(txtHorasUso.Text);
                    double Watts = _List[Index].Watts;
                    DateTime Fecha = dtpFecha.Value;

                    AparatosElectricos nuevoAparato = _List[Index];
                    nuevoAparato.AgregarRegistroUso(Fecha, HorasUso, Watts);

                    MessageBox.Show("Nuevo Registro Añadido al Objeto");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio mal");
                return;
            }
        }

        //Activar botones como: Nuevo Registro de uso
        private void ActivarFunciones(object sender, EventArgs e)
        {
            btnNuevoRegistro.Enabled = true;
            btnNuevoRegistro.BackColor = Color.FromArgb(51, 100, 205);
            btnEliminarAparato.Enabled = true;
            btnEliminarAparato.BackColor = Color.FromArgb(250, 50, 50);
        }

        //Boton Agregar nuevo Registro
        private void AgregarNuevoRegistro(object sender, EventArgs e)
        {
            LimpiarControles(sender, e);
            NuevoUso();
        }

        //Bton Confirmar el Nuevo Registro y activamos los botones 
        private void ConfirmarRegistroNuevo(object sender, EventArgs e)
        {
            if (txtHorasUso.ValidarCamposNumeros(Error) != true)
            {
                return;
            }
            else
            {
                AgregarNuevoUso(ListAparatos);
                ActivarBotonesAgregar();
            }
        }

        //Metodo para Activar btonesluego de registrar nuevo uso, tambien se ocupa para eliminar
        private void ActivarBotonesAgregar()
        {
           MetodosDeExtension.ActivarBotonesAgregar(txtNombre, txtWatts, txtHorasUso, cmbTipo, dtpFecha, btnAceptarAgregar,
    btnLimpiar, btnGuardarenArchivo, btnCargarArchivos, btnCancelarOperacion, BtnConfirmarUso, btnConfirmarEliminar, lblInfoAgregar);

        }


        private void CancelarNuevoRegistro(object sender, EventArgs e)
        {
            LimpiarControles(sender, e);
            ActivarBotonesAgregar();
            
        }


        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista(ListAparatos, NombreArchivo);
        }



        //este recibe el nombre del archivo a actualizar, para sobreescribir sobre el mismo
        //el nombre se obtiene cada vez que se carga un archivo
        private void ActualizarLista(List<AparatosElectricos> _Lista, string nombreArchivo)
        {
            try
            {
                // serializa la lista a JSON
                string json = JsonConvert.SerializeObject(_Lista, Formatting.Indented);

                // escribe el contenido json en el archivo especificado
                File.WriteAllText(nombreArchivo, json);

                MessageBox.Show("Cambios guardados correctamente");
            }
            catch (Exception ex)
            {
                //Por si no guardo el archivo antes de actualizarlo
                MessageBox.Show($"Error al actualizar el archivo, Asegurese de haber guardado la lista en un archivo nuevo");
            }
        }

        private void Eventos_Atajos(object sender, KeyEventArgs e)
        {
            MetodosDeExtension.AtajosDeTeclado(sender, e, btnLimpiar, btnActualizar, btnCargarArchivos, btnGuardarenArchivo,
            btnNuevoRegistro, BtnConfirmarUso, btnConfirmarEliminar, btnAceptarAgregar, btnCancelarOperacion, btnEliminarAparato);

        }

        private void EliminarAparato(List<AparatosElectricos>_list)
        {
            MetodosDeExtension.EliminarAparatoE(_list, dgvAgregar);
        }

        private void DesactivarBotonesEliminar()
        {

           MetodosDeExtension.DesactivarBotonesEliminar(txtNombre, txtWatts, txtHorasUso, dtpFecha, cmbTipo,
             btnLimpiar, btnGuardarenArchivo, btnCargarArchivos, btnAceptarAgregar, BtnConfirmarUso,
             btnConfirmarEliminar, btnCancelarOperacion, lblInfoAgregar);
        }

        private void btnEliminarAparato_Click(object sender, EventArgs e)
        {
            DesactivarBotonesEliminar();
        }

        private void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            EliminarAparato(ListAparatos);
            ActivarBotonesAgregar();
        }





        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
