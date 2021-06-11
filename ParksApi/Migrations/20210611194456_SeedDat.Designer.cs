﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

namespace ParkApi.Migrations
{
    [DbContext(typeof(ParkApiContext))]
    [Migration("20210611194456_SeedDat")]
    partial class SeedDat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SqMiles")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Yellowstone",
                            SqMiles = 3471,
                            State = "Wyoming and Idaho"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Arches National Park",
                            SqMiles = 120,
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Yosemite National Park",
                            SqMiles = 1169,
                            State = "California"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Glacier National Park",
                            SqMiles = 1583,
                            State = "Montana"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Canyonlands National Park",
                            SqMiles = 527,
                            State = "Utah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
