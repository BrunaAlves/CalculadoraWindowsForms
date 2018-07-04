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
    
    public partial class Form1 : Form
    {
        String num1, num2;
        String opera;

        public Form1()
        {
            InitializeComponent();

        }

        public void DigitaNumero(String n1)
        {

            if (num1 != null && opera != null)
            {
                num2 = num2 + n1;
                textBoxResult.Text = num1 + opera + num2;
            }
            else
            {
                num1 = num1 + n1;
                textBoxResult.Text = num1 + opera;
            }
        }

        public void DigitaOperacao(String o)
        {
            opera = o;

            textBoxResult.Text = num1 + o;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DigitaNumero("1");

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DigitaNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DigitaNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DigitaNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DigitaNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DigitaNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DigitaNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DigitaNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DigitaNumero("9");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            DigitaOperacao("/");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            DigitaOperacao("*");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            DigitaOperacao("-");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            DigitaOperacao("+");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (opera == "+")
            {
                double total = double.Parse(num1) + double.Parse(num2);

                textBoxResult.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                opera = "";
            }
            if (opera == "-")
            {
                double total = double.Parse(num1) - double.Parse(num2);

                textBoxResult.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                opera = "";
            }
            if (opera == "/")
            {
                double total = double.Parse(num1) / double.Parse(num2);

                textBoxResult.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                opera = "";
            }
            if (opera == "*")
            {
                double total = double.Parse(num1) * double.Parse(num2);

                textBoxResult.Text = total.ToString();
                num1 = total.ToString();
                num2 = "";
                opera = "";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            opera = "";
            textBoxResult.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            DigitaNumero("0");
        }
    }
}
