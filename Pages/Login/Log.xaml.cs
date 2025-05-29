namespace FrontFitLife.Pages.Login;

public partial class Log : ContentPage
{
    private bool _isPasswordVisible = false;

    public Log()
    {
        InitializeComponent();
    }

    private void OnTogglePasswordClicked(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;
        ContrasenaEntry.IsPassword = !_isPasswordVisible;

        // Cambiar el icono del botón
        TogglePasswordButton.Text = _isPasswordVisible ? "🙈" : "👁";
    }

    private async void OnIniciarSesionClicked(object sender, EventArgs e)
    {
        // Limpiar errores previos
        LimpiarErrores();

        // Validar campos
        bool esValido = ValidarCampos();

        if (esValido)
        {
            // Deshabilitar botón durante el proceso
            IniciarSesionButton.IsEnabled = false;
            IniciarSesionButton.Text = "Iniciando...";

            try
            {
                // Simular proceso de login (aquí conectarías con tu backend)
                await SimularLogin();

                // Si el login es exitoso, navegar a la página principal
                await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");

                // Aquí navegarías a tu página principal
                // await Shell.Current.GoToAsync("//MainPage");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error al iniciar sesión: {ex.Message}", "OK");
            }
            finally
            {
                // Rehabilitar botón
                IniciarSesionButton.IsEnabled = true;
                IniciarSesionButton.Text = "Iniciar Sesión";
            }
        }
    }

    private bool ValidarCampos()
    {
        bool esValido = true;

        // Validar usuario
        if (string.IsNullOrWhiteSpace(UsuarioEntry.Text))
        {
            UsuarioErrorLabel.IsVisible = true;
            UsuarioErrorLabel.Text = "El usuario es requerido";
            esValido = false;
        }
        else if (UsuarioEntry.Text.Length < 3)
        {
            UsuarioErrorLabel.IsVisible = true;
            UsuarioErrorLabel.Text = "El usuario debe tener al menos 3 caracteres";
            esValido = false;
        }

        // Validar contraseña
        if (string.IsNullOrWhiteSpace(ContrasenaEntry.Text))
        {
            ContrasenaErrorLabel.IsVisible = true;
            ContrasenaErrorLabel.Text = "La contraseña es requerida";
            esValido = false;
        }
        else if (ContrasenaEntry.Text.Length < 6)
        {
            ContrasenaErrorLabel.IsVisible = true;
            ContrasenaErrorLabel.Text = "La contraseña debe tener al menos 6 caracteres";
            esValido = false;
        }

        return esValido;
    }

    private void LimpiarErrores()
    {
        UsuarioErrorLabel.IsVisible = false;
        ContrasenaErrorLabel.IsVisible = false;
    }

    private async Task SimularLogin()
    {
        // Simular delay de red
        await Task.Delay(2000);

        // Aquí puedes agregar validaciones adicionales
        // Por ejemplo, verificar credenciales hardcodeadas para pruebas
        string usuario = UsuarioEntry.Text?.Trim();
        string contrasena = ContrasenaEntry.Text;

        // Ejemplo de validación simple para pruebas
        if (usuario?.ToLower() == "admin" && contrasena == "123456")
        {
            // Login exitoso
            return;
        }
        else if (usuario?.ToLower() == "test" && contrasena == "test123")
        {
            // Login exitoso
            return;
        }
        else
        {
            // Credenciales incorrectas
            throw new Exception("Usuario o contraseña incorrectos");
        }
    }

    private async void OnOlvidasteContrasenaClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Información", "Funcionalidad de recuperación de contraseña próximamente", "OK");

        // Aquí navegarías a tu página de recuperación de contraseña
        // await Shell.Current.GoToAsync("//RecuperarContrasenaPage");
    }

    private async void OnRegistrarseClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Información", "Funcionalidad de registro próximamente", "OK");

        // Aquí navegarías a tu página de registro
        // await Shell.Current.GoToAsync("//RegistroPage");
    }

    // Método para limpiar campos (útil para testing)
    public void LimpiarCampos()
    {
        UsuarioEntry.Text = string.Empty;
        ContrasenaEntry.Text = string.Empty;
        LimpiarErrores();
    }

    // Evento que se ejecuta cuando la página aparece
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Limpiar campos al aparecer la página
        LimpiarCampos();

        // Enfocar el campo de usuario
        UsuarioEntry.Focus();
    }
}
