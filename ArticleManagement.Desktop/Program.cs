using ArticleManagement.Desktop.Controls;
using ArticleManagement.Desktop.Forms;
using ArticleManagement.Desktop.Services;
using ArticleManagement.Desktop.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArticleManagement.Desktop
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.SetCompatibleTextRenderingDefault(false);
			ApplicationConfiguration.Initialize();

			var host = Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) =>
				{
					var config = context.Configuration;

					services.ConfigureHttpClientDefaults(builder =>
					{
						builder.ConfigureHttpClient(client =>
						{
							client.BaseAddress = new Uri(config["Api:BaseUri"]);
							client.DefaultRequestHeaders.Add("Accept", "application/json");
						});
					});

					services.AddScoped<IAuthService, AuthService>();
					services.AddScoped<IUserService, UserService>();
					services.AddSingleton<IUserSession, UserSession>();

					services.AddTransient<MainForm>();
					services.AddTransient<LoginForm>();
					services.AddTransient<LoginControl>();
					services.AddTransient<RegisterControl>();
				})
				.Build();
			
			using var scope = host.Services.CreateScope();
			var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>();

			if (loginForm.ShowDialog() == DialogResult.OK)
			{
				var mainForm = scope.ServiceProvider.GetRequiredService<MainForm>();
				Application.Run(mainForm);
			}
		}
	}
}