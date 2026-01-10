namespace ProyectoTM;

public partial class EtiquetaRutaPage : ContentPage
{

	private Ruta ruta; 
		public EtiquetaRutaPage(Ruta rutaElegida)
	{
		InitializeComponent();

		ruta = rutaElegida; 

		if(ruta.Etiquetas==null)
			ruta.Etiquetas = new List<string>();

		RecargarLista(); 
	}

	private void RecargarLista()
	{
		listaEtiquetas.ItemsSource = null; 
		listaEtiquetas.ItemsSource = ruta.Etiquetas; 

	}

	private async void añadirClick(object sender, EventArgs e)
	{
		string etiqueta = nuevaetiquetaE.Text;

		if (string.IsNullOrEmpty(etiqueta))
		{
			return; 
		}

	foreach(string et in ruta.Etiquetas)
		{
			if (et == etiqueta)
			{
				await DisplayAlert("error", "la etiqueta ya existe", "ok"); 
				return; 
			}
		}
		ruta.Etiquetas.Add(etiqueta); 
		nuevaetiquetaE.Text=""; 
		RecargarLista(); 
	}

	private async void listaEtiqeutas(object sender, SelectedItemChangedEventArgs e)
	{
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