namespace ProyectoTM;

public partial class ListadoRutaPage : ContentPage
{

    public ListadoRutaPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RecargarLista();
    }

    private void RecargarLista(){
        listaRutas.ItemsSource = null;
        listaRutas.ItemsSource = DatosMock.Rutas;
    }

    private async void detalleRuta(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
        return; 

        Ruta rutaSeleccionada = (Ruta)e.SelectedItem; 

        await Navigation.PushAsync(new DetalleRutaPage(rutaSeleccionada)); 
        listaRutas.SelectedItem = null; 
    }
}