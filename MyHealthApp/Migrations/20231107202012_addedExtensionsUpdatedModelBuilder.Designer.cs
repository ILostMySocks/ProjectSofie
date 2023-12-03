﻿// <auto-generated />
using System;
using MyHealthApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MyHealthApp.Migrations
{
    [DbContext(typeof(MyHealthAppContext))]
    [Migration("20231107202012_addedExtensionsUpdatedModelBuilder")]
    partial class addedExtensionsUpdatedModelBuilder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDal.Entities.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MyHealthyPersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MyHealthCalendars");
                });

            modelBuilder.Entity("EFDal.Entities.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MyHealthCalendarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Today")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MyHealthCalendarId");

                    b.ToTable("MyDays");
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
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

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
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("GenderIdentity")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("MyHealthCalendarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MyHealthCalendarId")
                        .IsUnique();

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
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("MyWorkouts");
                });

            modelBuilder.Entity("EFDal.Entities.Day", b =>
                {
                    b.HasOne("EFDal.Entities.Calendar", "MyHealthCalendar")
                        .WithMany("MyHealthyDays")
                        .HasForeignKey("MyHealthCalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyHealthCalendar");
                });

            modelBuilder.Entity("EFDal.Entities.Food", b =>
                {
                    b.HasOne("EFDal.Entities.Day", null)
                        .WithMany("MyFoodToday")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("EFDal.Entities.Person", b =>
                {
                    b.HasOne("EFDal.Entities.Calendar", "MyHealthCalendar")
                        .WithOne("MyHealthyPerson")
                        .HasForeignKey("EFDal.Entities.Person", "MyHealthCalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyHealthCalendar");
                });

            modelBuilder.Entity("EFDal.Entities.Workout", b =>
                {
                    b.HasOne("EFDal.Entities.Day", null)
                        .WithMany("MyWorkoutsToday")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("EFDal.Entities.Calendar", b =>
                {
                    b.Navigation("MyHealthyDays");

                    b.Navigation("MyHealthyPerson")
                        .IsRequired();
                });

            modelBuilder.Entity("EFDal.Entities.Day", b =>
                {
                    b.Navigation("MyFoodToday");

                    b.Navigation("MyWorkoutsToday");
                });
#pragma warning restore 612, 618
        }
    }
}