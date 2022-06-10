using Microsoft.AspNetCore.Components.WebView.Maui;
using BkbAppBlazorMaui.Data;
using EntityFrameworkRepository;
using Microsoft.EntityFrameworkCore;
using BkbAppWorkflow;

namespace BkbAppBlazorMaui;

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
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddDbContext<AppDbContext>(ob => ob.UseSqlServer("BkbApp"));

		builder.Services.RegisterEntityFrameworkRepositoryServices();
		builder.Services.RegisterDataMapperServices();
		builder.Services.RegisterWorkflowServices();
		builder.Services.RegisterLogicMapperServices();

        return builder.Build();
	}
}
