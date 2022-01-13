using System.Collections;
using System.Collections.Generic;
using diario_libruso.Models;

namespace diario_libruso.ViewModels
{
    public class NowaKlasaViewModel
    {
        public IEnumerable<Uczen> Uczniowie;
        public Klasa Klasa { get; set; }
    }
}