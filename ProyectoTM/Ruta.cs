using System;

namespace ProyectoTM;

public class Ruta
{

    public string Identificador {get; set; }
    public string Nombre {get; set; }

    public string Dificultad {get; set; }

    public double DistanciaKm {get; set; }

    public int DesnivelPositivo{get; set; }

    public string Provincia {get; set; }

    public bool Circular{ get; set; }

    public string FechaApertura{ get; set; }

    public List<String> Etiquetas {get; set; } 

    public Ruta()
    {
        Etiquetas = new List<string>();
    }
}
