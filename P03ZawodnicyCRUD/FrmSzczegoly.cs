using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ZawodnicyCRUD
{

    public enum TrybOkna
    {
        Dodawanie,
        Edycja
    }

    public partial class FrmSzczegoly : Form
    {
        ManagerZawodnikow mz;
        TrybOkna trybOkna;
        Zawodnik zawodnik;
        public FrmSzczegoly(TrybOkna trybOkna, ManagerZawodnikow mz)
        {
            this.mz = mz;
            InitializeComponent();
        }


        public FrmSzczegoly(TrybOkna trybOkna, Zawodnik zawodnik)
        {
            InitializeComponent();

            this.trybOkna = trybOkna;
            this.zawodnik = zawodnik;
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (trybOkna == TrybOkna.Dodawanie)
            {
                DodajZawodnika();
            }
            else if (trybOkna == TrybOkna.Edycja)
            {
                EdytujZawodnika();
            }


        }

        private void EdytujZawodnika()
        {
            zczytajDaneZFormularza(zawodnik);

        }

        private void DodajZawodnika()
        {
            Zawodnik zawodnik = new Zawodnik();
            zczytajDaneZFormularza(zawodnik);
            mz.Dodaj(zawodnik);
        }

        private void zczytajDaneZFormularza(Zawodnik zawodnik)
        {
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUrodzenia = dtpDataUr.Value;
            zawodnik.Wzrost = (int)numWzrost.Value;
            zawodnik.Waga = (int)numWaga.Value;
        }
    }
}
