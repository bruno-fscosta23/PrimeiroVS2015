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
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
            carregaCombo();
            carregaLista();
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
           //carregaCombo();
        }
                
        private void btnCarregaEstados_Click(object sender, EventArgs e)
        {
            carregaCombo();
        }

        private void cboEstados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //carregaCombo();
        }

        private void cboEstados_MouseClick(object sender, MouseEventArgs e)
        {
            //carregaCombo();
        }
        public void carregaCombo()
        {
            cboEstados.Items.Clear();

            cboEstados.Items.Add("São Paulo");
            cboEstados.Items.Add("Bahia");
            cboEstados.Items.Add("Ceara");
            cboEstados.Items.Add("Pernambuco");
            cboEstados.Items.Add("Sergipe");
            cboEstados.Items.Add("Manaus");
            cboEstados.Items.Add("Acre");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cboEstados.Items.Clear();
        }

               
        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            ltbLista.Items.Clear();
        }
        public void carregaLista()
        {
            ltbLista.Items.Clear();

            ltbLista.Items.Add("São Paulo");
            ltbLista.Items.Add("Bahia");
            ltbLista.Items.Add("Ceara");
            ltbLista.Items.Add("Pernambuco");
            ltbLista.Items.Add("Sergipe");
            ltbLista.Items.Add("Manaus");
            ltbLista.Items.Add("Acre");
        }

        private void btnCarregaLabel_Click(object sender, EventArgs e)
        {
            //lblCarregarLabel.Text = cboEstados.SelectedItem.ToString();
            
        }

        
        private void btnLista_Click_1(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void ltbLista_MouseClick(object sender, EventArgs e)
        {
            lblLista.Text = ltbLista.SelectedItem.ToString();
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarregarLabel.Text = cboEstados.SelectedItem.ToString();
            ltbLista.SelectedIndex = cboEstados.SelectedIndex;
        }
        
        private void ltbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLista.Text = ltbLista.SelectedItem.ToString();
            cboEstados.SelectedIndex = ltbLista.SelectedIndex;
        }

        private void lblEstados_Click(object sender, EventArgs e)
        {

        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = "Feminino";
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            lblRetorno.Text = "Masculino";
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("Você escolheu Masculino");
            }
            if (rdbFeminino.Checked)
            {
                MessageBox.Show("Você escolheu Feminino");
            }
        }
    }
}
