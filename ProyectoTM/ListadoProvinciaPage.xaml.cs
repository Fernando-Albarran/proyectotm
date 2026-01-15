namespace ProyectoTM;
public partial class ListadoProvinciaPage : ContentPage
{
    public ListadoProvinciaPage() { InitializeComponent(); }
    private void OnBuscarClicked(object sender, EventArgs e)
    {
        string p = EntradaProv.Text?.ToLower() ?? "";
        var lista = DatosMock.Rutas.Where(r => r.Provincia?.ToLower() == p).ToList();
        ListaResultados.ItemsSource = lista;
        LabelTotal.Text = $"Total: {lista.Count}";
    }
}