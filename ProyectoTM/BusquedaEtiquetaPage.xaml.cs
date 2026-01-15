namespace ProyectoTM;
public partial class BusquedaEtiquetaPage : ContentPage
{
    public BusquedaEtiquetaPage() { InitializeComponent(); }
    private void OnFiltrarClicked(object sender, EventArgs e)
    {
        string tag = EntradaTag.Text?.ToLower() ?? "";
        var resultado = DatosMock.Rutas.Where(r => r.Etiquetas != null && r.Etiquetas.Any(t => t.ToLower().Contains(tag))).ToList();
        ListaTags.ItemsSource = resultado;
    }
}