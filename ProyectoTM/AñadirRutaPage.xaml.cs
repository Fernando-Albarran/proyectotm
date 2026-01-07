namespace ProyectoTM;

public partial class AñadirRutaPage : ContentPage
{
	public AñadirRutaPage()
	{
		InitializeComponent();
	}

	private async void GuardarRuta (object sender, EventArgs e)
	{
		if(Datos.Rutas.Any(r=> r.Identificador == identificadorR.Text))
		{
			await DisplayAlert ("Error", "El identificador ya existe", "OK"); 
			return; 
		}

		Ruta r = new Ruta
		{
			Identificador = identificadorR.Text,
			Nombre = nombreR.Text,
			Dificultad = dificultadR.SelectedItem.ToString(),
			Provincia = provinciaR.Text,
			Circular = circularR.IsToggled,
			FechaApertura = fechaPicker.Date
		}; 

		Datos.Rutas.Add(r);
		await DisplayAlert("OK", "Ruta añadida", "OK"); 
	}
}