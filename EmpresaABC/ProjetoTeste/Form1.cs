using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {

            String valor = "";
            int num = 0;

            if (txtEscolha.Text.Equals(""))
            {
                MessageBox.Show("Você tem que escolher um Número");
            }else 
            {
                switch (Convert.ToInt32(txtEscolha.Text))
                {
                    case 1:
                        valor = "1";
                        num = 1;
                        break;
                    case 2:
                        valor = "2";
                        num = 2;
                        break;
                    case 3:
                        valor = "3";
                        num = 3;
                        break;
                    case 4:
                        valor = "4";
                        num = 4;
                        break;
                    case 5:
                        valor = "5";
                        num = 5;
                        break;

                    default:
                        MessageBox.Show("Escolha um item de 1 a 5");
                        break;

                }
                
                if ((num > 0) && (num <= 5))
                {
                    MessageBox.Show("Escolheu o item " + valor);
                    txtEscolha.Focus();
                    txtEscolha.Clear();

                }
                else
                {
                    txtEscolha.Focus();
                    txtEscolha.Clear();

                }
            }
                                                
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            double resp = 0, v1 = 20, v2 = 30;
            resp = v1 + v2;

            DialogResult messagem = MessageBox.Show("A soma de a+b = " + resp + " tudo bem.", " Escolha valor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

            if (messagem == DialogResult.Yes)
            {
                MessageBox.Show("Você clicou no sim");
            }
            if (messagem == DialogResult.No)
            {
                MessageBox.Show("Você clicou no não");
            }
            if (messagem == DialogResult.Cancel)
            {
                MessageBox.Show("Você clicou no Cancelar");
            }
        }
        public void Nome()
        {
            string nome = "Senac";

            if (txtNome.Text.Equals(nome))
            {
                MessageBox.Show("Olá, seja bem vindo!!", "Tudo Bem.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Favor enserir nome correto!!");
            }
        }


        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Nome();
            } 
        }
    }
}
