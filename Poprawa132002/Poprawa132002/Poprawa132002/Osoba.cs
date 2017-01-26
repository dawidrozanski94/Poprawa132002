using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int podstawa;

        public virtual int ObliczPensje() // metoda z punktu 1b)
        {
            return this.podstawa = podstawa;
        }

        public Osoba(string imie, string nazwisko, int podstawa) // konstruktor parametryczny, 1c)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.podstawa = podstawa;
        }

    }
}
