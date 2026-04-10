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
    public partial class exercicio6 : Form
    {
        public exercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio;
            raio = double.Parse(textBox1.Text);
            double altura;
            altura = double.Parse(textBox2.Text);
            double pi = Math.PI;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
