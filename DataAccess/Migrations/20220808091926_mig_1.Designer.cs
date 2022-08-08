﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TrainContext))]
    [Migration("20220808091926_mig_1")]
    partial class mig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("NumberOfPersonsToReservation")
                        .HasColumnType("int");

                    b.Property<bool>("PersonsCanBePlacedOnDifferentWagons")
                        .HasColumnType("bit");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.Property<int>("VagonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Entities.Concrete.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ReservationsId")
                        .HasColumnType("int");

                    b.Property<string>("TrainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VagonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationsId");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("Entities.Concrete.Vagon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("ReservationsId")
                        .HasColumnType("int");

                    b.Property<int>("Seat")
                        .HasColumnType("int");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.Property<string>("VagonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationsId");

                    b.HasIndex("TrainId");

                    b.ToTable("Vagons");
                });

            modelBuilder.Entity("Entities.Concrete.Train", b =>
                {
                    b.HasOne("Entities.Concrete.Reservation", "Reservations")
                        .WithMany("Trains")
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Entities.Concrete.Vagon", b =>
                {
                    b.HasOne("Entities.Concrete.Reservation", "Reservations")
                        .WithMany("Vagons")
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Train", "Train")
                        .WithMany("Vagons")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservations");

                    b.Navigation("Train");
                });

            modelBuilder.Entity("Entities.Concrete.Reservation", b =>
                {
                    b.Navigation("Trains");

                    b.Navigation("Vagons");
                });

            modelBuilder.Entity("Entities.Concrete.Train", b =>
                {
                    b.Navigation("Vagons");
                });
#pragma warning restore 612, 618
        }
    }
}
