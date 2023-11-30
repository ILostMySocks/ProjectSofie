using MyHealthApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp
{
    //MOET static zijn => je kan de methodes aanroepen zonder te instatieren
    public static class Extensions
    {
        //extension methods moeten ook Static zijn, moeten starten met een "this" als parameter
        public static void PersonConfig(this ModelBuilder mb)
        {
            mb.Entity<Person>()
                .Property(p => p.GenderIdentity)
                .HasConversion<string>()
                .HasMaxLength(11);

            mb.Entity<Person>()
                .Property(p => p.LastName)
                .IsRequired(true)
                .HasMaxLength(250);

            mb.Entity<Person>()
                .Property(p => p.FirstName)
                .IsRequired(true)
                .HasMaxLength(250);

            mb.Entity<Person>()
                .HasOne(p => p.MyHealthCalendar)
                .WithOne(c => c.MyHealthyPerson)
                .HasForeignKey<Calendar>(c => c.MyHealthyPersonId);
        }

        public static void DayConfig(this ModelBuilder mb)
        {
            mb.Entity<Day>()
                .HasOne(d => d.MyHealthCalendar)
                .WithMany(c => c.MyHealthyDays);

            mb.Entity<Day>()
                .HasMany(f => f.MyFoodToday)
                .WithMany(c => c.DaysEaten);
        }

        public static void WorkoutConfig(this ModelBuilder mb)
        {
            mb.Entity<Workout>()
                .Property(p => p.WorkoutName)
                .IsRequired(true)
                .HasMaxLength(300);
        }

        public static void FoodConfig(this ModelBuilder mb)
        {
            mb.Entity<Food>()
                .Property(p => p.FoodName)
                .IsRequired(true)
                .HasMaxLength(300);
        }
    }
}
