using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formCalc : Form
    {
        public formCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if((textValor1.Text == "")|| (textValor2.Text == ""))
            {
                MessageBox.Show("Está faltando um valor para completar a operação");
            }
            else
            {
                valor1 = Convert.ToDouble(textValor1.Text);
                valor2 = Convert.ToDouble(textValor2.Text);
                resultado = valor1 + valor2;
                lblResultado.Text = resultado.ToString();
            }


        }

        private void btSub_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if((textValor1.Text == "") || (textValor2.Text == ""))
            {
                MessageBox.Show("Está faltando um valor para completar a operação");
            }
            else
            {
                valor1 = Convert.ToDouble(textValor1.Text);
                valor2 = Convert.ToDouble(textValor2.Text);
                resultado = valor1 - valor2;
                lblResultado.Text = resultado.ToString();
            }

        }

        private void btMult_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if((textValor1.Text == "") || (textValor2.Text == ""))
            {
                MessageBox.Show("Está faltando um valor para completar a operação");
            }
            else
            {
                valor1 = Convert.ToDouble(textValor1.Text);
                valor2 = Convert.ToDouble(textValor2.Text);
                resultado = valor1 * valor2;
                lblResultado.Text = resultado.ToString();
            }

        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if((textValor1.Text == "") || (textValor2.Text == ""))
            {
                MessageBox.Show("Está faltando um valor para completar a operação");
            }
            else
            {
                valor1 = Convert.ToDouble(textValor1.Text);
                valor2 = Convert.ToDouble(textValor2.Text);
                resultado = valor1 / valor2;
                lblResultado.Text = resultado.ToString();
            }

        }

        private void number1_Click(object sender, EventArgs e)
        {
            textValor1.Text = "1";

        }

        private void number2_Click(object sender, EventArgs e)
        {
            textValor1.Text = "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            textValor1.Text = "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textValor1.Text = "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textValor1.Text = "5";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textValor1.Text = "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textValor1.Text = "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textValor1.Text = "8";

        }

        private void number9_Click(object sender, EventArgs e)
        {
            textValor1.Text = "9";
        }

        private void clean_Click(object sender, EventArgs e)
        {
            textValor1.Text = "";
        }
    }
}
