using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaDePagamento
{
    public partial class frmFolhaDePagamento : Form
    {
        public frmFolhaDePagamento()
        {
            InitializeComponent();
            carregaclubes();
        }

        private void cboCLube_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carregaclubes();
        }
        private void carregaclubes()
        {
            cboCLube.Items.Clear();

            cboCLube.Items.Add("Clube A - R$100,00");
            cboCLube.Items.Add("Clube B - R$50,00");
            cboCLube.Items.Add("Clube C - R$10,00");

        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
                  
        {
            txtSalaFolha.Text = txtSalario.Text;
            {
                double sala,desc;
                sala = Convert.ToDouble(txtSalario.Text);
                desc = Convert.ToDouble(txtImpostoRenda.Text);

                if (ckbPlanoSaude.Checked)
                {
                    sala = sala - 150; 
                    txtSalaFolha.Text = String.Format("{0:c}",sala);

                }
                if (cboCLube.SelectedIndex == 0)
                {
                    sala = sala - 100;
                    txtSalaFolha.Text = String.Format("{0:c}", sala);
                }
                if (cboCLube.SelectedIndex == 1)
                {
                    sala = sala - 50;
                    txtSalaFolha.Text = String.Format("{0:c}", sala);
                }
                if (cboCLube.SelectedIndex == 2)
                {
                    sala = sala - 10;
                    txtSalaFolha.Text = String.Format("{0:c}", sala);
                }

                if ((sala >= 1903.98)&&(sala >= 2826.98))
                {
                    txtImpostoRenda.Text = "taxa de 7,5";
                    sala = (sala * 7.5 / 100);
                    desc = desc - sala;
                    txtImpostoRenda.Text = String.Format("{0:c}", sala);
                    txtSalaLiquido.Text = String.Format("{0:c}", desc);
                }
                if ((sala >= 2826.66) && (sala >= 3751.05))
                {
                    txtImpostoRenda.Text = "taxa de 15,0";
                    //sala = ala - (sala * 1.15);
                    desc = desc - sala;
                    txtImpostoRenda.Text = String.Format("{0:c}", sala);
                    txtSalaLiquido.Text = String.Format("{0:c}", desc);
                }
                if ((sala >= 3751.06) && (sala >= 4664.68))
                {
                    txtImpostoRenda.Text = "taxa de 22,5";
                    sala = sala - (sala * 1.225);
                    desc = desc - sala;
                    txtImpostoRenda.Text = String.Format("{0:c}", sala);
                    txtSalaLiquido.Text = String.Format("{0:c}", desc);
                }
                if (sala > 4664.68)
                {
                    txtImpostoRenda.Text = "taxa de 27,5";
                    sala = sala - (sala * 1.275);
                    desc = desc - sala;
                    txtImpostoRenda.Text = String.Format("{0:c}", sala);
                    txtSalaLiquido.Text = String.Format("{0:c}", desc);
                }

            }
                         
        }
              
       
    }
}
