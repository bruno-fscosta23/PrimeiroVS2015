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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            double sal1, num1;
            sal1 = Convert.ToDouble(txtSala.Text);
            num1 = Convert.ToDouble(txtSala.Text);

            num1 = sal1 * 0.05;
            sal1 = num1 + sal1;

            lblResult.Text = String.Format("{0:c}", sal1); 
             
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            double sal2, num2;
            sal2 = Convert.ToDouble(txtSala.Text);
            num2 = Convert.ToDouble(txtSala.Text);

            num2 = sal2 * 0.10;
            sal2 = num2 + sal2;

            lblResult.Text = String.Format("{0:c}", sal2);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            double sal2, num2;
            sal2 = Convert.ToDouble(txtSala.Text);
            num2 = Convert.ToDouble(txtSala.Text);

            num2 = sal2 * 0.15;
            sal2 = num2 + sal2;

            lblResult.Text = String.Format("{0:c}", sal2);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            double sal2, num2;
            sal2 = Convert.ToDouble(txtSala.Text);
            num2 = Convert.ToDouble(txtSala.Text);

            num2 = sal2 * 0.20;
            sal2 = num2 + sal2;

            lblResult.Text = String.Format("{0:c}", sal2);
        }

        private void lblCalculeSala_Click(object sender, EventArgs e)
        {

        }
    }
}
