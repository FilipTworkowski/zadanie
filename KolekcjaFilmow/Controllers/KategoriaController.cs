using KolekcjaFilmow.FilmMenadzer;
using KolekcjaFilmow.Models;
using Microsoft.AspNetCore.Mvc;

namespace KolekcjaFilmow.Controllers
{
    public class KategoriaController : Controller
    {
        private readonly IKategoriaOperacje kategoriaOperacje; 

        public KategoriaController(IKategoriaOperacje kategoriaOperacje)
        {
            this.kategoriaOperacje = kategoriaOperacje;
        }

        public IActionResult DodajKategorie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DodajKategorie(Kategorie kategorie)
        {
            kategoriaOperacje.DodajKategorie(kategorie);
            return RedirectToAction("DodajKategorie");
        }
    }
}
