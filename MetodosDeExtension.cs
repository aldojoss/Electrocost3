using iTextSharp.text.pdf;
using iTextSharp.text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Electrocost3
{
    public static class MetodosDeExtension
    {

        public static bool ValidarCamposVacios(this TextBox Text, ErrorProvider Error)
        {
            try
            {
                if (string.IsNullOrEmpty(Text.Text))
                {
                    Error.SetError(Text, "No puede dejar este campo vacio!");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(Text.Text))
                {
                    Error.SetError(Text, "No puede dejar demasiados espacios vacios");
                    return false;
                }

                Error.SetError(Text, "");
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Asegurse de haber ingresado los datos correctamente!");
                return false;
            }
        }

        public static bool ValidarCamposNumeros(this TextBox Txt, ErrorProvider Error)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt.Text))
                {
                    Error.SetError(Txt, "No puede dejar esta campo vacio!");
                    return false;
                }
                else if (double.TryParse(Txt.Text, out _) != true)
                {
                    Error.SetError(Txt, "Solo es permitido ingresar valores numericos!");
                    return false;
                }
                

                Error.SetError(Txt, "");
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Asegurese de haber ingresado correctamente los datos!");
                return false;
            }
        }

        public static bool ValidarSelecComboBox(this ComboBox comboBox, ErrorProvider Error)
        {
            if(comboBox.SelectedItem == null)
            {
                Error.SetError(comboBox, "Seleccione un tipo");
                return false;
            }
            else if(comboBox.SelectedIndex < 0)
            {
                Error.SetError(comboBox, "Seleccione una opción correcta!");
                return false;
            }

            Error.SetError(comboBox, "");
            return true;
        }
        public static bool ValidacionesRango(TextBox Nombre, TextBox Watts, TextBox HorasUso)
        {

            string nombre = Nombre.Text;
            double watts = Convert.ToDouble(Watts.Text);
            int horasUso = Convert.ToInt32(HorasUso.Text);



            if (nombre.Length >40)
            {
                MessageBox.Show("El nombre debe de tener menosd e 40 caracteres");
                return false;
            }
            if (watts>130000)
            {
                MessageBox.Show("El maximo de watts es de 130000");
                return false;
            }
            if (horasUso>24)
            {
                MessageBox.Show("El tiempo de uso maximo es de 24h ");
                return false;
            }


            return true;
        }

        public static void InicializarBotones(Button btnConfirmarUso, Button btnConfirmarEliminar, Button btnNuevoRegistro, Button btnCancelarOperacion, Button btnEliminarAparato)
        {
            btnConfirmarUso.Visible = false;
            btnConfirmarUso.Enabled = false;

            btnConfirmarEliminar.Visible = false;
            btnConfirmarEliminar.Enabled = false;

            btnNuevoRegistro.Enabled = false;
            btnNuevoRegistro.BackColor = Color.Gray;

            btnCancelarOperacion.Enabled = false;
            btnCancelarOperacion.BackColor = Color.Gray;

            btnEliminarAparato.Enabled = false;
            btnEliminarAparato.BackColor = Color.Gray;
        }

        public static void GuardarNuevoArchivo(List<AparatosElectricos> _Lista)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivos JSON (*.json)|*.json";
            saveFile.Title = "Nueva Lista";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string json = JsonConvert.SerializeObject(_Lista, Formatting.Indented);
                    File.WriteAllText(saveFile.FileName, json);
                    MessageBox.Show("Guardado exitoso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static (List<AparatosElectricos>, string) CargarArchivo()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos JSON (*.json)|*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openFile.FileName);
                    var lista = JsonConvert.DeserializeObject<List<AparatosElectricos>>(json);
                    return (lista, openFile.FileName); // Devolver la lista y el nombre del archivo
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (null, null);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada. No se cargó ningún archivo.", "Carga Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return (null, null);
            }
        }

        public static void AgregarNuevoAparato(List<AparatosElectricos> Lista, AparatosElectricos Nuevo,
        TextBox Nombre, TextBox Watts, TextBox HorasUso, DateTimePicker Fecha, ComboBox Tipo)
        {
            string _Nombre = Nombre.Text;
            double _Watts = Convert.ToDouble(Watts.Text);
            int _HorasUso = Convert.ToInt32(HorasUso.Text);
            DateTime _Fecha = Fecha.Value;
            string _Tipo = Tipo.SelectedItem.ToString();

            // Crear el nuevo aparato según el tipo seleccionado
            if (_Tipo == "Hogar")
            {
                Nuevo = new AparatosHogar(_Nombre, _Watts, _Tipo);
            }
            else if (_Tipo == "Oficina")
            {
                Nuevo = new AparatosOficina(_Nombre, _Watts, _Tipo);
            }
            else if (_Tipo == "Industrial")
            {
                Nuevo = new AparatosIndustriales(_Nombre, _Watts, _Tipo);
            }

            // Agregar el uso al aparato y añadirlo a la lista
            Nuevo.AgregarRegistroUso(_Fecha, _HorasUso, _Watts);
            Lista.Add(Nuevo);
        }


        public static void NuevoUso(DataGridView dgvAgregar, TextBox txtNombre, TextBox txtWatts, ComboBox cmbTipo,
        Button btnAceptarAgregar, Button btnLimpiar, Button btnGuardarenArchivo, Button btnCargarArchivos,
        Button btnCancelarOperacion, Button BtnConfirmarUso, Label lblInfoAgregar)
        {
            if (dgvAgregar.CurrentRow != null)
            {
                int Indice = dgvAgregar.CurrentRow.Index;

                // Deshabilitar campos y botones
                txtNombre.Clear();
                txtWatts.Clear();
                
                txtNombre.Enabled = false;
                txtWatts.Enabled = false;
                cmbTipo.Enabled = false;

                btnAceptarAgregar.Enabled = false;
                btnAceptarAgregar.Visible = false;

                btnLimpiar.Enabled = false;
                btnLimpiar.BackColor = Color.Gray;

                btnGuardarenArchivo.Enabled = false;
                btnGuardarenArchivo.BackColor = Color.Gray;

                btnCargarArchivos.Enabled = false;
                btnCargarArchivos.BackColor = Color.Gray;

                btnCancelarOperacion.Enabled = true;
                btnCancelarOperacion.BackColor = Color.FromArgb(51, 100, 205);

                BtnConfirmarUso.Enabled = true;
                BtnConfirmarUso.Visible = true;
                lblInfoAgregar.Text = "Nuevo Uso";
            }
            else
            {
                // Limpiar y habilitar campos y botones
                txtNombre.Clear();
                txtWatts.Clear();

                txtNombre.Enabled = true;
                txtWatts.Enabled = true;
                cmbTipo.Enabled = true;

                btnAceptarAgregar.Enabled = false;
                btnAceptarAgregar.Visible = true;
                btnLimpiar.Enabled = true;
                btnLimpiar.BackColor = Color.FromArgb(51, 100, 205);
                btnGuardarenArchivo.Enabled = true;
                btnGuardarenArchivo.BackColor = Color.FromArgb(51, 100, 205);
                btnCargarArchivos.Enabled = true;
                btnCargarArchivos.BackColor = Color.FromArgb(51, 100, 205);

                BtnConfirmarUso.Enabled = false;
                BtnConfirmarUso.Visible = false;
                lblInfoAgregar.Text = "Agregar Nuevo";
            }
        }

        public static void ActivarBotonesAgregar(TextBox txtNombre, TextBox txtWatts, TextBox txtHorasUso, ComboBox cmbTipo,
       DateTimePicker dtpFecha, Button btnAceptarAgregar, Button btnLimpiar, Button btnGuardarenArchivo,
       Button btnCargarArchivos, Button btnCancelarOperacion, Button BtnConfirmarUso, Button btnConfirmarEliminar,
       Label lblInfoAgregar)
        {
            // Limpiar los campos de texto
            txtNombre.Clear();
            txtWatts.Clear();
            txtHorasUso.Clear();

            // Habilitar los controles
            txtNombre.Enabled = true;
            txtWatts.Enabled = true;
            cmbTipo.Enabled = true;
            txtHorasUso.Enabled = true;
            dtpFecha.Enabled = true;

            // Activar botones relacionados
            btnAceptarAgregar.Enabled = true;
            btnAceptarAgregar.Visible = true;

            btnLimpiar.Enabled = true;
            btnLimpiar.BackColor = Color.FromArgb(51, 100, 205);

            btnGuardarenArchivo.Enabled = true;
            btnGuardarenArchivo.BackColor = Color.FromArgb(51, 100, 205);

            btnCargarArchivos.Enabled = true;
            btnCargarArchivos.BackColor = Color.FromArgb(51, 100, 205);

            // Desactivar botones que no se deben usar
            btnCancelarOperacion.Enabled = false;
            btnCancelarOperacion.BackColor = Color.Gray;

            BtnConfirmarUso.Enabled = false;
            BtnConfirmarUso.Visible = false;

            btnConfirmarEliminar.Enabled = false;
            btnConfirmarEliminar.Visible = false;

            // Actualizar el texto de la etiqueta
            lblInfoAgregar.Text = "Agregar Nuevo";
        }

        public static void AtajosDeTeclado(object sender, KeyEventArgs e, Button btnLimpiar, Button btnActualizar,
       Button btnCargarArchivos, Button btnGuardarenArchivo, Button btnNuevoRegistro, Button BtnConfirmarUso,
       Button btnConfirmarEliminar, Button btnAceptarAgregar, Button btnCancelarOperacion, Button btnEliminarAparato)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnLimpiar.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnActualizar.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                btnCargarArchivos.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                btnGuardarenArchivo.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnNuevoRegistro.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                // Verificar cuál botón está habilitado y visible
                if (BtnConfirmarUso.Enabled && BtnConfirmarUso.Visible)
                {
                    BtnConfirmarUso.PerformClick();
                }
                else if (btnConfirmarEliminar.Enabled && btnConfirmarEliminar.Visible)
                {
                    btnConfirmarEliminar.PerformClick();
                }
                else if (btnAceptarAgregar.Enabled && btnAceptarAgregar.Visible)
                {
                    btnAceptarAgregar.PerformClick();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCancelarOperacion.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                btnEliminarAparato.PerformClick();
            }
        }

        public static void EliminarAparatoE(List<AparatosElectricos> lista, DataGridView dgvAgregar)
        {
            if (dgvAgregar.Rows.Count > 0 && dgvAgregar.CurrentRow != null)
            {
                int indice = dgvAgregar.CurrentRow.Index;
                lista.RemoveAt(indice);
                dgvAgregar.DataSource = null;
                dgvAgregar.DataSource = lista;
                MessageBox.Show("Aparato Eliminado");
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static void DesactivarBotonesEliminar(TextBox txtNombre, TextBox txtWatts, TextBox txtHorasUso,
        DateTimePicker dtpFecha, ComboBox cmbTipo, Button btnLimpiar, Button btnGuardarenArchivo, Button btnCargarArchivos,
        Button btnAceptarAgregar, Button BtnConfirmarUso, Button btnConfirmarEliminar, Button btnCancelarOperacion, Label lblInfoAgregar)
        {
            txtNombre.Enabled = false;
            txtWatts.Enabled = false;
            txtHorasUso.Enabled = false;
            dtpFecha.Enabled = false;
            cmbTipo.Enabled = false;

            btnLimpiar.Enabled = false;
            btnLimpiar.BackColor = Color.Gray;
            btnGuardarenArchivo.Enabled = false;
            btnGuardarenArchivo.BackColor = Color.Gray;
            btnCargarArchivos.Enabled = false;
            btnCargarArchivos.BackColor = Color.Gray;

            btnAceptarAgregar.Enabled = false;
            btnAceptarAgregar.Visible = false;

            BtnConfirmarUso.Visible = false;
            BtnConfirmarUso.Enabled = false;

            btnConfirmarEliminar.Enabled = true;
            btnConfirmarEliminar.Visible = true;

            btnCancelarOperacion.Enabled = true;
            btnCancelarOperacion.BackColor = Color.FromArgb(51, 100, 205);

            lblInfoAgregar.Text = "Eliminar";
        }

        public static void Filtraciones(ComboBox cboFiltraciones, Label lblTextoInfo, DataGridView dgvHistorial, List<AparatosElectricos> ListAparatos)
        {
            string seleccion = cboFiltraciones.SelectedItem?.ToString() ?? "";

            if (seleccion == "Mayor consumo")
            {
                lblTextoInfo.Text = "Lista por mayor consumo";
                var ElectrodomesticoMayorConsumo = ListAparatos
                    .OrderByDescending(e => e.Watts)
                    .ToList();

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = ElectrodomesticoMayorConsumo;
            }
            else if (seleccion == "Alfabetico")
            {
                lblTextoInfo.Text = "Lista por orden alfabetico";
                var ElectrodomesticosRecientes = ListAparatos.OrderBy(e => e.Nombre).ToList();
                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = ElectrodomesticosRecientes;
            }
            else if (string.IsNullOrEmpty(seleccion) || seleccion == "Predeterminado")
            {
                lblTextoInfo.Text = "Valores Predeterminado";
                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = ListAparatos;
            }
            else if (seleccion == "Tipo")
            {
                lblTextoInfo.Text = "Lista por tipo";
                var ElectrodomesticosTipo = ListAparatos.OrderBy(e => e.Tipo).ToList();
                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = ElectrodomesticosTipo;
            }
        }

        public static void GenerarPdf(List<AparatosElectricos> ListAparatos, string rutaArchivo)
        {
            // Crear un FileStream para guardar el PDF
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Agregar metadatos al documento PDF
                doc.AddAuthor("Moises Serrano");
                doc.AddTitle("Lista de aparatos electricos");

                // Definir la fuente
                iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                doc.Add(new Paragraph("Aparatos Electricos"));
                doc.Add(Chunk.NEWLINE);

                // Crear una tabla para mostrar los datos
                PdfPTable tbl = new PdfPTable(4);
                tbl.WidthPercentage = 100;

                // Títulos de las columnas
                PdfPCell cellNombre = new PdfPCell(new Phrase("Nombre", standarFont)) { BorderWidth = 0.75f };
                PdfPCell cellWatts = new PdfPCell(new Phrase("Watts", standarFont)) { BorderWidth = 0.75f };
                PdfPCell cellTipo = new PdfPCell(new Phrase("Tipo", standarFont)) { BorderWidth = 0.75f };
                PdfPCell cellCosto = new PdfPCell(new Phrase("Costo (en $)", standarFont)) { BorderWidth = 0.75f };

                tbl.AddCell(cellNombre);
                tbl.AddCell(cellWatts);
                tbl.AddCell(cellTipo);
                tbl.AddCell(cellCosto);

                // Agregar los datos de cada aparato eléctrico
                foreach (var aparato in ListAparatos)
                {
                    // Calcular el costo total del aparato
                    decimal precioPorKwh = 6.8m; // Precio por kWh, puedes modificarlo según sea necesario
                    decimal costo = aparato.CalcularCostoUso(precioPorKwh);

                    // Agregar datos de cada aparato a la tabla
                    tbl.AddCell(new PdfPCell(new Phrase(aparato.Nombre, standarFont)));
                    tbl.AddCell(new PdfPCell(new Phrase(aparato.Watts.ToString(), standarFont)));
                    tbl.AddCell(new PdfPCell(new Phrase(aparato.Tipo, standarFont)));
                    tbl.AddCell(new PdfPCell(new Phrase(costo.ToString("C2"), standarFont))); // Formateo de costo en moneda
                }

                // Añadir la tabla al documento PDF
                doc.Add(tbl);

                // Cerrar el documento y el flujo de archivo
                doc.Close();
            }
        }
    }
}
