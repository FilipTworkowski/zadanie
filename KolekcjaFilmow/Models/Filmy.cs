using System;
using System.Collections.Generic;

namespace KolekcjaFilmow.Models;

public partial class Filmy
{
    public int IdFilm { get; set; }

    public int? IdGatunek { get; set; }

    public string? Rezyser { get; set; }

    public string? Tytul { get; set; }
}
