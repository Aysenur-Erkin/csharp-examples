using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş_İndirim_Tutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double tutar;
            adet = Convert.ToInt32(textBox1.Text);
            if(adet >= 0 && adet <= 20)
            {
                tutar = (adet * 8)-(adet * 8) * 0.20;
            }
            else if(adet >= 21 && adet <= 40){
                tutar = (adet * 8) - (adet * 8) * 0.40;
            }
            else {
                tutar = (adet * 8) - (adet * 8) * 0.50;
            }
            label3.Text = tutar.ToString("0.00") + " TL";
        }
    }
}
