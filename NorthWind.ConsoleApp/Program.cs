using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var Builder = Host.CreateApplicationBuilder();

Builder.Services.AddConsoleWriter();
Builder.Services.AddDebugWriter();
Builder.Services.AddFileWriter();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();

using IHost AppHost = Builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application Started.");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();
Service.Add("Demo", "Azúcar Refinada");  