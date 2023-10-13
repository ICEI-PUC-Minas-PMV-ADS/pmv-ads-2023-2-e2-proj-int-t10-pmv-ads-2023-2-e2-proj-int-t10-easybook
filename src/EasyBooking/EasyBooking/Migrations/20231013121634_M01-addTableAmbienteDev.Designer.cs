﻿// <auto-generated />
using EasyBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyBooking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231013121634_M01-addTableAmbienteDev")]
    partial class M01addTableAmbienteDev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EasyBooking.Models.AmbienteDev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<int>("Descricao")
                        .HasColumnType("int");

                    b.Property<int>("Disponibilidade")
                        .HasColumnType("int");

                    b.Property<int>("NomeAmbiente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AmbienteDevs");
                });
#pragma warning restore 612, 618
        }
    }
}
