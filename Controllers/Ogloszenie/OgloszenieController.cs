using System.Linq;
using diario_libruso.Data;
using Microsoft.AspNetCore.Mvc;

namespace diario_libruso.Controllers.Ogloszenie
{
    public class OgloszenieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OgloszenieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var ogloszenia = _context.Ogloszenia.ToList();
            return View(ogloszenia);
        }
        
        public IActionResult Dodaj()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Dodaj(Models.Ogloszenie ogloszenie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ogloszenie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index","Ogloszenie");
        }
    }
}