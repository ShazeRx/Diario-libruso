using System.Linq;
using diario_libruso.Data;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace diario_libruso.Controllers.Przedmiot
{
    public class PrzedmiotController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrzedmiotController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var przedmioty = _context.Przedmioty.ToList();
            return View(przedmioty);
        }
        
        public ActionResult NowyPrzedmiot()
        {
            var viewModel = new NowyPrzedmiotViewModel();
            return View("PrzedmiotForm", viewModel);
        }
        
        [HttpPost]
        public ActionResult Zapisz(Models.Przedmiot przedmiot)
        {
            if (ModelState.IsValid)
            {
                if (przedmiot.Id == 0)
                    _context.Add(przedmiot);
                else
                {
                    var przedmiotInDb = _context.Przedmioty.Single(r => r.Id == przedmiot.Id);

                    przedmiotInDb.Nazwa = przedmiot.Nazwa;
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Przedmiot");
            }
            return RedirectToAction("Index", "Przedmiot");
        }
        public IActionResult Edit(int id) 
        {
            var przedmiot = _context.Przedmioty.SingleOrDefault(c => c.Id == id);

            if (przedmiot == null)
                return NotFound();

            var viewModel = new NowyPrzedmiotViewModel()
            {
                Przedmiot = przedmiot,
            };
            
    
            return View("PrzedmiotForm", viewModel);
        }
    }
}