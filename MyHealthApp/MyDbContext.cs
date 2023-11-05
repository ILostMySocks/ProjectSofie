using EFDal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDal
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
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=HealthApp;Integrated Security=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
