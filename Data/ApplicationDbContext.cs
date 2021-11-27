using System;
using System.Threading.Tasks;
using diario_libruso.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static diario_libruso.Constants.Constants;

namespace diario_libruso.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var ADMIN_USERNAME = "admin@email.com";
            var RODZIC_USERNAME = "rodzic@email.com";
            var NAUCZYCIEL_USERNAME = "nauczyciel@email.com";
            var UCZEN_USERNAME = "uczen@email.com";

            //Klasy
            builder.Entity<Klasa>().HasData(
                new Klasa
                {
                    Id = 1,
                    Znak = "3C",
                    RokPoczatkowy = 2016
                },
                new Klasa
                {
                    Id = 2,
                    Znak = "$C",
                    RokPoczatkowy = 2015
                });

            //Ogloszenia klasowe
            builder.Entity<OgloszenieKlasowe>().HasData(new OgloszenieKlasowe
            {
                Id = 6,
                DataDodania = DateTime.Today,
                KlasaId = 1,
                Tresc = "Super wazne",
                Tytul = "Mega wazne"
            });

            //Ogloszenia ogolne
            builder.Entity<Ogloszenie>().HasData(
                new Ogloszenie
                {
                    Id = 5,
                    Tytul = "Wazne!!!",
                    Tresc = "Bardzo wazne",
                    DataDodania = DateTime.Now
                });

            //Hasher do hasel
            var hasher = new PasswordHasher<IdentityUser>();

            //Admin
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "e445865-a24d-4543-a6c6-9443d048cdb9",
                    UserName = ADMIN_USERNAME,
                    NormalizedUserName = ADMIN_USERNAME.ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "password")
                });

            //Rodzic
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "e445865-a24d-4543-a6c6-9443d038cdb9",
                    UserName = RODZIC_USERNAME,
                    NormalizedUserName = RODZIC_USERNAME.ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "password")
                });

            //Uczen
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "e445865-a24d-6543-a6c6-9443d048cdb9",
                    UserName = UCZEN_USERNAME,
                    NormalizedUserName = UCZEN_USERNAME.ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "password")
                });

            //Nauczyciel
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "e445865-a24d-6543-a6c6-9443d048cab9",
                    UserName = RODZIC_USERNAME,
                    NormalizedUserName = NAUCZYCIEL_USERNAME.ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "password")
                });

            // Uczen model customowy
            builder.Entity<Uczen>().HasData(
                new Uczen
                {
                    Id = 87,
                    IdentityUserId = "e445865-a24d-6543-a6c6-9443d048cdb9",
                    KlasaId = 1,
                    NumerDziennika = 2
                });


            //Rola admina
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = Rola.ADMINISTRATOR,
                NormalizedName = Rola.ADMINISTRATOR.ToUpper()
            });

            //Rola ucznia
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = Rola.UCZEN, NormalizedName = Rola.UCZEN.ToUpper()
            });

            //Rola rodzica
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7212", Name = Rola.RODZIC, NormalizedName = Rola.RODZIC.ToUpper()
            });

            //Rola rodzica
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7213", Name = Rola.NAUCZYCIEL,
                NormalizedName = Rola.NAUCZYCIEL.ToUpper()
            });


            //Łączenie roli admina
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );

            //Łączenie roli ucznia
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    UserId = "e445865-a24d-6543-a6c6-9443d048cdb9"
                }
            );

            //Łączenie roli rodzica
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                    UserId = "e445865-a24d-4543-a6c6-9443d038cdb9"
                }
            );

            //Łączenie roli nauczyciela
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7213",
                    UserId = "e445865-a24d-6543-a6c6-9443d048cab9"
                }
            );


            base.OnModelCreating(builder);
        }

        public DbSet<Ogloszenie> Ogloszenia { get; set; }
        public DbSet<OgloszenieKlasowe> OgloszeniaKlasowe { get; set; }
        public DbSet<Klasa> Klasy { get; set; }

        public DbSet<Uczen> Uczniowie { get; set; }
    }
}