using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula04
{
    public partial class Exercicio : Form
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            double num1, num2, sub;
            num1 = Convert.ToDouble(txtAnoAtual.Text);
            num2 = Convert.ToDouble(txtAnoNasc.Text);
            sub = num1 - num2;

            lblIdade.Text = String.Format("{0}", sub);     
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double raio,area;
            raio = Convert.ToDouble(txtValor.Text);
            area = Convert.ToDouble(txtValor.Text);
            area = 3.14 * raio * raio;

            lblAreaResut.Text = string.Format("{0}", area); 
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double A, B, C, delta, Rdelta, x1, x2;
            A = Convert.ToDouble(txtA.Text);
            B = Convert.ToDouble(txtB.Text);
            C = Convert.ToDouble(txtC.Text);
            delta = B * B - 4 * A * C;
            Rdelta = Math.Sqrt(delta);
            x1 = (-B + Rdelta) / 2 * A;
            x2 = (-B - Rdelta) / 2 * A;

            lblRescX1.Text = string.Format("{0}", x1);
            lblRescX2.Text = string.Format("{0}", x2);

        }
    }
}
