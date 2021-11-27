using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace diario_libruso.Models
{
    public class Uczen
    {
        public int Id { get; set; }

        [ForeignKey("User")] public string IdentityUserId { get; set; }

        public virtual IdentityUser User { get; set; }

        public int NumerDziennika { get; set; }

        [ForeignKey("Klasa")] public int KlasaId { get; set; }

        public virtual Klasa Klasa { get; set; }
    }
}