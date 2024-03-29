﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMVC.Data;

#nullable disable

namespace WebMVC.Persistence.Migrations
{
    [DbContext(typeof(MyDatabase))]
    partial class MyDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("WebMVC.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("41dbeca1-e850-48a6-ab8b-6f9e4516aea5"),
                            CategoryName = "Electronic"
                        },
                        new
                        {
                            CategoryId = new Guid("2d049fbd-d649-464a-acea-2d84419aa7a1"),
                            CategoryName = "Product"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
