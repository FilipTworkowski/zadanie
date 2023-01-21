using KolekcjaFilmow.Models;

namespace KolekcjaFilmow.FilmMenadzer
{
    public interface IKategoriaOperacje
    {
        void DodajKategorie(Kategorie kategorie);
        List<Kategorie> ListaKategorii();
        Kategorie DajKategorie(int id);
    }
}
