using KolekcjaFilmow.Models;

namespace KolekcjaFilmow.FilmMenadzer
{
    public interface IFilmOperacje
    {
        Filmy DajFilm(int id);
        List<Filmy> DajFilmy();
        void DodajFilm(Filmy filmy);
        void EdytujFilm(Filmy filmy);
    }
}
