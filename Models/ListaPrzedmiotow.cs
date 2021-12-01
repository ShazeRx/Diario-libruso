using System.Collections.Generic;

namespace diario_libruso.Models
{
    public class ListaPrzedmiotow
    {
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public ICollection<Przedmiot> Przedmioty { get; set; }

        public ICollection<Klasa> Klasy { get; set; }
    }
}