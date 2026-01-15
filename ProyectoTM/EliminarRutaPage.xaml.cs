namespace ProyectoTM;

public partial class EliminarRutaPage : ContentPage
{
	private readonly Action _recargarLista;

	private List<Ruta> rutas; 

	public EliminarRutaPage() : this(null) { }
	public EliminarRutaPage(Action? recargarLista)
	{
		InitializeComponent();

		_recargarLista = recargarLista;
		rutas = DatosMock.Rutas;
	}

	private async void EliminarRutaClick(object sender, EventArgs e)
	{
		Ruta rutaAEliminar = null; 
		foreach (Ruta r in rutas)
		{
			if (r.Identificador == identificadorR.Text)
			{
				rutaAEliminar = r;
				break;
			}
		}

		if (rutaAEliminar == null)
		{
			await DisplayAlert("Error", "Ruta no encontrada", "OK");
			return;
		}

		rutas.Remove(rutaAEliminar);
		await DisplayAlert("Éxito", "Ruta eliminada correctamente", "OK");
	}
}