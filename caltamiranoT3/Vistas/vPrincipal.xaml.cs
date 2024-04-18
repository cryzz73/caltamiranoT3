namespace caltamiranoT3.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuarioInput)
	{
		InitializeComponent();
        DisplayAlert("Alerta","Bienvenid@ " +usuarioInput, "Cerrar");
        lblUsuario.Text = "Usuari@ conectad@ " + usuarioInput;
    }

  
}