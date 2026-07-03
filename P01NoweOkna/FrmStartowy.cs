using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01NoweOkna
{
    public partial class FrmStartowy : Form
    {
        FrmNoweOkno frmNoweOkno;
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnNoweOkno_Click(object sender, EventArgs e)
        {
            frmNoweOkno = new FrmNoweOkno();
            
            frmNoweOkno.Show();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            // tego zrobić nie mogę bo jest tylko GET
           // frmNoweOkno.TxtNoweOknoWiadomosc = new TextBox();

          //  frmNoweOkno.TxtNoweOknoWiadomosc.Text = txtWiadomosc.Text;
            TextBox t1 = frmNoweOkno.TxtNoweOknoWiadomosc; 
            t1.Text = txtWiadomosc.Text;
        }
    }
}
