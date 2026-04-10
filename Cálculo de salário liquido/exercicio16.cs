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
    public partial class exercicio16 : Form
    {
        public exercicio16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float vel1;
            vel1 = float.Parse(textBox1.Text);
            float vel2;
            vel2 = vel1 / 3.6f;
            label3.Text = "A velocidade em m/s é: " + vel2;     
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
