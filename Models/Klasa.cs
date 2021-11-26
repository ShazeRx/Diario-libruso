using System.ComponentModel.DataAnnotations;

namespace diario_libruso.Models
{
    public class Klasa
    {
        public int Id { get; set; }

        [Display(Name = "Nazwa klasy")]
        [MaxLength(2)]
        public string Znak { get; set; }

        public int RokPoczatkowy { get; set; }
    }
}