using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp=0;

            num1 = Double.Parse(txtVaria1.Text);
            num2 = Double.Parse(txtVaria2.Text);

            resp = num1 + num2;

            lblResult1.Text = resp.ToString();

            if (rdbAdicao.Checked)
            {
                
            }
            
            if (rdbSubtracao.Checked)
            {
                resp = num1 - num2;

                lblResult1.Text = resp.ToString();
            }
            if (rdbMultiplicacao.Checked)
            {
                resp = num1 * num2;

                lblResult1.Text = resp.ToString();
            }
            if (rdbDivisao.Checked)
            {
                resp = num1 / num2;

                lblResult1.Text = resp.ToString();
            }
            if (rdbDivisao.Checked)
            {
                num2 = 0;
                lblResult1.Text = "Não é possivel";
                 
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResult1.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
