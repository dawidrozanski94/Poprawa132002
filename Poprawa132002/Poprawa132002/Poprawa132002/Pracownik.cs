using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
     class Pracownik : Osoba
    {
        private int staz;


        public virtual int ObliczPensje() // przesloniecie metody, podpunkt 2b)
        {
            return (base.ObliczPensje() + (this.staz * 100));
        }

        public Pracownik(string imie, string nazwisko, int podstawa, int staz) : base(imie, nazwisko, podstawa) // konstruktor parametryczny, podpunkt 2c)
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            base.podstawa = podstawa;
            this.staz = staz;

        }

        public override string ToString() //przesloniecie metody, podpunkt 2d)
        {
            return "Pracownik: " + imie + " " + nazwisko + " , podstawa: " + podstawa + " , staz:" + staz;
        }
    }
}
