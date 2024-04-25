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

            if (!string.IsNullOrEmpty(seciliRadioButton))
            {
                Form2 form2 = new Form2(seciliRadioButton);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
