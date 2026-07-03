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
    public partial class FrmStartowy : Form
    {
        ManagerZawodnikow mz;
        public FrmStartowy()
        {

            InitializeComponent();

            mz = new ManagerZawodnikow();
            
            lbDane.DataSource = 
                mz.WczytajZawodnikow(@"C:\dane\Zawodnicy.txt");
           
            cbKraje.DataSource = mz.PodajKraje();

        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(zawodnik);
            frmSzczegoly.Show();
        }



        private void cbKraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczonyKraj = (string)cbKraje.SelectedItem;

            lbDane.DataSource = mz.PodajZawodnikow(zaznaczonyKraj);
            lbDane.DisplayMember = "ImieNazwisko";
        }
    }
}
