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
        }
    };
}
