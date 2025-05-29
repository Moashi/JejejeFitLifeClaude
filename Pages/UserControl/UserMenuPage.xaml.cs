namespace FrontFitLife.Pages.UserControl;

public partial class UserMenuPage : ContentPage
{
    public UserMenuPage()
    {
        InitializeComponent();
    }

    private void OnRutinaClicked(object sender, EventArgs e)
    {
        ResetMenuSelection();
        RutinaOption.BackgroundColor = Color.FromArgb("#3730A3");

        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Mi Rutina",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Aquí verás tu rutina de ejercicios personalizada",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private void OnAsistenciaClicked(object sender, EventArgs e)
    {
        ResetMenuSelection();
        AsistenciaOption.BackgroundColor = Color.FromArgb("#3730A3");

        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Asistencia",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Registra tu asistencia a entrenamientos",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private void OnProgresoClicked(object sender, EventArgs e)
    {
        ResetMenuSelection();
        ProgresoOption.BackgroundColor = Color.FromArgb("#3730A3");

        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Mi Progreso",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Visualiza tu progreso y estadísticas",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private void OnPerfilClicked(object sender, EventArgs e)
    {
        ResetMenuSelection();
        PerfilOption.BackgroundColor = Color.FromArgb("#3730A3");

        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Mi Perfil",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Gestiona tu información personal",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private void OnReportesClicked(object sender, EventArgs e)
    {
        ResetMenuSelection();
        ReportesOption.BackgroundColor = Color.FromArgb("#3730A3");

        ContenidoPrincipal.Children.Clear();
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Mis Reportes",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#1F2937")
        });
        ContenidoPrincipal.Children.Add(new Label
        {
            Text = "Consulta tus reportes personales",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7280"),
            Margin = new Thickness(0, 10, 0, 0)
        });
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        bool confirmar = await DisplayAlert("Cerrar Sesión", "¿Estás seguro que deseas cerrar sesión?", "Sí", "No");

        if (confirmar)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }

    private void ResetMenuSelection()
    {
        RutinaOption.BackgroundColor = Colors.Transparent;
        AsistenciaOption.BackgroundColor = Colors.Transparent;
        ProgresoOption.BackgroundColor = Colors.Transparent;
        PerfilOption.BackgroundColor = Colors.Transparent;
        ReportesOption.BackgroundColor = Colors.Transparent;
    }
}