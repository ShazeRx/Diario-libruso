using System.Linq;
using diario_libruso.Data;
using diario_libruso.ViewModels;
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

        public ActionResult NowaKlasa()
        {
            var uczniowie = _context.Uczniowie.ToList();
            var viewModel = new NowaKlasaViewModel
            {
                Klasa = new Models.Klasa(),
                Uczniowie = uczniowie
            };
            return View("KlasaForm", viewModel);
        }

        [HttpPost]
        public IActionResult Zapisz(Models.Klasa klasa)
        {
            if (ModelState.IsValid)
            {
                if(klasa.Id == 0)
                    _context.Add(klasa);
                else
                {
                    var klasaInDb = _context.Klasy.Single(k => k.Id == klasa.Id);

                    klasaInDb.Znak = klasa.Znak;
                    klasaInDb.RokPoczatkowy = klasa.RokPoczatkowy;
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Klasa");
        }

        public IActionResult Edit(int id)
        {
            var klasa = _context.Klasy.SingleOrDefault(c => c.Id == id);

            if (klasa == null)
                return NotFound();

            var viewModel = new NowaKlasaViewModel()
            {
                Klasa = klasa,
                Uczniowie = _context.Uczniowie.ToList()
            };

            return View("KlasaForm", viewModel);
        }
    }
}