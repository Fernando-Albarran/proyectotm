namespace ProyectoTM;

public partial class AñadirRutaPage : ContentPage
{
	public AñadirRutaPage()
	{
		InitializeComponent();
	}

	private async void GuardarRuta (object sender, EventArgs e)
	{

		bool existe = false ; 
		
		foreach (Ruta ruta in DatosMock.Rutas)
		{
			if (ruta .Identificador == identificadorR.Text)
			{
				existe = true; 
				break; 
			}
		}

		if (existe)
		{
			await DisplayAlert("Error", "el idnetnficador ya existe", "ok");
			return; 

		}

		if (dificultadR.SelectedItem == null)
        {
            await DisplayAlert("Error", "Selecciona una dificultad", "OK");
            return;
        }

		Ruta r = new Ruta
		{
			Identificador = identificadorR.Text,
			Nombre = nombreR.Text,
			Dificultad = dificultadR.SelectedItem.ToString(),
			
			DistanciaKm = Convert.ToDouble(distanciaR.Text),
            DesnivelPositivo = Convert.ToInt32(desnivelR.Text),
			
			Provincia = provinciaR.Text,
			Circular = circularR.IsToggled,
			FechaApertura = fechaPicker.Date
		}; 

		DatosMock.Rutas.Add(r);
		await DisplayAlert("OK", "Ruta añadida", "OK"); 
	}
}