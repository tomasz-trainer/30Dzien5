using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08SlowoStatic
{
    class Zawodnik
    {
        public string Imie { get; set; }

        public static string Nazwisko { get; set; }

        public string PrzedstawSie()
        {
            return $"Nazywam sie {Imie} {Nazwisko}";
        }


        public static void PowiedzKimJest()
        {
            Console.WriteLine($"Jestem {Nazwisko}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z = new Zawodnik();
            z.Imie = "Jan";
            //  z.Nazwisko = "Kowalski";
            
            Zawodnik z2 = new Zawodnik();
            z2.Imie = "Adam";
            //  z2.Nazwisko = "Nowak";

            Zawodnik.Nazwisko = "Kowlaski"; // ustawienie nazwiska dla wszystkich zawodników

            Console.WriteLine(z.PrzedstawSie());

            Zawodnik.PowiedzKimJest();
        }
    }
}
