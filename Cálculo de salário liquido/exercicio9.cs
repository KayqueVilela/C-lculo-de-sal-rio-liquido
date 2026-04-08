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
            label6.Text = +Environment.NewLine +"ADIÇÃO:" + aba +" " + "MULTIPLICAÇÃO: " +abm;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
