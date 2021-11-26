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

        public DbSet<Ogloszenie> Ogloszenia { get; set; }
        public DbSet<Klasa> Klasy { get; set; }
    }
}