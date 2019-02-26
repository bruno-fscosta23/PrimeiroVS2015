using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmTesteVariavel : Form
    {
        bool bandeira = false;
                       
        public frmTesteVariavel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = "Turma TI92";
            lblSair.Text = "Senac Lago Treze";
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbandeira_Click(object sender, EventArgs e)
        {
            bandeira = true;
            lblbandeira.Text = bandeira.ToString();
        }

        private void btntrocar_Click(object sender, EventArgs e)
        {
            bandeira = false;
            lblbandeira.Text = bandeira.ToString();
            lblMostrar.Text = "";
            lblSair.Text = "";
            lblAparecer.Text = "1";
        }
    }
}
