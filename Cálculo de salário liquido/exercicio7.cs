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
    public partial class exercicio7 : Form
    {
        public exercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float tempo;
            tempo = float.Parse(textBox1.Text);
            float velocidade;
            velocidade = float.Parse(textBox2.Text);
            float distancia;
            distancia = tempo * velocidade;
            float litros_usados;
            litros_usados = distancia / 12;
            label4.Text = ""+litros_usados;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
