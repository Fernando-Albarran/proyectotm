namespace ProyectoTM;

public partial class EtiquetaRutaPage : ContentPage
{

	private Ruta ruta; 

	public EtiquetaRutaPage() : this(null) { }
		public EtiquetaRutaPage(Ruta rutaElegida)
	{
		InitializeComponent();

		ruta = rutaElegida; 

		if(ruta != null && ruta.Etiquetas==null)
			ruta.Etiquetas = new List<string>();

		RecargarLista(); 
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		RecargarLista();
    }

	private void RecargarLista()
	{
		if (ruta == null) return;

		listaEtiquetas.ItemsSource = null; 
		listaEtiquetas.ItemsSource = ruta.Etiquetas; 

	}

	private async void añadirClick(object sender, EventArgs e)
	{
		string id = identificadorR.Text;
		if (string.IsNullOrEmpty(id))
		{
			return;
		}

		string etiqueta = nuevaetiquetaE.Text;

		if (string.IsNullOrEmpty(etiqueta))
		{
			return; 
		}

		Ruta rutaEncontrada = null;
		foreach (Ruta r in DatosMock.Rutas)
		{
			if (r.Identificador == id)
			{
				rutaEncontrada = r;
				break;
			}
		}

		if (rutaEncontrada == null)
		{
			await DisplayAlert("Error", "No existe ninguna ruta con ese identificador", "OK");
			return;
		}

		if(rutaEncontrada.Etiquetas == null)
		{
			rutaEncontrada.Etiquetas = new List<string>();
		}

		foreach(string et in rutaEncontrada.Etiquetas)
		{
			if (et == etiqueta)
			{
				await DisplayAlert("error", "la etiqueta ya existe", "ok"); 
				return; 
			}
		}
		
		rutaEncontrada.Etiquetas.Add(etiqueta);
		ruta = rutaEncontrada;
		nuevaetiquetaE.Text="";
		RecargarLista();
		await DisplayAlert ("OK", "Etiqueta añadida", "OK");
	}

	private async void listaEtiqeutas(object sender, SelectedItemChangedEventArgs e)
	{
		if (ruta == null) return;

		if(e.SelectedItem == null)
		return; 

		string etiquetaSeleccionada = (string)e.SelectedItem; 

		bool borrar = await DisplayAlert("eliminar etiqueta", "deseas eliminar la etiqueta", "si", "no");

		if (borrar)
		{
			ruta.Etiquetas.Remove(etiquetaSeleccionada); 
			RecargarLista();
		}
		
		listaEtiquetas.SelectedItem = null; 
	}
}