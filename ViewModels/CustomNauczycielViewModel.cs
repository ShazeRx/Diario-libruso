using System.Collections.Generic;
using diario_libruso.Models;

namespace diario_libruso.ViewModels
{
    public class NowyNauczycielViewModel
    {
        public IEnumerable<Klasa> Klasy { get; set; }
        public Nauczyciel Nauczyciel { get; set; }
    }
}