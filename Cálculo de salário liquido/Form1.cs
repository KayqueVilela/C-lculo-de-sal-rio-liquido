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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float htrab;
            htrab = int.Parse(textBox1.Text);
            int valh;
            valh = int.Parse(textBox2.Text);
            int perc;
            perc = int.Parse(textBox3.Text);
            float result1;
            result1 = htrab*valh;
            label9.Text = "" +result1;
            float result2;
            result2 = perc / 100 * result1;
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
    }
}
