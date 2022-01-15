using System.Collections.Generic;
using diario_libruso.Models;

namespace diario_libruso.ViewModels
{
    public class NowyUczenViewModel
    {
        public IEnumerable<Klasa> Klasy { get; set; }
        public Uczen Uczen { get; set; }
    }
}