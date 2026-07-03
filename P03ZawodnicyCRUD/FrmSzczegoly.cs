using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02ZawodnicyNoweOkna
{
    public partial class FrmSzczegoly : Form
    {
        ManagerZawodnikow mz;
        public FrmSzczegoly(ManagerZawodnikow mz)
        {
            this.mz = mz;
            InitializeComponent();
        }


        public FrmSzczegoly(Zawodnik zawodnik)
        {
            InitializeComponent();

            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKraj.Text = zawodnik.Kraj;
            dtpDataUr.Value = zawodnik.DataUrodzenia;
            numWzrost.Value = zawodnik.Wzrost;
            numWaga.Value = zawodnik.Waga;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = new Zawodnik
            {
                Imie = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                Kraj = txtKraj.Text,
                DataUrodzenia = dtpDataUr.Value,
                Wzrost = (int)numWzrost.Value,
                Waga = (int)numWaga.Value
            };
             
            mz.Dodaj(zawodnik);
        }
    }
}
