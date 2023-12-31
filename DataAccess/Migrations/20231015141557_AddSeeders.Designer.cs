﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CarsApiDbContext))]
    [Migration("20231015141557_AddSeeders")]
    partial class AddSeeders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Data.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Model = "Camry",
                            Producer = "Toyota",
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Model = "F-150",
                            Producer = "Ford",
                            Year = 2021
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Model = "Malibu",
                            Producer = "Chevrolet",
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Model = "Civic",
                            Producer = "Honda",
                            Year = 2022
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Model = "X5",
                            Producer = "BMW",
                            Year = 2022
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Model = "A4",
                            Producer = "Audi",
                            Year = 2023
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            Model = "E-Class",
                            Producer = "Mercedes-Benz",
                            Year = 2021
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Model = "Altima",
                            Producer = "Nissan",
                            Year = 2022
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 10,
                            Model = "Model 3",
                            Producer = "Tesla",
                            Year = 2023
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Model = "Golf",
                            Producer = "Volkswagen",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A passenger car with a closed body and two rows of seats.",
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A large motor vehicle used for transporting goods.",
                            Name = "Truck"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A rugged automotive vehicle similar to a station wagon but built on a light-truck chassis.",
                            Name = "SUV"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A low-built car designed for performance at high speeds.",
                            Name = "Sports Car"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A small car with a rear door that opens upwards.",
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A car with a roof that can be folded back.",
                            Name = "Convertible"
                        },
                        new
                        {
                            Id = 7,
                            Description = "A small van, typically one used for transporting passengers.",
                            Name = "Minivan"
                        },
                        new
                        {
                            Id = 8,
                            Description = "A two-door car with a fixed roof.",
                            Name = "Coupe"
                        },
                        new
                        {
                            Id = 9,
                            Description = "A vehicle that combines the features of an SUV with those of a passenger car.",
                            Name = "Crossover"
                        },
                        new
                        {
                            Id = 10,
                            Description = "A car that runs on electricity stored in batteries.",
                            Name = "Electric"
                        });
                });

            modelBuilder.Entity("DataAccess.Data.Entities.Car", b =>
                {
                    b.HasOne("DataAccess.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
