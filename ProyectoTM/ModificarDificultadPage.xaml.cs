namespace ProyectoTM;
public partial class ModificarDificultadPage : ContentPage
{
    public ModificarDificultadPage() { InitializeComponent(); }
    private void OnActualizarClicked(object sender, EventArgs e)
    {
        var ruta = DatosMock.Rutas.FirstOrDefault(r => r.Nombre == EntradaId.Text);
        if (ruta != null) {
            ruta.Dificultad = EntradaDif.Text;
            DisplayAlert("Éxito", "Dificultad actualizada", "OK");
        } else DisplayAlert("Error", "Ruta no encontrada", "OK");
    }
}