namespace ProyectoTM;
public partial class EstadisticasPage : ContentPage
{
    public EstadisticasPage() { InitializeComponent(); }
    private void CargarDatos(object sender, EventArgs e)
    {
        var lista = DatosMock.Rutas;
        if (lista.Count > 0) {
            LblTotal.Text = $"Total Rutas: {lista.Count}";
            LblMedia.Text = $"Media Km: {lista.Average(r => r.DistanciaKm):F1}";
            var larga = lista.OrderByDescending(r => r.DistanciaKm).FirstOrDefault();
            LblLarga.Text = $"Más larga: {larga?.Nombre}";
        }
    }
}