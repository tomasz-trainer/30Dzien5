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

        public FrmStartowy()
        {

            InitializeComponent();

            ManagerZawodnikow mz = new ManagerZawodnikow();
            
            lbDane.DataSource = 
                mz.WczytajZawodnikow(@"C:\dane\Zawodnicy.txt");
            lbDane.DisplayMember = "ImieNazwisko";


        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(zawodnik);
            frmSzczegoly.Show();
        }
    }
}
