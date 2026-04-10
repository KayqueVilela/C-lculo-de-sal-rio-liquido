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
    public partial class exercicio13 : Form
    {
        public exercicio13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);
            int b;
            b = int.Parse(textBox2.Text);
            int res1 = a * a;
            int res2 = b * b;   
            label4.Text = "O resultado do Quadrado do primeiro valor lido é: " + res1 +Environment.NewLine + "O resultado do Quadrado do segundo valor lido é: " + res2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Clear();
            label4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
