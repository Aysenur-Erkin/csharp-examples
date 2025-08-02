using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_Proje_Uçak_Bilet_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + " - " + comboBox2.Text + "  " + "Tarih:" + dateTimePicker1.Text + "  " + "Saat:" + maskedTextBox1.Text + "  " + "Yolcu Bilgileri ~ Ad-Soyad:" + textBox1.Text + "  " + "TC Kimlik No:" + maskedTextBox3.Text + "  " + "Telefon Numarası:" + maskedTextBox2.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label8.Text;

        }
    }
}
