using MyHealthApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyHealthApp
{
    public class MyHealthAppContext : DbContext
    {
        public DbSet<Person> MyHealthyPeople { get; set; }
        public DbSet<Calendar> MyHealthCalendars { get; set; }
        public DbSet<Day> MyDays { get; set; }
        public DbSet<Food> MyFoods { get; set; }
        public DbSet<Workout> MyWorkouts { get; set; }

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
