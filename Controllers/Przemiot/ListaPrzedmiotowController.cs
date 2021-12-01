using System.Collections.Generic;
using System.Linq;
using diario_libruso.Data;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace diario_libruso.Controllers.Przemiot
{
    public class ListaPrzedmiotowController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListaPrzedmiotowController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var listyPrzedmiotow =
                _context.ListyPrzedmiotow
                    .Include(listaPrzedmiotow => listaPrzedmiotow.Klasa)
                    .ToList();
            return View(listyPrzedmiotow);
        }

        public IActionResult Dodaj()
        {
            var klasy = _context.Klasy.ToList();
            List<SelectListItem> selectListaPrzedmiotow = new List<SelectListItem>();
            foreach (var przedmiot in _context.Przedmioty.ToList())
            {
                SelectListItem elementListy = new SelectListItem()
                {
                    Text = przedmiot.Nazwa,
                    Value = przedmiot.Id.ToString(),
                    Selected = false
                };
                selectListaPrzedmiotow.Add(elementListy);
            }

            var viewModel = new ListaPrzedmiotowViewModel
            {
                Klasy = klasy,
                Przedmioty = selectListaPrzedmiotow
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Dodaj(ListaPrzedmiotowViewModel listaPrzedmiotowViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaPrzedmiotowViewModel.ListaPrzedmiotow);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "ListaPrzedmiotow");
        }
    }
}