using System.Collections.Generic;
using diario_libruso.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace diario_libruso.ViewModels
{
    public class ListaPrzedmiotowViewModel
    {
        public ListaPrzedmiotow ListaPrzedmiotow { get; set; }
        public IEnumerable<SelectListItem> Przedmioty { get; set; }
        public IEnumerable<Klasa> Klasy { get; set; }
    }
}