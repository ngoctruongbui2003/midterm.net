using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Midterm_CarRental.Data;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.View;
using Midterm_CarRental.View.Car;
using Midterm_CarRental.View.Customer;
using System.Data;

namespace Midterm_CarRental
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
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var fLoginForm = ServiceProvider.GetRequiredService<fLogin>();

            Application.Run(fLoginForm);

            //var fLoginForm = ServiceProvider.GetRequiredService<fCustomer>();

            //Application.Run(fLoginForm);
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<MyDbContext>();
                    services.AddLogging(config =>
                    {
                        // config.ClearProviders();
                        config.AddDebug();
                        // config.AddConsole();
                        //etc
                    });
                    services.AddTransient<IAccountRepository, AccountRepository>();
                    services.AddTransient<fLogin>();

                    services.AddTransient<ICustomerRepository, CustomerRepository>();
                    services.AddTransient<fCustomer>();

                    services.AddTransient<ICustomerRepository, CustomerRepository>();
                    services.AddTransient<fCustomerAdd>();
                });
        }
    }
}