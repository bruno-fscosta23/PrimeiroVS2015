using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistenge
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblEsqueceu_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string nome = "admim";
            string senha = "admin";
            
            if (txtLogin.Text.Equals(nome))
            {
                if (txtSenha.Text.Equals(senha))
                {

                }
            }
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
