using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.ViewModel;
using Midterm_CarRental.Repositories;
using Midterm_CarRental.Repositories.Impl;
using Midterm_CarRental.View;
using Midterm_CarRental.View.Car;
using Midterm_CarRental.View.Customer;
using Midterm_CarRental.View.Rent;
using Midterm_CarRental.View.Statistical;
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
                    services.AddScoped<IAccountRepository, AccountRepository>();
                    services.AddScoped<fLogin>();

                    // Car
                    services.AddScoped<ICarRepository, CarRepository>();
                    services.AddScoped<fCar>();
                    services.AddScoped<fCarAdd>();
                    services.AddScoped<fRentAdd>();
                    services.AddScoped<fRentManager>();

                    // Customer
                    services.AddScoped<ICustomerRepository, CustomerRepository>();
                    services.AddScoped<fCustomer>();
                    services.AddScoped<fCustomerAdd>();
                    services.AddScoped<fRentAdd>();
                    services.AddScoped<fRentManager>();

                    // Feature
                    services.AddScoped<IFeatureRepository, FeatureRepository>();
                    services.AddScoped<fRentAdd>();

                    // Rent
                    services.AddScoped<IRentRepository, RentRepository>();
                    services.AddScoped<fRentAdd>();
                    services.AddScoped<fRentInfo>();
                    services.AddScoped<fRentManager>();
                    services.AddScoped<fStatistical>();


                    // RentDetail
                    services.AddScoped<IRentDetailRepository, RentDetailRepository>();
                    services.AddScoped<fRentInfo>();

                    // RentMV
                    services.AddScoped<RentMV>();
                    services.AddScoped<fRentInfo>();

                });
        }
    }
}