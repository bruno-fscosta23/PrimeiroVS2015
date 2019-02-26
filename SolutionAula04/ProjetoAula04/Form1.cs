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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            bool logica = true;
            int num = 45;
            float nreal = 3.75f;
            //Para f ligar o float
            double nreal2 = 17.999d;
            //Para d ligar o double
            decimal salario = 900.99m;
            
            label1.Text = "Valor lógico: " + logica.ToString();
            //"\n" é para pular linha.
            label1.Text += "\n";
            label1.Text += "Valor Inteiro: " + num.ToString();
            //label1.Text += "\nValoresReais: " + nreal.ToString() + ", " + nreal2.ToString() + " e " + salario.ToString();
            label1.Text += String.Format("\nValores reais: {0}, {1} e {2:c} ", nreal, nreal2, salario);                         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, soma;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            soma = num1 + num2;
            
            label2.Text = String.Format("{0} + {1} = {2}", num1, num2, soma);
            
               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, Subtrai;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            Subtrai = num1 + num2;

            label2.Text = String.Format("{0} - {1} = {2}", num1, num2, Subtrai);
        }
    }
}
