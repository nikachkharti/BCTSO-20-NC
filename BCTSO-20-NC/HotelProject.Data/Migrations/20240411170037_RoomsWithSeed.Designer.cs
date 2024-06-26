﻿// <auto-generated />
using HotelProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240411170037_RoomsWithSeed")]
    partial class RoomsWithSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelProject.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhyisicalAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "თბილისი",
                            Country = "საქართველო",
                            Name = "პირველი სასტუმრო",
                            PhyisicalAddress = "რუსთაველის 4",
                            Rating = 10.0
                        },
                        new
                        {
                            Id = 2,
                            City = "თბილისი",
                            Country = "საქართველო",
                            Name = "მეორე სასტუმრო",
                            PhyisicalAddress = "პეკინის 13",
                            Rating = 8.0
                        },
                        new
                        {
                            Id = 3,
                            City = "თბილისი",
                            Country = "საქართველო",
                            Name = "მესამე სასტუმრო",
                            PhyisicalAddress = "გამსახურდიას 12",
                            Rating = 7.7000000000000002
                        });
                });

            modelBuilder.Entity("HotelProject.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId")
                        .IsUnique();

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "გიორგი",
                            HotelId = 1,
                            LastName = "გიორგაძე"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "თამაზი",
                            HotelId = 2,
                            LastName = "გოდერძიშვილი"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "გოირგი",
                            HotelId = 3,
                            LastName = "გუჯარელიძე"
                        });
                });

            modelBuilder.Entity("HotelProject.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DailyPrice")
                        .HasColumnType("float");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DailyPrice = 50.0,
                            HotelId = 1,
                            IsFree = false,
                            Name = "A-100"
                        },
                        new
                        {
                            Id = 2,
                            DailyPrice = 50.0,
                            HotelId = 1,
                            IsFree = false,
                            Name = "A-200"
                        },
                        new
                        {
                            Id = 3,
                            DailyPrice = 50.0,
                            HotelId = 1,
                            IsFree = true,
                            Name = "A-300"
                        },
                        new
                        {
                            Id = 4,
                            DailyPrice = 100.0,
                            HotelId = 1,
                            IsFree = true,
                            Name = "B-100"
                        },
                        new
                        {
                            Id = 5,
                            DailyPrice = 100.0,
                            HotelId = 1,
                            IsFree = false,
                            Name = "B-200"
                        },
                        new
                        {
                            Id = 6,
                            DailyPrice = 100.0,
                            HotelId = 1,
                            IsFree = false,
                            Name = "B-300"
                        },
                        new
                        {
                            Id = 7,
                            DailyPrice = 200.0,
                            HotelId = 1,
                            IsFree = true,
                            Name = "C-100"
                        },
                        new
                        {
                            Id = 8,
                            DailyPrice = 200.0,
                            HotelId = 1,
                            IsFree = false,
                            Name = "C-200"
                        },
                        new
                        {
                            Id = 9,
                            DailyPrice = 200.0,
                            HotelId = 1,
                            IsFree = false,
                            Name = "C-300"
                        },
                        new
                        {
                            Id = 10,
                            DailyPrice = 25.0,
                            HotelId = 2,
                            IsFree = true,
                            Name = "100"
                        },
                        new
                        {
                            Id = 11,
                            DailyPrice = 25.0,
                            HotelId = 2,
                            IsFree = true,
                            Name = "101"
                        },
                        new
                        {
                            Id = 12,
                            DailyPrice = 25.0,
                            HotelId = 2,
                            IsFree = false,
                            Name = "102"
                        },
                        new
                        {
                            Id = 13,
                            DailyPrice = 50.0,
                            HotelId = 2,
                            IsFree = true,
                            Name = "200"
                        },
                        new
                        {
                            Id = 14,
                            DailyPrice = 50.0,
                            HotelId = 2,
                            IsFree = false,
                            Name = "201"
                        },
                        new
                        {
                            Id = 15,
                            DailyPrice = 50.0,
                            HotelId = 2,
                            IsFree = false,
                            Name = "202"
                        },
                        new
                        {
                            Id = 16,
                            DailyPrice = 75.0,
                            HotelId = 2,
                            IsFree = true,
                            Name = "300"
                        },
                        new
                        {
                            Id = 17,
                            DailyPrice = 75.0,
                            HotelId = 2,
                            IsFree = true,
                            Name = "301"
                        },
                        new
                        {
                            Id = 18,
                            DailyPrice = 75.0,
                            HotelId = 2,
                            IsFree = true,
                            Name = "302"
                        },
                        new
                        {
                            Id = 19,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = false,
                            Name = "A-10"
                        },
                        new
                        {
                            Id = 20,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = true,
                            Name = "A-20"
                        },
                        new
                        {
                            Id = 21,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = true,
                            Name = "A-30"
                        },
                        new
                        {
                            Id = 22,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = false,
                            Name = "B-10"
                        },
                        new
                        {
                            Id = 23,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = false,
                            Name = "B-20"
                        },
                        new
                        {
                            Id = 24,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = true,
                            Name = "B-30"
                        },
                        new
                        {
                            Id = 25,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = true,
                            Name = "C-10"
                        },
                        new
                        {
                            Id = 26,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = false,
                            Name = "C-20"
                        },
                        new
                        {
                            Id = 27,
                            DailyPrice = 150.0,
                            HotelId = 3,
                            IsFree = true,
                            Name = "C-30"
                        });
                });

            modelBuilder.Entity("HotelProject.Models.Manager", b =>
                {
                    b.HasOne("HotelProject.Models.Hotel", "Hotel")
                        .WithOne("Manager")
                        .HasForeignKey("HotelProject.Models.Manager", "HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("HotelProject.Models.Room", b =>
                {
                    b.HasOne("HotelProject.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("HotelProject.Models.Hotel", b =>
                {
                    b.Navigation("Manager");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
