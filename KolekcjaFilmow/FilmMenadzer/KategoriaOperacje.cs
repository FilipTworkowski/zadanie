using KolekcjaFilmow.Models;

namespace KolekcjaFilmow.FilmMenadzer
{
    public class KategoriaOperacje : Operacje, IKategoriaOperacje
    {

        public void DodajKategorie(Kategorie kategorie)
        {
            db.Kategories.Add(kategorie);
            db.SaveChanges();
        }

        List<Kategorie> IKategoriaOperacje.ListaKategorii()
        {
            return db.Kategories.ToList();
        }

        Kategorie IKategoriaOperacje.DajKategorie(int id)
        {
            return db.Kategories.FirstOrDefault(x => x.IdKategoria == id);
        }
    }
}
