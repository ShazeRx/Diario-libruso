using System.Linq;
using diario_libruso.Data;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace diario_libruso.Controllers.Ogloszenie
{
    public class OgloszenieKlasoweController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OgloszenieKlasoweController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var ogloszenia = _context.OgloszeniaKlasowe.ToList();
            return View(ogloszenia);
        }
        public IActionResult Dodaj()
        {
            var klasy = _context.Klasy.ToList();
            var ogloszenieKlasoweViewModel = new OgloszenieKlasoweViewModel
            {
                Klasy = klasy
            };
            return View(ogloszenieKlasoweViewModel);
        }
        [HttpPost]
        public IActionResult Dodaj(OgloszenieKlasoweViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.OgloszeniaKlasowe.Add(viewModel.OgloszenieKlasowe);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index","OgloszenieKlasowe");
        }
    }
}