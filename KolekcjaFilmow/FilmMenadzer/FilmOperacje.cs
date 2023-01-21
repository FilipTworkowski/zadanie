using KolekcjaFilmow.Models;

namespace KolekcjaFilmow.FilmMenadzer
{
    public class FilmOperacje : Operacje, IFilmOperacje
    {
        public Filmy DajFilm(int id)
        {
            return db.Filmies.FirstOrDefault(x => x.IdFilm == id);
        }

        public List<Filmy> DajFilmy()
        {
            return db.Filmies.ToList();
        }

        public void DodajFilm(Filmy filmy)
        {
            db.Filmies.Add(filmy);
            db.SaveChanges();
        }

        public void EdytujFilm(Filmy filmy)
        {
            Filmy edytowany = DajFilm(filmy.IdFilm);
            edytowany.Tytul = filmy.Tytul;
            edytowany.IdGatunek = filmy.IdGatunek;
            edytowany.Rezyser = filmy.Rezyser;
            db.SaveChanges();
        }
    }
}
