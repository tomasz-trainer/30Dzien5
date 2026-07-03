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
    public partial class FrmNoweOkno : Form
    {
        public TextBox TxtNoweOknoWiadomosc
        {
            get { return txtNoweOknoWiadomosc; }
        }

           // uzywany kiedy ustawiam te pole 
           //set
           //{

           //}

        public FrmNoweOkno()
        {
            InitializeComponent();
        }
    }
}
