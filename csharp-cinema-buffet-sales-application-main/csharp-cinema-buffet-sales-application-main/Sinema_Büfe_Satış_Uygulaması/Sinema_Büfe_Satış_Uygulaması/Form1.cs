using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, bilet, su, cay, toplam;
            mısır = Convert.ToInt32(TxtMısır.Text);
            bilet = Convert.ToInt32(TxtBilet.Text);
            su = Convert.ToInt32(TxtSu.Text);
            cay = Convert.ToInt32(TxtCay.Text);
            toplam = (mısır * 4) + (bilet*8) + (su*1) + (cay*2);
            LblToplam.Text = toplam.ToString() + "TL" ;
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = " ";
            TxtCay.Text = " ";
            TxtMısır.Text = " ";
            TxtSu.Text = " ";
            TxtMısır.Focus();
        }
    }
}
