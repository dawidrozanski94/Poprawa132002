using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa132002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> pracownicy = new List<Osoba>();
            pracownicy.Add(new Pracownik("Jan", "Kowalski", 2000, 7));
            pracownicy.Add(new Pracownik("Robert", "Nowak", 3000, 5));
            pracownicy.Add(new Pracownik("Pawel", "Kwiatkowski", 4000, 7));
            pracownicy.Add(new Pracownik("Katarzyna", "Zak", 3000, 11));
            pracownicy.Add(new Pracownik("Milosz", "Polak", 2500, 3));
            pracownicy.Add(new Pracownik("Alicja", "Kwiatkowska", 2000, 7));
            pracownicy.Add(new Pracownik("Norman", "Kowalski", 2000, 7));
            pracownicy.Add(new Kierownik("Roman", "Grabowski", 6000, 20));
            pracownicy.Add(new Kierownik("Dawid", "Kolos", 4000, 11));
            pracownicy.Add(new Kierownik("Jan", "Kot", 5000, 12));

            foreach(Osoba o in pracownicy)
            {
                o.ObliczPensje();
            }

            ObliczPensje();

            Console.ReadKey();
        }
    }
}
