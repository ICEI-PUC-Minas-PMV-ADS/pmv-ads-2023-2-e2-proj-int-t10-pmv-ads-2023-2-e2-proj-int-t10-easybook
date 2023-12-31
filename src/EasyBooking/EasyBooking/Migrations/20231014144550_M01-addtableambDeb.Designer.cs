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
    [Migration("20231014144550_M01-addtableambDeb")]
    partial class M01addtableambDeb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
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

                    b.Property<string>("NomeAmbiente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AmbienteDevs");
                });
#pragma warning restore 612, 618
        }
    }
}
