using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int penambahan(int nomor1, int nomor2)
        {
            return nomor1 + nomor2;
        }
        public int pengurangan(int nomor1, int nomor2)
        {
            return nomor1 - nomor2;
        }
        public int perkalian(int nomor1, int nomor2)
        {
            return nomor1 * nomor2;
        }
        public int pembagian(int nomor1, int nomor2)
        {
            return nomor1 / nomor2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nomor1 = Convert.ToInt32(textBox1.Text);
            int nomor2 = Convert.ToInt32(textBox2.Text);

            if (comboBox1.Text == "Penambahan")
            {
                textBox3.Text = penambahan(nomor1, nomor2).ToString();
            }
            else if (comboBox1.Text == "Pengurangan")
            {
                textBox3.Text = pengurangan(nomor1, nomor2).ToString();
            }
            else if (comboBox1.Text == "Perkalian")
            {
                textBox3.Text = perkalian(nomor1, nomor2).ToString();
            }
            else if (comboBox1.Text == "Pembagian")
            {
                textBox3.Text = pembagian(nomor1, nomor2).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
