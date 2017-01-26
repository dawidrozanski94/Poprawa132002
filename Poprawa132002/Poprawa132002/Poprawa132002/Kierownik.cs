using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
     class Kierownik : Osoba
    {
        private int iloscPodwladnych;

        public virtual int ObliczPensje()
        {
            return base.ObliczPensje() + this.iloscPodwladnych * 7; // przesloniecie metody, podpunkt 3b)
        }

        public Kierownik(string imie, string nazwisko, int podstawa, int iloscPodwladnych) : base(imie, nazwisko, podstawa) // konstruktor, podpunkt 3c)
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            base.podstawa = podstawa;
            this.iloscPodwladnych = iloscPodwladnych;
        }

        public override string ToString() //przesloniecie metody, podpunkt 3d
        {
            return "Kierownik: " + imie + " " + nazwisko + " , podstawa: " + podstawa + " , ilosc podwladnych:" + iloscPodwladnych;
        }
    }
} 
