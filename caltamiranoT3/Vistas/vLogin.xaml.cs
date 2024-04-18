namespace caltamiranoT3.Vistas;
public partial class vLogin : ContentPage
{
    string[] Usuarios = { "Carlos", "Ana", "Jose" };
    string[] Contrasenas = { "carlos123", "ana123", "jose123" };
    public vLogin()
	{
        InitializeComponent();
	}
    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string cajaUsuario = txtUsuario.Text;
        string cajaContrasena = txtContrasena.Text;

        bool usuarioValido = false;
        bool contrasenaValida = false;

        for (int i = 0; i < Usuarios.Length; i++)
        {
            if (Usuarios[i] == cajaUsuario)
            {
                usuarioValido = true;
                if (Contrasenas[i] == cajaContrasena)
                {
                    contrasenaValida = true;
                    break;
                }
            }
        }
        if (usuarioValido && contrasenaValida)
        {
            Navigation.PushAsync(new vPrincipal(cajaUsuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}
