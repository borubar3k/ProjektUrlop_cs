﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektUrlop.Data;

#nullable disable

namespace ProjektUrlop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjektUrlop.Models.Logowania", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataLogowania")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_pracownika")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("logowania");
                });

            modelBuilder.Entity("ProjektUrlop.Models.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataZatrudnienia")
                        .HasColumnType("datetime2");

                    b.Property<int>("DniUrlopu")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsArch")
                        .HasColumnType("bit");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("pracownicy");
                });

            modelBuilder.Entity("ProjektUrlop.Models.Urlop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDO")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataOD")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_pracownika")
                        .HasColumnType("int");

                    b.Property<bool>("IsAppr")
                        .HasColumnType("bit");

                    b.Property<int>("LiczbaDni")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("urlopy");
                });
#pragma warning restore 612, 618
        }
    }
}
