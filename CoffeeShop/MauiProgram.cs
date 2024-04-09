using Microsoft.Extensions.Logging;

namespace CoffeeShop;

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
				fonts.AddFont("Montserrat.ttf", "Montserrat");
				fonts.AddFont("fa-regular-400.ttf", "FontA");
				fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
				fonts.AddFont("Rubik-Light.ttf", "RubikLight");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
