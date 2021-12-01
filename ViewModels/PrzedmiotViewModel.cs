using System.Collections.Generic;
using diario_libruso.Models;
using Microsoft.AspNetCore.Identity;

namespace diario_libruso.ViewModels
{
    public class PrzedmiotViewModel
    {
        public Przedmiot Przedmiot { get; set; }

        public IEnumerable<IdentityUser> Nauczyciele { get; set; }
    }
}