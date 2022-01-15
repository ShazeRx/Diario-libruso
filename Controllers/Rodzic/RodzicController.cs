using System.Linq;
using diario_libruso.Data;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace diario_libruso.Controllers.Rodzic
{
    public class RodzicController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RodzicController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var rodzice = _context.Rodzice.ToList();
            return View(rodzice);
        }
        
        public ActionResult NowyRodzic()
        {
            var uczniowie = _context.Uczniowie.ToList();
            var viewModel = new NowyRodzicViewModel
            {
                Uczniowie = uczniowie
            };
            return View("RodzicForm",viewModel);
        }
        
        [HttpPost]
        public ActionResult Zapisz(Models.Rodzic rodzic)
        {
            if (ModelState.IsValid)
            {
                if (rodzic.Id == 0)
                {
                    _context.Add(rodzic);
                }
                else
                {
                    var rodzicInDb = _context.Rodzice.Single(r => r.Id == rodzic.Id);

                    rodzicInDb.Imie = rodzic.Imie;
                    rodzicInDb.Nazwisko = rodzic.Nazwisko;
                    rodzicInDb.UczenId = rodzic.UczenId;
                }
                _context.SaveChanges();
                
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Rodzic");
        }
        public IActionResult Edit(int id) 
        {
            var rodzic = _context.Rodzice.SingleOrDefault(c => c.Id == id);

            if (rodzic == null)
                return NotFound();

            var viewModel = new NowyRodzicViewModel()
            {
                Rodzic = rodzic,
                Uczniowie = _context.Uczniowie.ToList()
            };
            
    
            return View("RodzicForm", viewModel);
        }
    }
}