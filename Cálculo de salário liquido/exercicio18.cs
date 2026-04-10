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
    public partial class exercicio18 : Form
    {
        public exercicio18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salbruto;
            salbruto = float.Parse(textBox1.Text);
            float desc1 = salbruto * 0.10f;
            float resto = salbruto - desc1;
            float desc2 = resto * 0.05f;
            float salliq = resto - desc2;
            label3.Text = "O salário líquido é: " + salliq; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
