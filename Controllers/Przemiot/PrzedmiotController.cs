using System.Collections.Generic;
using System.Linq;
using diario_libruso.Data;
using diario_libruso.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static diario_libruso.Constants.Constants;

namespace diario_libruso.Controllers.Przemiot
{
    public class PrzedmiotController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrzedmiotController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var przedmioty = _context.Przedmioty
                .Include(przedmiot => przedmiot.Nauczyciel)
                .ToList();
            return View(przedmioty);
        }

        public IActionResult Dodaj()
        {
            IEnumerable<IdentityUser> nauczyciele = _context.Users.Join(
                _context.UserRoles,
                user => user.Id,
                roleUser => roleUser.UserId,
                (user, roleUser) => new
                {
                    user,
                    roleUser
                }
            ).Join(
                _context.Roles,
                userRole => userRole.roleUser.RoleId,
                role => role.Id,
                (userRole, role) => new
                {
                    userRole,
                    role
                }
            ).Where(role => role.role.Name == Rola.NAUCZYCIEL).Select(x => x.userRole.user).ToList();

            var ogloszenieKlasoweViewModel = new PrzedmiotViewModel
            {
                Nauczyciele = nauczyciele
            };
            return View(ogloszenieKlasoweViewModel);
        }

        [HttpPost]
        public IActionResult Dodaj(PrzedmiotViewModel przedmiotViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Przedmioty.Add(przedmiotViewModel.Przedmiot);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Przedmiot");
        }
    }
}