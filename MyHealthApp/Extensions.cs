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
    //MOET static zijn => je kan de methodes aanroepen zonder te instantieren
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
                .Property(p => p.Email)
                .IsRequired(true)
                .HasMaxLength(254);

            mb.Entity<Person>()
                .HasOne(p => p.Calendar)
                .WithOne(c => c.Person)
                .HasForeignKey<Calendar>(c => c.PersonId);
        }

        public static void DayConfig(this ModelBuilder mb)
        {
            mb.Entity<Day>()
                .HasOne(d => d.Calendar)
                .WithMany(c => c.Days);

            mb.Entity<Day>()
                .HasMany(f => f.Foods)
                .WithMany(c => c.Days);
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
