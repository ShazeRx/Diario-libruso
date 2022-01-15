using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace diario_libruso.Models
{
    public class Nauczyciel
    {
        public int Id { get; set; }

        [ForeignKey("User")] public string IdentityUserId { get; set; }

        public virtual IdentityUser User { get; set; }
        [Required]
        public string Imie { get; set; }
        
        public string Nazwisko { get; set; }
        
        [Display(Name = "Wybierz klasę, jeśli nauczyciel ma zostać wychowawcą")]
        [ForeignKey("Klasa")] public int KlasaId { get; set; }
        public virtual Klasa Klasa { get; set; }
    }
}
