using CustomerConnectionsApp.EntityFramework;
using CustomerConnectionsApp.WPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerConnectionsApp.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// Set properties on main window
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            Window window = new MainWindow();
            window.DataContext = new MainViewModel();
            window.Show();

            base.OnStartup(e);
        }

        //public IServiceProvider ServiceProvider { get; private set; }

        //public IConfiguration Configuration { get; private set; }
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    var builder = new ConfigurationBuilder()
        //       .SetBasePath(Directory.GetCurrentDirectory())
        //       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        //    Configuration = builder.Build();

        //    // Create a service collection and configure the dependencies
        //    var serviceCollection = new ServiceCollection();
        //    ConfigureServices(serviceCollection);

        //    // Builds IServiceProvider and sets the static reference to it
        //    ServiceProvider = serviceCollection.BuildServiceProvider();

        //    var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
        //    mainWindow.Show();
        //}

        //private void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<DataContext>
        //       (options => options.UseSqlServer(
        //                   Configuration.GetConnectionString("SqlConnection")));

        //    services.AddTransient(typeof(MainWindow));
        //}

    }
}
