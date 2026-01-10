using System.Collections.Generic;
using System; 

namespace ProyectoTM;

public partial class ListadoRutaPage : ContentPage
{

	private List<Ruta> rutas; 

	public ListadoRutaPage()
	{
		InitializeComponent();

		rutas = DatosMock.Rutas; 

		listaRutas.ItemsSource = rutas; 
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