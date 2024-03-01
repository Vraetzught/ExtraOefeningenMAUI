using ExtraOefeningen.Views;
using Microsoft.Extensions.Logging;

namespace ExtraOefeningen;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // ViewModels
        builder.Services.AddSingleton<NaamTonenViewModel>();
        builder.Services.AddSingleton<GetallenRijViewModel>();
        builder.Services.AddSingleton<AfbeeldingViewModel>();
        builder.Services.AddSingleton<FactuurViewModel>();
        builder.Services.AddTransient<GetallenDoorgeven1ViewModel>();
        builder.Services.AddTransient<GetallenDoorgeven2ViewModel>();
        builder.Services.AddTransient<PersoonToevoegenViewModel>();
        builder.Services.AddTransient<PersonenTonenViewModel>();
        builder.Services.AddTransient<GameViewModel>();
        
        // Views
        builder.Services.AddSingleton<NaamTonen>();
        builder.Services.AddSingleton<GetallenRij>();
        builder.Services.AddSingleton<Afbeelding>();
        builder.Services.AddSingleton<Factuur>();
        builder.Services.AddTransient<GetallenDoorgeven1>();
        builder.Services.AddTransient<GetallenDoorgeven2>();
        builder.Services.AddTransient<PersoonToevoegen>();
        builder.Services.AddTransient<PersonenTonen>();
        builder.Services.AddTransient<GamePage>();
        
        // Repo's
        builder.Services.AddSingleton<GameRepository>();

        return builder.Build();
    }
}