using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anket_uygulamasi
{
    public partial class Form2 : Form
    {
        public Form2(string seciliRadioButton, string toplamDeger)
        {
            InitializeComponent();
            label1.Text = seciliRadioButton;
            label2.Text = toplamDeger;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
