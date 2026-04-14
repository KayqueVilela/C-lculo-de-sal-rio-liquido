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
    public partial class exercicio20 : Form
    {
        public exercicio20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matric;
            matric = int.Parse(textBox1.Text);
            int ano = matric / 100000;
            int semestre = (matric / 10000) % 10;
            label3.Text = "Ano de matrícula: " + ano + Environment.NewLine+"\nSemestre de matrícula: " + semestre+ "º";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
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
