using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Electrocost3
{
    public class AparatosElectricos
    {
        public string Nombre { get; set; }
        public double Watts { get; set; }
        public List<RegistroUso> Historial { get; set; } // de estos se encarga la clase registro uso
        public string Tipo { get; set; }

        public AparatosElectricos(string nombre, double watts, string tipo)
        {

            this.Nombre = nombre;
            this.Watts = watts;
            this.Historial = new List<RegistroUso>();
            this.Tipo = tipo;
        }


        public virtual void AgregarRegistroUso(DateTime fecha, int horasUso, double watts)
        {
            var registro = new RegistroUso(fecha, horasUso, watts);
            this.Historial.Add(registro);
        }

        public decimal CalcularCostoUso(decimal precioPorKwh)
        {
            decimal costoTotal = 0;

            // Recorrer cada registro de uso y calcular el costo
            foreach (var registro in Historial)
            {
                // Watts / 1000 para convertir a kWh y luego multiplicar por el precio y horas de uso
                decimal costoPorRegistro = (decimal)(registro.Watts / 1000) * precioPorKwh * registro.HorasUso;
                costoTotal += costoPorRegistro;
            }

            return costoTotal;
        }


    }

}
