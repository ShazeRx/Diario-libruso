using System.Linq;
using diario_libruso.Controllers.Ogloszenie;
using diario_libruso.Data;
using diario_libruso.Role;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace diario_libruso.Controllers.Uczen
{
    public class UczenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UczenController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var uczniowie = _context.Uczniowie.ToList();
            return View(uczniowie);
        }

        public ActionResult NowyUczen()
        {
            var klasy = _context.Klasy.ToList();
            var viewModel = new NowyUczenViewModel
            {
                Klasy = klasy
            };
            return View("UczenForm", viewModel);
        }

        [HttpPost]
        public ActionResult Zapisz(Models.Uczen uczen)
        {
            if (ModelState.IsValid)
            {
                if(uczen.Id == 0)
                    _context.Add(uczen);
                else
                {
                    var uczenInDb = _context.Uczniowie.Single(u => u.Id == uczen.Id);

                    uczenInDb.Imie = uczen.Imie;
                    uczenInDb.Nazwisko = uczen.Nazwisko;
                    uczenInDb.KlasaId = uczen.KlasaId;
                }
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Uczen");
        }
        public IActionResult Edit(int id) 
        {
            var uczen = _context.Uczniowie.SingleOrDefault(c => c.Id == id);

            if (uczen == null)
                return NotFound();

            var viewModel = new NowyUczenViewModel()
            {
                Uczen = uczen,
                Klasy = _context.Klasy.ToList()
            };

            return View("UczenForm", viewModel);
        }
    }
}