using System.Collections.Generic;
using diario_libruso.Models;

namespace diario_libruso.ViewModels
{
    public class OgloszenieKlasoweViewModel
    {
        public OgloszenieKlasowe OgloszenieKlasowe { get; set; }
        public IEnumerable<Klasa> Klasy { get; set; }
    }
}