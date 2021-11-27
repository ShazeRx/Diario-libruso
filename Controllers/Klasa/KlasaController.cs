using System.Linq;
using diario_libruso.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static diario_libruso.Constants.Constants;

namespace diario_libruso.Controllers.Klasa
{
    [Authorize(Roles = Rola.ADMINISTRATOR)]
    public class KlasaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KlasaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var klasy = _context.Klasy.ToList();
            return View(klasy);
        }

        public IActionResult Dodaj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dodaj(Models.Klasa klasa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(klasa);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Klasa");
        }
    }
}