namespace ProyectoTM;

public partial class DetalleRutaPage : ContentPage
{
	public DetalleRutaPage(Ruta ruta)
	{
		InitializeComponent();

		identificadorRu.Text = ruta.Identificador; 
		nombreRu.Text = ruta.Nombre; 
		dificultadRu.Text = ruta.Dificultad; 
		distanciarRu.Text = ruta.DistanciaKm.ToString(); 
		desnivelRu.Text = ruta.DesnivelPositivo.ToString(); 
		provinciaRu.Text = ruta.Provincia; 
		circularRu.Text = ruta.Circular ? "si" : "no"; 
		fechaapRu.Text = ruta.FechaApertura.ToString();  


		if(ruta.Etiquetas != null)
		{
			etiquetaRu.Text = "" ;
			foreach(string etiqueta in ruta.Etiquetas)
			{
				etiquetaRu.Text += etiqueta +" "; 
			}
		}
	}
}