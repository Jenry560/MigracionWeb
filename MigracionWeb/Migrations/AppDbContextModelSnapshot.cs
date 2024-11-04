﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigracionWeb.Data;

#nullable disable

namespace MigracionWeb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("MigracionWeb.Models.Detencion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaDetencion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroPasaporte")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Detenciones");
                });
#pragma warning restore 612, 618
        }
    }
}
