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
    public partial class exercicio15 : Form
    {
        public exercicio15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numa;
            int numb;
            numa = int.Parse(textBox1.Text);
            numb = int.Parse(textBox2.Text);
            label4.Text = "O primeiro valor é: "+numb+Environment.NewLine+" e o segundo valor é: "+numa;

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
