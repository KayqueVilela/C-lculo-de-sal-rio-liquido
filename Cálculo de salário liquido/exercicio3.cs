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
    public partial class exercicio3 : Form
    {
        public exercicio3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float htrab;
            htrab = float.Parse(textBox1.Text);
            float valh;
            valh = float.Parse(textBox2.Text);
            float perc;
            perc = float.Parse(textBox3.Text);
            float result1;
            result1 = htrab*valh;
            label9.Text = "" +result1;

            float result2;
            result2 = (perc / 100f) * result1;
            label11.Text = ""+result2;

            float result3;
            result3 = result1 - result2;
            label10.Text =""+result3 ;


        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
