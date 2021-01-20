using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati2
{
    public class Knjiga    // Opis k u listi k:
    {
        public string Naslov; // Naslov knjige.
        public string Autor; // Autor knjige.
        public decimal Cena; // Cena knjige.
        public bool Tvrdpovez; // Da li je tvrd povez?

        public Knjiga(string naslov, string autor, decimal cena, bool tvrdPovez)
        {
            Naslov = naslov;
            Autor = autor;
            Cena = cena;
            Tvrdpovez = tvrdPovez;
        }
    }
}
