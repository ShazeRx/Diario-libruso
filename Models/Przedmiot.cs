using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace diario_libruso.Models
{
    public class Przedmiot
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public string Opis { get; set; }

        [ForeignKey("Nauczyciel")] public string IdNauczyciela { get; set; }

        public virtual IdentityUser Nauczyciel { get; set; }

        public virtual ICollection<ListaPrzedmiotow> ListaPrzedmiotow { get; set; }
    }
}