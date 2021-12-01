using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace diario_libruso.Models
{
    public class ListaPrzedmiotow
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public virtual ICollection<Przedmiot> Przedmioty { get; set; }

        [ForeignKey("Klasa")] public int KlasaId { get; set; }

        public virtual Klasa Klasa { get; set; }
    }
}