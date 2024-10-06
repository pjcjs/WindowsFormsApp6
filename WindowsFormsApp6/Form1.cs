using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Combobox'a araçları yazdıralım
            comboBox1.Items.Add("Motosiklet");
            comboBox1.Items.Add("Otomobil");
            comboBox1.Items.Add("Minibüs");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3 seçenek olacak combobox'ta. Motosiklet, otomobil ve minibüs.
            // Her biri için ayrı ayrı fiyatlar olacak.
            // Saat seçeceğiz textbox'tan.
            // Hesapla butonuna basınca fiyatı hesaplayacak.

            // Motosiklet: Saati 10 TL. 2. saatten sonra 12 TL her saati.
            // Otomobil: Saati 15 TL. 2. saatten sonra 17,25 TL her saati.
            // Minibüs: Saati 20 TL. 2. saatten sonra 26 TL her saati.

            if (comboBox1.SelectedItem == "Motosiklet")
            {
                int saat = Convert.ToInt32(textBox1.Text);
                if (saat == 1)
                {
                    MessageBox.Show("10 TL");
                }
                else
                {
                    MessageBox.Show((10 + (saat - 1) * 12).ToString() + " TL");
                }
            }
            else if (comboBox1.SelectedItem == "Otomobil")
            {
                int saat = Convert.ToInt32(textBox1.Text);
                if (saat == 1)
                {
                    MessageBox.Show("15 TL");
                }
                else
                {
                    MessageBox.Show((15 + (saat - 1) * 17.25).ToString() + " TL");
                }
            }
            else if (comboBox1.SelectedItem == "Minibüs")
            {
                int saat = Convert.ToInt32(textBox1.Text);
                if (saat == 1)
                {
                    MessageBox.Show("20 TL");
                }
                else
                {
                    MessageBox.Show((20 + (saat - 1) * 26).ToString() + " TL");
                }
            }
        }
    }
}