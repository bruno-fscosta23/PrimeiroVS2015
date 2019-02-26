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
    public partial class Imagem : Form
    {
        public Imagem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double soma;
            soma = Convert.ToDouble(label1.Text);
            label1.Text = string.Format("{0}", soma + 1);

            pictureBox1.Width += +7;
            pictureBox1.Height += +7;           
                             
                           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += -7;
            pictureBox1.Height += -7;
        }
    }
}
