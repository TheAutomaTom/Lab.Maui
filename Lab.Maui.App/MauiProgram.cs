﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace Lab.Maui.App
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();

			builder.UseMauiApp<App>()
				.UseMauiCommunityToolkitMarkup()
				.UseMauiCommunityToolkit()
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
