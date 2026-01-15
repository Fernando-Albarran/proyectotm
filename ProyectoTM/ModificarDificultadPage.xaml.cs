namespace ProyectoTM;

public partial class ModificarDificultadPage : ContentPage
{
    public ModificarDificultadPage()
    {
        InitializeComponent();
    }

    private void OnActualizarClicked(object sender, EventArgs e)
    {
        string nombre = EntradaId.Text;
        string nuevaDif = PickerDif.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(nombre))
        {
            DisplayAlert("Error", "Debes escribir un nombre de ruta", "OK");
            return;
        }

        if (string.IsNullOrEmpty(nuevaDif))
        {
            DisplayAlert("Error", "Debes seleccionar una dificultad de la lista", "OK");
            return;
        }

        var ruta = DatosMock.Rutas.FirstOrDefault(r => r.Nombre != null && r.Nombre.ToLower() == nombre.ToLower());

        if (ruta != null)
        {
            ruta.Dificultad = nuevaDif;
            DisplayAlert("Éxito", $"La ruta '{ruta.Nombre}' ahora es de dificultad {nuevaDif}", "OK");
        
        }
        else
        {
            DisplayAlert("Error", "No se ha encontrado ninguna ruta con ese nombre", "OK");
        }
    }
}