using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anket_uygulamasi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seciliRadioButton = "";

            // RadioButton'ların kontrolü
            if (radioButton51.Checked)
            {
                seciliRadioButton = radioButton51.Text;
            }
            else if (radioButton52.Checked)
            {
                seciliRadioButton = radioButton52.Text;
            }
            else if (radioButton53.Checked)
            {
                seciliRadioButton = radioButton53.Text;
            }

            // Seçilen bir RadioButton varsa devam et, yoksa uyarı ver ve işlemi sonlandır
            if (!string.IsNullOrEmpty(seciliRadioButton))
            {
                int hesaplananPuan = HesaplaPuan();

                // Tüm panellerde en az bir RadioButton seçilmişse Form2'yi aç
                if (hesaplananPuan != 0)
                {
                    Form2 form2 = new Form2(seciliRadioButton, hesaplananPuan.ToString());
                    form2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lütfen yaşını seçiniz.");
                return;
            }
        }

        // Panel içindeki RadioButton'ları kontrol eden fonksiyon
        private int HesaplaPuan()
        {
            int toplamPuan = 0;

            // 10 panel için döngü
            for (int i = 1; i <= 10; i++)
            {
                Panel panelSecenekler = this.Controls.Find($"panel{i}", true).FirstOrDefault() as Panel;

                if (panelSecenekler != null)
                {
                    bool enAzBirSecili = false; // Her panelde en az bir RadioButton seçildi mi?

                    // Panel içindeki RadioButton'ları kontrol et
                    foreach (RadioButton radioButton in panelSecenekler.Controls.OfType<RadioButton>())
                    {
                        if (radioButton.Checked)
                        {
                            int secilenPuan = int.Parse(radioButton.Text);
                            toplamPuan += secilenPuan;
                            enAzBirSecili = true;
                            break; // Seçilen bir RadioButton bulunduğunda döngüden çık
                        }
                    }

                    // Her panel için doğrulama yapın
                    if (!enAzBirSecili)
                    {
                        MessageBox.Show($"Lütfen {i}. soru için bir seçenek seçin.");
                        return 0; // Herhangi bir panelde seçili bir RadioButton yoksa toplam puanı sıfırlayın
                    }
                }
            }

            return toplamPuan;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
