using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            int f, v, t;
            ad = comboBox1.Text;
            f = Convert.ToInt32(maskedTextBox1.Text);
            v = (f * 18 / 100);
            t = (f - v);
            label5.Text = v.ToString();
            listBox1.Items.Add("Cihaz: " + ad + " " + "Tutar: " + f);
            MessageBox.Show("Sepete eklendi!", "BİLGİLENDİRME");
        }

        //INSTAGRAM ==>> samet_altundag63
        //INSTAGRAM ==>> samethecode
    }
}
