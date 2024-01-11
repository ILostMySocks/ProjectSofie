using BLMyHealthApp.Managers;
using BLMyHealthApp.Managers.Interfaces;
using EFDALMyHealthApp;
using MyHealthApp;
using MyHealthApp.Entities;
using MyHealthApp.Repositories;
using MyHealthApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BLTests
{
    [TestClass]
    public class PersonManagerIntegrationTests
    {
        private PersonManager _personManager;

        [TestInitialize]
        public void TestInit()
        {

            var services = new ServiceCollection();

            services.AddDbContext<MyHealthAppContext>(
                opt => opt.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  , ServiceLifetime.Transient);
            services.AddTransient<PersonManager>();
            services.AddTransient<IPersonRepository, PersonRepository>();

            var serviceProvider = services.BuildServiceProvider();
            var context = serviceProvider.GetService<MyHealthAppContext>();


            // Insert seed data into the database using one instance of the context
            AddTestData(context);

            _personManager = serviceProvider.GetService<PersonManager>();
        }

        private void AddTestData(MyHealthAppContext context)
        {
            var workout1 = new Workout()
            {
                Id = 1,
                WorkoutName = "Aerobics",
                CaloriesBurnt = 300
            };

            var food1 = new Food()
            {
                Id = 1,
                FoodName = "Macaroni",
                CalorieCount = 610
            };
            
            var day1 = new Day()
            {
                Id = 1,
                Today = DateTime.Today,
                Foods = new List<Food>() {food1},
                Workouts = new List<Workout>() { workout1}
            };
            
            var calendar1 = new Calendar()
            {
                Id = 1,
                Days = new List<Day>() { day1 },
            };

            var p1 = new Person()
            {
                Id = 1,
                LastName = "Sofie",
                FirstName = "Strumane",
                Calendar = calendar1,
            };

            context.Add(p1);
            context.SaveChanges();
        }


        [TestMethod]
        public void IntegrationTest()
        {
            var test = _personManager.GetAll();
        }
    }
}
