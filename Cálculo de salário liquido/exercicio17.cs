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
    public partial class exercicio17 : Form
    {
        public exercicio17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            float quo = a / b;
            float rest = a % b;
            label4.Text = "O resultado da divisão é: " + quo + Environment.NewLine + " O resultado do resto é: " + rest;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
