using System.Collections.Generic;
using System;
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
        private double valor1;
        private double valor2;

        private double resultado;


        private int operacion;



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton SUMA
            btnPunto.Enabled = true;
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //numero 2

            tbDisplay.Text = tbDisplay.Text + "2";
        }


        private void button15_Click(object sender, EventArgs e)
        {
            //boton igual
            btnPunto.Enabled = true;
            valor2 = Convert.ToDouble(tbDisplay.Text);


            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Ingrese un valor distinto de cero");
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
            }
            tbDisplay.Text = resultado.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0

            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3

            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4

            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero  "5";

            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6

            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7

            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8

            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numer0 9

            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar
            tbDisplay.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //boton RESTA
            btnPunto.Enabled = true;
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";


        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //boton MULTIPLICACION
            btnPunto.Enabled = true;
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //boton DIVISION
            btnPunto.Enabled = true;
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //boton PUNTO
            tbDisplay.Text = tbDisplay.Text + ",";
            if (tbDisplay.Text == ",")
            {
                MessageBox.Show("Ingrese un numero");
            }
            else
            {
                btnPunto.Enabled = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //boton RAIZ
            valor1 = double.Parse(tbDisplay.Text);
            if (valor1 < 0)
            {
                MessageBox.Show("Ingrese un numero positivo");
            }
            else
            {
                resultado = valor1;
                tbDisplay.Text = Math.Sqrt(valor1).ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //numero al cubo
            valor1 = double.Parse(tbDisplay.Text);
            resultado = valor1;
            tbDisplay.Text = Math.Pow(valor1, 3).ToString();


        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //numero al -1
            valor1 = double.Parse(tbDisplay.Text);
            resultado = valor1;
            tbDisplay.Text = Math.Pow(valor1, -1).ToString();


        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {   //numero al cuadrado
            valor1 = double.Parse(tbDisplay.Text);
            resultado = valor1;
            tbDisplay.Text = Math.Pow(valor1, 2).ToString();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            //diez a la potencia x
            valor1 = double.Parse(tbDisplay.Text);
            resultado = valor1;
            tbDisplay.Text = Math.Pow(10, valor1).ToString();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            //seno del numero
            resultado = valor1;
            tbDisplay.Text = Math.Sin(valor1).ToString();

        }
        private void btnsinh_Click(object sender, EventArgs e)
        {       //Seno hiperbolico de un numero
            resultado = valor1;
            tbDisplay.Text = Math.Sinh(valor1).ToString();
        }



        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            //coseno hiperbolico de un numero
            resultado = valor1;
            tbDisplay.Text = Math.Cosh(valor1).ToString();
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            //coseno del numero
            resultado = valor1;
            tbDisplay.Text = Math.Cos(valor1).ToString();
        }
    }

}