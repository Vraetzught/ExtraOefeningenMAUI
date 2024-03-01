namespace ExtraOefeningen;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(GetallenDoorgeven2), typeof(GetallenDoorgeven2));
        Routing.RegisterRoute(nameof(PersonenTonen), typeof(PersonenTonen));
    }
}