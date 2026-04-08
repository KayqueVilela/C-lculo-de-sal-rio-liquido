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
    public partial class exercicio21 : Form
    {
        public exercicio21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome;
            nome = textBox1.Text;
            String sobrenome;
            sobrenome = textBox2.Text;
            label4.Text = "SEU NOME COMPLETO É: " + nome + " "+sobrenome;
        }
    }
}
