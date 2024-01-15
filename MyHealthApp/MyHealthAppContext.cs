using MyHealthApp.Entities;
using Microsoft.EntityFrameworkCore;
using MyHealthApp;
using MyHealthApp.Migrations;

namespace EFDALMyHealthApp
{
    public class MyHealthAppContext : DbContext
    {
        public MyHealthAppContext() : base() //***
        {

        }
        public MyHealthAppContext(DbContextOptions options) : base(options) //***
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Workout> Workouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=HealthApp;" +
                "Integrated Security=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.PersonConfig();
            modelBuilder.DayConfig();
            modelBuilder.WorkoutConfig();
            modelBuilder.FoodConfig();

        }
    }
}
