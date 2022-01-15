using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using diario_libruso.Areas.Identity.Pages.Account;
using diario_libruso.Data;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace diario_libruso.Controllers.Nauczyciel
{
    public class NauczycielController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NauczycielController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var nauczyciele = _context.Nauczyciele.ToList();
            return View(nauczyciele);
        }
        
        public ActionResult NowyNauczyciel()
        {
            var klasy = _context.Klasy.ToList();
            var viewModel = new NowyNauczycielViewModel
            {
                Nauczyciel = new Models.Nauczyciel(),
                Klasy = klasy,
            };
            return View("NauczycielForm", viewModel);
        }
        
        [HttpPost]
        public ActionResult Zapisz(Models.Nauczyciel nauczyciel)
        {
            if (ModelState.IsValid)
            {
                if (nauczyciel.Id == 0)
                {
                    _context.Add(nauczyciel);
                    nauczyciel.User.Email = nauczyciel.Imie + nauczyciel.Nazwisko + "libruso.com";
                    nauczyciel.User.PasswordHash = nauczyciel.Imie;
                }
                else
                {
                    var nauczycielInDb = _context.Nauczyciele.Single(n => n.Id == nauczyciel.Id);
                    
                    nauczycielInDb.Imie = nauczyciel.Imie;
                    nauczycielInDb.Nazwisko = nauczyciel.Nazwisko;
                    nauczycielInDb.KlasaId = nauczyciel.KlasaId;
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Nauczyciel");
        }

        public IActionResult Edit(int id) 
        {
           var nauczyciel = _context.Nauczyciele.SingleOrDefault(c => c.Id == id);

           if (nauczyciel == null)
                return NotFound();

           var viewModel = new NowyNauczycielViewModel()
            {
                Nauczyciel = nauczyciel,
                Klasy = _context.Klasy.ToList()
            };
           
            return View("NauczycielForm", viewModel);
        }
    }
}