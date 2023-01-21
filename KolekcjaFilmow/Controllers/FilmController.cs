using KolekcjaFilmow.FilmMenadzer;
using KolekcjaFilmow.Models;
using Microsoft.AspNetCore.Mvc;

namespace KolekcjaFilmow.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmOperacje filmOperacje;
        private readonly IKategoriaOperacje kategoriaOperacje;

        public FilmController(IFilmOperacje filmOperacje, IKategoriaOperacje kategoriaOperacje)
        {
            this.filmOperacje = filmOperacje;
            this.kategoriaOperacje = kategoriaOperacje;
        }

        public IActionResult WyswietlFilm(int FilmId)
        {
            ViewBag.Film = filmOperacje.DajFilm(FilmId);
            return View();
        }

        public IActionResult WyswietlListeFilmow()
        {
            ViewBag.Filmy = filmOperacje.DajFilmy();
            return View();
        }

        public IActionResult DodajFilm()
        {
            ViewBag.Gatunek = kategoriaOperacje.ListaKategorii();
            return View();
        }

        [HttpPost]
        public IActionResult DodajFilm(Filmy filmy)
        {
            filmOperacje.DodajFilm(filmy);
            return RedirectToAction("WyswietlListeFilmow");
        }

        [HttpPost]
        public IActionResult EdytujFilm(Filmy filmy)
        {
            ViewBag.Film = filmOperacje.DajFilm(filmy.IdFilm);
            ViewBag.Gatunek = kategoriaOperacje.ListaKategorii();
            ViewBag.Kategoria = kategoriaOperacje.DajKategorie((int)ViewBag.Film.IdGatunek);
            return View();
        }

        [HttpPost]
        public IActionResult EdytowanieFilmu(Filmy filmy)
        {
            filmOperacje.EdytujFilm(filmy);
            return RedirectToAction("WyswietlListeFilmow");
        }
    }
}
