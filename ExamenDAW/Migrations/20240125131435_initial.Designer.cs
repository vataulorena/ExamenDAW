﻿// <auto-generated />
using System;
using ExamenDAW.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamenDAW.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240125131435_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamenDAW.Models.Comanda.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UtilizatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UtilizatorId");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("ExamenDAW.Models.ComandaProdus.ComandaProdus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ComandaId");

                    b.HasIndex("ProdusId");

                    b.ToTable("ComandaProdus");
                });

            modelBuilder.Entity("ExamenDAW.Models.Produs.Produs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("Pret")
                        .HasColumnType("bigint");

                    b.Property<string>("ProdusNume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("ExamenDAW.Models.Utilizator.Utilizator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Utilizator");
                });

            modelBuilder.Entity("ExamenDAW.Models.Comanda.Comanda", b =>
                {
                    b.HasOne("ExamenDAW.Models.Utilizator.Utilizator", "Utilizator")
                        .WithMany("Comanda")
                        .HasForeignKey("UtilizatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilizator");
                });

            modelBuilder.Entity("ExamenDAW.Models.ComandaProdus.ComandaProdus", b =>
                {
                    b.HasOne("ExamenDAW.Models.Comanda.Comanda", "Comanda")
                        .WithMany("ComandaProdus")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamenDAW.Models.Produs.Produs", "Produs")
                        .WithMany("ComandaProdus")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("ExamenDAW.Models.Comanda.Comanda", b =>
                {
                    b.Navigation("ComandaProdus");
                });

            modelBuilder.Entity("ExamenDAW.Models.Produs.Produs", b =>
                {
                    b.Navigation("ComandaProdus");
                });

            modelBuilder.Entity("ExamenDAW.Models.Utilizator.Utilizator", b =>
                {
                    b.Navigation("Comanda");
                });
#pragma warning restore 612, 618
        }
    }
}
