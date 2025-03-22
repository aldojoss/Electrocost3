using System.Text.Json.Serialization;

public class RegistroUso
{
    public DateTime FechaUso { get; set; }
    public int HorasUso { get; set; }
    public double Watts { get; set; }
    public double ConsumoKwh { get; set; }
    public double CostoCordobas { get; set; }

    public RegistroUso(DateTime fecha, int horasuso, double watts)
    {
        this.FechaUso = fecha;
        this.HorasUso = horasuso;
        this.Watts = watts;
        this.ConsumoKwh = (watts / 1000) * horasuso;
        this.CostoCordobas = ConsumoKwh * 6.4; 

    }

    


}

