namespace acentenoTS2.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[] usuarios = { "Carlos", "Ana", "Jose" };
        string[] contraseņas = { "carlos123", "ana123", "jose123" };

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == txtUsuario.Text && contraseņas[i] == txtContrasena.Text)
            {

                Navigation.PushAsync(new Views.SistemaUisrael());
                break;
            }
            else
            {
                DisplayAlert("Alerta", "Contraseņa o usuario incorrects", "ok");
                break;
            }

        }



    }
}