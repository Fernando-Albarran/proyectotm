namespace ProyectoTM;

public partial class BuscarRutaPage : ContentPage
{
	public BuscarRutaPage()
	{
		InitializeComponent();
	}

	private async void BuscarRuta (object sender, EventArgs e)
	{
		var ruta = Datos.Rutas.FirstOrDefault(r => r.Identificador == identificadorR.Text); 

		if (ruta == null)
		{
			await DisplayAlert ("Error", "Ruta no encontrada", "OK");
			return; 
		}

		resultadoLabel.Text =  $"Nombre: {ruta.Nombre}\nProvincia: {ruta.Provincia}\nDificultad: {ruta.Dificultad}";
}
	}
}