using BLMyHealthApp.Managers.Interfaces;
using BLMyHealthApp.Managers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyHealthApp.Repositories.Interfaces;
using MyHealthApp.Repositories;
using MyHealthApp;
using EFDALMyHealthApp;
using EFDALMyHealthApp.Repositories.Interfaces;
using EFDALMyHealthApp.Repositories;

namespace FEMyHealthApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            var services = new ServiceCollection();
            var connectionString = Properties.Settings.Default.ConnectionString;

            services.AddDbContext<MyHealthAppContext>(opt => opt.UseSqlServer(connectionString)
                                                    , ServiceLifetime.Transient);

            services.AddTransient<IPersonManager, PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<ICalendarManager, CalendarManager>();
            services.AddTransient<ICalendarRepository, CalendarRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddSingleton<HomePageForm>();
            services.AddTransient<PersonalCalendarForm>();
            services.AddTransient<NewPersonForm>();
            services.AddTransient<DayForm>();
            services.AddTransient<AddFoodForm>();
            services.AddTransient<AddWorkoutForm>();


            //using ServiceProvider serviceProvider = services.BuildServiceProvider();    
            ServiceProvider = services.BuildServiceProvider();

            var homePage = ServiceProvider.GetService<HomePageForm>();


            Application.Run(homePage);
        }
    }
}