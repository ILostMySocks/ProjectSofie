﻿// <auto-generated />
using System;
using EFDal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDal.Migrations
{
    [DbContext(typeof(MyHealthAppContext))]
    [Migration("20231105141615_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDal.Entities.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Today")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("MyHealthCalendars");
                });

            modelBuilder.Entity("EFDal.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<int?>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("MyFoods");
                });

            modelBuilder.Entity("EFDal.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderIdentity")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MyHealthyPeople");
                });

            modelBuilder.Entity("EFDal.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CaloriesBurnt")
                        .HasColumnType("int");

                    b.Property<int?>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("WorkoutName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("MyWorkouts");
                });

            modelBuilder.Entity("EFDal.Entities.Day", b =>
                {
                    b.HasOne("EFDal.Entities.Person", null)
                        .WithMany("HealthCalendar")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("EFDal.Entities.Food", b =>
                {
                    b.HasOne("EFDal.Entities.Day", null)
                        .WithMany("MyFoodToday")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("EFDal.Entities.Workout", b =>
                {
                    b.HasOne("EFDal.Entities.Day", null)
                        .WithMany("MyWorkoutsToday")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("EFDal.Entities.Day", b =>
                {
                    b.Navigation("MyFoodToday");

                    b.Navigation("MyWorkoutsToday");
                });

            modelBuilder.Entity("EFDal.Entities.Person", b =>
                {
                    b.Navigation("HealthCalendar");
                });
#pragma warning restore 612, 618
        }
    }
}
