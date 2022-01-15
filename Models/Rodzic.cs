using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace diario_libruso.Models
{
    public class Rodzic
    {
        public int Id { get; set; }

        [ForeignKey("User")] public string IdentityUserId { get; set; }

        public virtual IdentityUser User { get; set; }

        public string Imie { get; set; }
        
        public string Nazwisko { get; set; }

        public List<Uczen> uczniowie = new List<Uczen>();
        
        [ForeignKey("Uczen")] public int UczenId { get; set; }

        public virtual Uczen Uczen { get; set; }
    }
}