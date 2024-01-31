using Calorie_Counter.Properties.ViewModel;
using Microsoft.Extensions.Logging;

// following https://www.youtube.com/playlist?list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY to start this app

namespace Calorie_Counter
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
                });

            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<DetailPage>(); // singleton is created 1 time - transient is created / destroyed every time
            builder.Services.AddTransient<DetailViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
