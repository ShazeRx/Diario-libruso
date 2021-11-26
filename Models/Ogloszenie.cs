using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace diario_libruso.Models
{
    public class Ogloszenie
    {
        public int Id { get; set; }

        public string Tytul { get; set; }

        public string Tresc { get; set; }

        [Required]
        public DateTime DataDodania { get; set; } = DateTime.Now;
    }

    public class OgloszenieKlasowe : Ogloszenie
    {
        [ForeignKey("klasa")] public int KlasaId { get; set; }
        public virtual Klasa Klasa { get; set; }
    }
}