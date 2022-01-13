using System.Collections.Generic;
using diario_libruso.Models;

namespace diario_libruso.ViewModels
{
    public class NowyRodzicViewModel
    {
        public List<Uczen> Uczniowie { get; set; }
        public Rodzic Rodzic { get; set; }
    }
}