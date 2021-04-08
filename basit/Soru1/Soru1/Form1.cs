using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "0";
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("30");
            comboBox1.Items.Add("40");
            comboBox1.Items.Add("50");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesapla hesap = new Hesapla();
            hesap.vizeYuzde = int.Parse(comboBox1.Text);
            hesap.vize = int.Parse(textBox1.Text);
            hesap.final = int.Parse(textBox2.Text);

            textBox3.Text = hesap.BasariAl().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
