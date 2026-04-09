using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_de_salário_liquido
{
    public partial class exercicio9 : Form
    {
        public exercicio9()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a; 
            a = float.Parse(textBox1.Text);
            float b;
            b = float.Parse(textBox2.Text);
            float c;
            c = float.Parse(textBox3.Text);
            float d;
            d = float.Parse(textBox4.Text);
            float aba = a + b;
            float abm = a * b;
            float aca = a + c;
            float acm = a * c;
            float ada = a + d;
            float adm = a * d;
            float bca = b + c;
            float bcm = b * c;
            float bda = b + d;
            float bdm = b * d;
            float cda = c + d;
            float cdm = c * d;
            label6.Text = "                                                                              " +"ADIÇÃO:" + aba +" " + "MULTIPLICAÇÃO: " +abm;
            label7.Text = "                                                                              " + "ADIÇÃO:" + aca + " " + "MULTIPLICAÇÃO: " + acm;
            label8.Text = "                                                                              " + "ADIÇÃO:" + ada + " " + "MULTIPLICAÇÃO: " + adm;
            label9.Text = "                                                                              " + "ADIÇÃO:" + bca + " " + "MULTIPLICAÇÃO: " + bcm;
            label10.Text = "                                                                              " + "ADIÇÃO:" + bda + " " + "MULTIPLICAÇÃO: " + bdm;
            label17.Text = "                                                                              " + "ADIÇÃO:" + cda + " " + "MULTIPLICAÇÃO: " + cdm;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label17.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
