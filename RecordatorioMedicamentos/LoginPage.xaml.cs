using RecordatorioMedicamentos;

namespace RecordatorioMedicamentos;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        
    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string Correo = CorreoUsuario.Text;
        string Contrasena = ContrasenaUsuario.Text;

        // Implementar lógica de autenticación aquí

        var user = await App.Database.GetUserAsync(Correo);
        if (user != null && user.Contrasena == Contrasena)
        {
            //await Shell.Current.GoToAsync("//MainPage");
            //// Navegar a la página principal después del inicio de sesión exitoso
            //((FlyoutPage)Application.Current.MainPage).Detail = new NavigationPage(new MainPage());
            //((FlyoutPage)Application.Current.MainPage).IsPresented = false;
            // Crear una nueva FlyoutPage con el menú visible
            Application.Current.MainPage = new FlyoutPage
            {
                Flyout = new FlyoutMenuPage(),
                Detail = new NavigationPage(new MainPage())
            };
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private void OnRegisterTapped(object sender, EventArgs e)
    {
        // Navegar a la página de registro
        //Shell.Current.GoToAsync("//RegisterPage");
        // Navegar a la páginade registro
        ((FlyoutPage)Application.Current.MainPage).Detail = new NavigationPage(new RegisterPage());
        ((FlyoutPage)Application.Current.MainPage).IsPresented = false;
    }


}