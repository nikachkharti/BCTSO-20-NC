﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todo.Data;

#nullable disable

namespace Todo.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240509174745_Identity")]
    partial class Identity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "33B7ED72-9434-434A-82D4-3018B018CB87",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1327a85d-2a3a-4aed-808e-a002e0878f92",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELi/6wGml22UHrtYVVk+a/nN9J1Kyb3lF3KSvXgsZOueTffBt+Bdlidee9576Z0jng==",
                            PhoneNumber = "555337681",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea80d66c-ff9e-4935-8c25-b7d08cb5be40",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af3ea34d-f2b0-44a8-b595-544dfde980bd",
                            Email = "nika@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "NIKA@GMAIL.COM",
                            NormalizedUserName = "NIKA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKX7Cnk/YFeElMohCjZtstGjtqnzlFtaapccXitWacJkXPTLHajsWb8WuNfRooaflA==",
                            PhoneNumber = "558490645",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49ae04d9-758f-411d-aeab-239d283cbfdc",
                            TwoFactorEnabled = false,
                            UserName = "nika@gmail.com"
                        },
                        new
                        {
                            Id = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b535cb5f-e894-4c60-b982-21cd0e4c3f7d",
                            Email = "gio@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "GIO@GMAIL.COM",
                            NormalizedUserName = "GIO@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJDVTiAn221DXm0v4tVb/OQrYcJsjM2nDaqf2vYkpBkwe/mfNRITV1/ZONmMa9CCKA==",
                            PhoneNumber = "551442269",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "40e665fc-aa69-4932-8adb-c6e508a69742",
                            TwoFactorEnabled = false,
                            UserName = "gio@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                            RoleId = "33B7ED72-9434-434A-82D4-3018B018CB87"
                        },
                        new
                        {
                            UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                            RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B"
                        },
                        new
                        {
                            UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                            RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Todo.Entities.TodoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "პირველი საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 9, 22, 47, 45, 56, DateTimeKind.Local).AddTicks(6415),
                            Priority = 2,
                            StartDate = new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6408),
                            Status = 1,
                            Title = "პირველი საქმე"
                        },
                        new
                        {
                            Id = 2,
                            Description = "მეორე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 9, 22, 47, 45, 56, DateTimeKind.Local).AddTicks(6421),
                            Priority = 1,
                            StartDate = new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6420),
                            Status = 1,
                            Title = "მეორე საქმე"
                        },
                        new
                        {
                            Id = 3,
                            Description = "მესამე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 10, 2, 47, 45, 56, DateTimeKind.Local).AddTicks(6424),
                            Priority = 4,
                            StartDate = new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6423),
                            Status = 2,
                            Title = "მესამე საქმე"
                        },
                        new
                        {
                            Id = 4,
                            Description = "მეოთხე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 16, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6426),
                            Priority = 1,
                            StartDate = new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6425),
                            Status = 1,
                            Title = "მეოთხე საქმე"
                        },
                        new
                        {
                            Id = 5,
                            Description = "მეხუთე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 12, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6429),
                            Priority = 3,
                            StartDate = new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6429),
                            Status = 1,
                            Title = "მეხუთე საქმე"
                        },
                        new
                        {
                            Id = 6,
                            Description = "მეექვსე საქმის აღწერა...",
                            EndDate = new DateTime(2024, 5, 19, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6432),
                            Priority = 2,
                            StartDate = new DateTime(2024, 5, 9, 21, 47, 45, 56, DateTimeKind.Local).AddTicks(6431),
                            Status = 2,
                            Title = "მეექვსე საქმე"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
