using System.Collections.Generic;

namespace ProyectoTM;

public static class DatosMock
{
    public static List<Ruta> Rutas { get; } = new List<Ruta>
    {
        new Ruta
        {
            Identificador = "Ruta1",
            Nombre = "bosque",
            Provincia = "salamanca"
        },
        new Ruta
        {
            Identificador = "Ruta2",
            Nombre = "rio",
            Provincia = "valladolid"
        },
        new Ruta { 
            Identificador = "Ruta3",
            Nombre = "Sendero de la Peña", 
            Provincia = "salamanca", 
            Dificultad = "Media", 
            DistanciaKm = 12.5, 
            DesnivelPositivo = 300,
            Etiquetas = new List<string> { "montaña", "vistas" } 
        },
        new Ruta { 
            Identificador = "Ruta4",
            Nombre = "Camino del Valle", 
            Provincia = "leon", 
            Dificultad = "Fácil", 
            DistanciaKm = 8.0, 
            DesnivelPositivo = 100,
            Etiquetas = new List<string> { "rio", "familiar" } 
        }
    };
}
