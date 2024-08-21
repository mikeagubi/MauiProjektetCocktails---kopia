using Microsoft.Extensions.Logging;

namespace MauiProjektetCocktails
{
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
                    fonts.AddFont("Lobster-Regular.ttf", "Lobster");
                    fonts.AddFont("Chewy-Regular.ttf", "Chewy");
                    fonts.AddFont("Baloo-Regular.ttf", "Baloo");
                });
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("Lobster-Regular.ttf", "Lobster");
                fonts.AddFont("Chewy-Regular.ttf", "Chewy");
                fonts.AddFont("Baloo-Regular.ttf", "Baloo");
            });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
