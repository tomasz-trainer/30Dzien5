using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZawodnicyNoweOkna
{
    internal class ManagerZawodnikow
    {
        private Zawodnik[] zawodnicyCache;


        public Zawodnik[] WczytajZawodnikow(string sciezka)
        {

            //string[] wiersze = File.ReadAllText(sciezka).Split(new string[1] {"\r\n"},StringSplitOptions.RemoveEmptyEntries);
            string[] wiersze =  File.ReadAllLines(sciezka);

            Zawodnik[] zawodnicy = new Zawodnik[wiersze.Length-1];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki =  wiersze[i].Split(',');

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = int.Parse(komorki[0]);
                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = int.Parse(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = DateTime.Parse(komorki[5]);
                z.Wzrost = int.Parse(komorki[6]);
                z.Waga = int.Parse(komorki[7]);

                zawodnicy[i - 1] = z;

            }
            zawodnicyCache = zawodnicy;
            return zawodnicy;
        }

        public Zawodnik[] PodajZawodnikow(string kraj)
        {
            if (zawodnicyCache == null)
                throw new Exception("Najpierw wczytaj zawodnikow");

            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            foreach (var z in zawodnicyCache)
                if (z.Kraj == kraj)
                    zawodnicy.Add(z);

            return zawodnicy.ToArray();
        }


        public string[] PodajKraje()
        {
            // unikam ponownego wczytania danych dzieki zastosowaniu cache'u
            // Zawodnik[] zawodnicy = WczytajZawodnikow();

            if (zawodnicyCache == null)
                throw new Exception("Najpierw wczytaj zawodnikow");

            HashSet<string> kraje = new HashSet<string>();
            foreach (var z in zawodnicyCache)
                kraje.Add(z.Kraj);

            // konwersja HashSet do list aby móc sortować
            List<string> posortowaneKraje = kraje.ToList();
            posortowaneKraje.Sort(); // sortowanie alfabetycznie 
                                     //posortowaneKraje.Reverse(); // ewentualnie mozna odwrócić kolekność

            return posortowaneKraje.ToArray();
        }


        public double PodajSredniWzrost(string kraj)
        {
            Zawodnik[] zawodnicy = PodajZawodnikow(kraj);
            double suma = 0;
            foreach (var z in zawodnicy)
                suma += z.Wzrost;

            return suma / zawodnicy.Length;
        }

        //sortowanie bąbelkowe (ang. Bubble Sort).
        public void PosorotujZawodnikowPoNazwisku(Zawodnik[] posortowaniZawodnicy)
        {
            for (int i = 0; i < posortowaniZawodnicy.Length - 1; i++)
            {
                for (int j = 0; j < posortowaniZawodnicy.Length - i - 1; j++)
                {
                    if (string.Compare(posortowaniZawodnicy[j].Nazwisko, posortowaniZawodnicy[j + 1].Nazwisko) > 0)
                    {
                        // zamiana miejscami 
                        Zawodnik temp = posortowaniZawodnicy[j];
                        posortowaniZawodnicy[j] = posortowaniZawodnicy[j + 1];
                        posortowaniZawodnicy[j + 1] = temp;
                    }
                }
            }
        }
    }
}
