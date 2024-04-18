namespace caltamiranoT3.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string cajaUsuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta","Bienvenid@ " +cajaUsuario, "Cerrar");
        lblUsuario.Text = "Usuari@ conectad@ " + cajaUsuario;
    }

  
}