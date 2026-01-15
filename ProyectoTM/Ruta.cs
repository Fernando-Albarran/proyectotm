public class Ruta
{
    // Ponemos = "" al final para que no se queje
    public string Identificador { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Dificultad { get; set; } = "";
    public string Provincia { get; set; } = ""; 

    public double DistanciaKm { get; set; }
    public int DesnivelPositivo { get; set; }
    public bool Circular { get; set; }
    public DateTime FechaApertura { get; set; }
    public List<string> Etiquetas { get; set; } 

    public Ruta()
    {
        Etiquetas = new List<string>();
    }
}