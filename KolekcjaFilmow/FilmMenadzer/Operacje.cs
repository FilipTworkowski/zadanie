using KolekcjaFilmow.Models;

namespace KolekcjaFilmow.FilmMenadzer
{
    public abstract class Operacje
    {
        protected readonly KolekcjaFilmowContext db = new KolekcjaFilmowContext();
    }
}
