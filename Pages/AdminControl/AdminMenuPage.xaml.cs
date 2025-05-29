namespace FrontFitLife.Pages.AdminControl;

public partial class AdminMenuPage : ContentPage
{
    public AdminMenuPage()
    {
        InitializeComponent();
    }

    private void OnAdminUsuariosClicked(object sender, EventArgs e)
    {
        // Cambiar color de fondo para mostrar selecci�n
        ResetMenuSelection();
        AdminUsuariosOption.BackgroundColor = Color.FromArgb("#3730A3");

        // Actualizar contenido principal
        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Administrar Usuarios",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Aqu� podr�s gestionar todos los usuarios del sistema",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private void OnReportesClicked(object sender, EventArgs e)
    {
        // Cambiar color de fondo para mostrar selecci�n
        ResetMenuSelection();
        ReportesOption.BackgroundColor = Color.FromArgb("#3730A3");

        // Actualizar contenido principal
        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Reportes",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Visualiza estad�sticas y reportes del sistema",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Cerrar Sesi�n", "�Est�s seguro que deseas cerrar sesi�n?", "S�", "No");

        if (confirmar)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }

    private void ResetMenuSelection()
    {
        AdminUsuariosOption.BackgroundColor = Colors.Transparent;
        ReportesOption.BackgroundColor = Colors.Transparent;
    }
}