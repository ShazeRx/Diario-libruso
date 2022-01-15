using System.Linq;
using diario_libruso.Data;
using diario_libruso.Role;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static diario_libruso.Constants.Constants;

namespace diario_libruso.Controllers.Ogloszenie
{
    [Authorize(Roles = Rola.NAUCZYCIEL)]
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

        [HttpPost]
        public IActionResult Dodaj(Models.Ogloszenie ogloszenie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ogloszenie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Ogloszenie");
        }
    }
}