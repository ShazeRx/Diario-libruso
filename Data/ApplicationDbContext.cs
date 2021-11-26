using System;
using System.Collections.Generic;
using System.Text;
using diario_libruso.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
            builder.Entity<OgloszenieKlasowe>().HasData(new OgloszenieKlasowe
            {
                Id = 6,
                DataDodania = DateTime.Today,
                KlasaId = 1,
                Tresc = "Super wazne",
                Tytul = "Mega wazne"
            });
            builder.Entity<Ogloszenie>().HasData(
                new Ogloszenie
                {
                    Id = 5,
                    Tytul = "Wazne!!!",
                    Tresc = "Bardzo wazne",
                    DataDodania = DateTime.Now
                });
            base.OnModelCreating(builder);
        }

        public DbSet<Ogloszenie> Ogloszenia { get; set; }
        public DbSet<OgloszenieKlasowe> OgloszeniaKlasowe { get; set; }
        public DbSet<Klasa> Klasy { get; set; }
    }
}