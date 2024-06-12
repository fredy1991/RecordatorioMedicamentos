

using RecordatorioMedicamentos;
using RecordatorioMedicamentos.Models;

namespace RecordatorioMedicamentos;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Implementar lógica de registro aquí
        string Nombres = NombresUsuario.Text;
        string Correo = CorreoUsuario.Text;
        string Contrasena = ContrasenaUsuario.Text;
        string ConfirmarContrasena = ConfirmarContrasenaUsuario.Text;
        DateTime FechaNacimiento = FechaNacimientoUsuario.Date;

        if (Contrasena != ConfirmarContrasena)
        {
            await DisplayAlert("Error", "Las contraseñas no coinciden", "OK");
            return;
        }

        var user = new User
        {
            NombresUsuario = Nombres,
            CorreoUsuario = Correo,
            Contrasena = Contrasena,
            FechaNacimiento = FechaNacimiento
        };

        await App.Database.SaveUserAsync(user);
        await DisplayAlert("Éxito", "Usuario registrado correctamente", "OK");
        await Shell.Current.GoToAsync("//LoginPage");
    }
}