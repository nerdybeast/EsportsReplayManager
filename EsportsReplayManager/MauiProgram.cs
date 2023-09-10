using EsportsReplayManager.Modules.FileSystem;
using EsportsReplayManager.Pages;
using EsportsReplayManager.ViewModels;
using Microsoft.Extensions.Logging;

namespace EsportsReplayManager
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            //Only need a single instance of the splash page
            builder.Services.AddSingleton<SplashPage>();
            builder.Services.AddSingleton<SplashPageVM>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddSingleton<IFileSystemService, FileSystemService>();

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

            return builder.Build();
        }
    }
}