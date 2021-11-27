﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using diario_libruso.Data;

namespace diario_libruso.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "891fc6db-d034-4a2c-84c1-ff81c16144ce",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            ConcurrencyStamp = "2c63b998-8c21-48df-9419-233d12ed6959",
                            Name = "Uczen",
                            NormalizedName = "UCZEN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                            ConcurrencyStamp = "09bbd94f-aa9f-4f0d-94af-63cf88bae513",
                            Name = "Rodzic",
                            NormalizedName = "RODZIC"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7213",
                            ConcurrencyStamp = "978073e2-e2af-4da6-9717-e70e10471af6",
                            Name = "Nauczyciel",
                            NormalizedName = "NAUCZYCIEL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f392f69-e543-4808-9486-3d177833c3a2",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENetbKdMqlTtkJWNb3Ojj5NrVaDE3k4Bj0dMG7E3cm/E1ma9EQjA1e0asiC3A0RfWg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d3883eef-56f5-4b65-9264-9e09e805f54c",
                            TwoFactorEnabled = false,
                            UserName = "admin@email.com"
                        },
                        new
                        {
                            Id = "e445865-a24d-4543-a6c6-9443d038cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "df010c8c-e4d6-4bb4-ab0b-a6bba6ad6944",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "RODZIC@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBcV+D0KQPaLWAm8cfC9RYe2iJCc55ycb/yWwI4wc5iBzTngR0deOGp9lIO5nN1jzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "238beb60-0b60-4642-a208-22639121b8ea",
                            TwoFactorEnabled = false,
                            UserName = "rodzic@email.com"
                        },
                        new
                        {
                            Id = "e445865-a24d-6543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "69e2b165-1e19-43db-b762-9142f39ce539",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "UCZEN@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELdM+emZvFHzu+G5kccq4buD3usFV4Gv3UIjWbatimGxo1FUOwh1QdOdfXHCnC2yLA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3e03a593-9ba3-4579-9f03-b005c3c6e174",
                            TwoFactorEnabled = false,
                            UserName = "uczen@email.com"
                        },
                        new
                        {
                            Id = "e445865-a24d-6543-a6c6-9443d048cab9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "63da66ef-8ef5-4544-bb21-a7855a78ccaf",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "NAUCZYCIEL@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKhZeYAt6wiyw+v9FciK4DXv77owaDEgdgRgFMld3ida/U3i2rB36RCYaR+BkamipQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8159d7fa-b0df-40dd-b36d-4e47f138e4e8",
                            TwoFactorEnabled = false,
                            UserName = "rodzic@email.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        },
                        new
                        {
                            UserId = "e445865-a24d-6543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211"
                        },
                        new
                        {
                            UserId = "e445865-a24d-4543-a6c6-9443d038cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212"
                        },
                        new
                        {
                            UserId = "e445865-a24d-6543-a6c6-9443d048cab9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7213"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("diario_libruso.Models.Klasa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RokPoczatkowy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Znak")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Klasy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RokPoczatkowy = 2016,
                            Znak = "3C"
                        },
                        new
                        {
                            Id = 2,
                            RokPoczatkowy = 2015,
                            Znak = "$C"
                        });
                });

            modelBuilder.Entity("diario_libruso.Models.Ogloszenie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tresc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tytul")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ogloszenia");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Ogloszenie");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            DataDodania = new DateTime(2021, 11, 27, 14, 31, 52, 316, DateTimeKind.Local).AddTicks(1880),
                            Tresc = "Bardzo wazne",
                            Tytul = "Wazne!!!"
                        });
                });

            modelBuilder.Entity("diario_libruso.Models.Uczen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("KlasaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumerDziennika")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.HasIndex("KlasaId");

                    b.ToTable("Uczniowie");

                    b.HasData(
                        new
                        {
                            Id = 87,
                            IdentityUserId = "e445865-a24d-6543-a6c6-9443d048cdb9",
                            KlasaId = 1,
                            NumerDziennika = 2
                        });
                });

            modelBuilder.Entity("diario_libruso.Models.OgloszenieKlasowe", b =>
                {
                    b.HasBaseType("diario_libruso.Models.Ogloszenie");

                    b.Property<int>("KlasaId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("KlasaId");

                    b.HasDiscriminator().HasValue("OgloszenieKlasowe");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            DataDodania = new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            Tresc = "Super wazne",
                            Tytul = "Mega wazne",
                            KlasaId = 1
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

            modelBuilder.Entity("diario_libruso.Models.Uczen", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.HasOne("diario_libruso.Models.Klasa", "Klasa")
                        .WithMany("Uczniowie")
                        .HasForeignKey("KlasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klasa");

                    b.Navigation("User");
                });

            modelBuilder.Entity("diario_libruso.Models.OgloszenieKlasowe", b =>
                {
                    b.HasOne("diario_libruso.Models.Klasa", "Klasa")
                        .WithMany()
                        .HasForeignKey("KlasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klasa");
                });

            modelBuilder.Entity("diario_libruso.Models.Klasa", b =>
                {
                    b.Navigation("Uczniowie");
                });
#pragma warning restore 612, 618
        }
    }
}
