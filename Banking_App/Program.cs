using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BankingApp.Controllers;
using Banking;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run();
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<IBankController, BankController>();
            services.AddSingleton<App>();
        });
}

