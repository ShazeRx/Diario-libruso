using System.Linq;
using diario_libruso.Data;
using Microsoft.AspNetCore.Mvc;

namespace diario_libruso.Controllers.Ogloszenia
{
    public class OgloszenieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OgloszenieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Ogloszenia()
        {
            var ogloszenia = _context.Ogloszenia.ToList();
            return View(ogloszenia);
        }
    }
}