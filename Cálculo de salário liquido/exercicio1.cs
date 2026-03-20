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
    public partial class exercicio1 : Form
    {
        public exercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float raio;
            raio = float.Parse(textBox1.Text);
            float area;
            double pi = 3.14159;
            area = (float)(pi * raio*2);
            label3.Text = "A área é: "+ area;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Clear();
        }
    }
}
