﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using diario_libruso.Data;

namespace diario_libruso.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211201085153_PrzemiotyListyPrzedmiotow")]
    partial class PrzemiotyListyPrzedmiotow
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "b98939f3-4964-44dd-9e84-73a82fe9e7bc",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                            ConcurrencyStamp = "b36997c3-4a61-4a39-be59-52d9f20289c7",
                            Name = "Uczen",
                            NormalizedName = "UCZEN"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                            ConcurrencyStamp = "3ff2d8ae-9512-4fd9-888b-a66fd6059f1e",
                            Name = "Rodzic",
                            NormalizedName = "RODZIC"
                        },
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7213",
                            ConcurrencyStamp = "f9f7dd7d-1195-4d55-8e2f-10903f475f01",
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
                            ConcurrencyStamp = "e2ab10c9-0f04-4565-b526-19dca2838757",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAKlhfx//t8sV66jO6wPxeQcPyK9L0LhTY24TQVILb0YdSbEJcNkmKK1rrWxPPyl/g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ee6b580-6622-4da2-b08b-8eafb07f4456",
                            TwoFactorEnabled = false,
                            UserName = "admin@email.com"
                        },
                        new
                        {
                            Id = "e445865-a24d-4543-a6c6-9443d038cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cc3bedbe-5cc1-4289-a7e2-abf1f135ec0c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "RODZIC@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFkCDfqGHoWN/Q4VsLddUzrZ60bzxeUtAivy33APTyW8uIiGES8ooMBTei3NIaPdPQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dabd0b0c-6ef3-48e4-a37f-1de6f6318d1d",
                            TwoFactorEnabled = false,
                            UserName = "rodzic@email.com"
                        },
                        new
                        {
                            Id = "e445865-a24d-6543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5d85831b-fc7a-423a-9eee-9581f0d37c8f",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "UCZEN@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECU/6FKksi604coXnCu8ZJsmsWGB5HEojLDRKjNkisoGJlBkL6LWYRe4KGJpUvhl3Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a262184f-ef3a-4e3c-97a4-dc6e6719809d",
                            TwoFactorEnabled = false,
                            UserName = "uczen@email.com"
                        },
                        new
                        {
                            Id = "e445865-a24d-6543-a6c6-9443d048cab9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8e52b059-d2e9-40e5-bf4e-6a9605cbc355",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "NAUCZYCIEL@EMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPzjGjAo/Ns5GmpfNj9dQIa55azy88lhDU+aAvv76AbNZitPJO1t+X22QK96iTSkeA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eebac68b-57e0-4434-af71-684cb859b8a5",
                            TwoFactorEnabled = false,
                            UserName = "nauczyciel@email.com"
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

                    b.Property<int?>("ListaPrzedmiotowId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RokPoczatkowy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Znak")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ListaPrzedmiotowId");

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
                            Znak = ""
                        });
                });

            modelBuilder.Entity("diario_libruso.Models.ListaPrzedmiotow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nazwa")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ListyPrzedmiotow");
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
                            DataDodania = new DateTime(2021, 12, 1, 9, 51, 52, 42, DateTimeKind.Local).AddTicks(9790),
                            Tresc = "Bardzo wazne",
                            Tytul = "Wazne!!!"
                        });
                });

            modelBuilder.Entity("diario_libruso.Models.Przedmiot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdNauczyciela")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ListaPrzedmiotowId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nazwa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Opis")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdNauczyciela");

                    b.HasIndex("ListaPrzedmiotowId");

                    b.ToTable("Przedmioty");
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
                            DataDodania = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Local),
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

            modelBuilder.Entity("diario_libruso.Models.Klasa", b =>
                {
                    b.HasOne("diario_libruso.Models.ListaPrzedmiotow", "ListaPrzedmiotow")
                        .WithMany("Klasy")
                        .HasForeignKey("ListaPrzedmiotowId");

                    b.Navigation("ListaPrzedmiotow");
                });

            modelBuilder.Entity("diario_libruso.Models.Przedmiot", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Nauczyciel")
                        .WithMany()
                        .HasForeignKey("IdNauczyciela");

                    b.HasOne("diario_libruso.Models.ListaPrzedmiotow", null)
                        .WithMany("Przedmioty")
                        .HasForeignKey("ListaPrzedmiotowId");

                    b.Navigation("Nauczyciel");
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

            modelBuilder.Entity("diario_libruso.Models.ListaPrzedmiotow", b =>
                {
                    b.Navigation("Klasy");

                    b.Navigation("Przedmioty");
                });
#pragma warning restore 612, 618
        }
    }
}