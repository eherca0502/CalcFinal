using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string opcion;
        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (Operacion.numero1 == -1)
            {
                Operacion.numero1 = double.Parse(txtPantalla.Text);
                opcion = "Suma";
                txtPantalla.Clear();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (Operacion.numero1 == -1)
            {
                Operacion.numero1 = double.Parse(txtPantalla.Text);
                opcion = "Resta";
                txtPantalla.Clear();
            }

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (Operacion.numero1 == -1)
            {
                Operacion.numero1 = double.Parse(txtPantalla.Text);
                opcion = "Multiplicacion";
                txtPantalla.Clear();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (Operacion.numero1 == -1)
            {
                Operacion.numero1 = double.Parse(txtPantalla.Text);
                opcion = "Division";
                txtPantalla.Clear();
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (Operacion.numero1 != -1)
            {
                if (Operacion.numero2 == -1)
                {
                    Operacion.numero2 = double.Parse(txtPantalla.Text);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

            switch (opcion)
            {
                case "Suma":
                    Suma operacion = new Suma();
                    double resultado = operacion.Calcular();
                    txtPantalla.Text = resultado.ToString();
                    break;

                case "Resta":
                    Resta operacion1 = new Resta();
                    double resultado1 = operacion1.Calcular();
                    txtPantalla.Text = resultado1.ToString();
                    break;
                case "Multiplicacion":
                    Multiplicacion operacion2 = new Multiplicacion();
                    double resultado2=operacion2.Calcular();
                    txtPantalla.Text= resultado2.ToString();
                    break;
                case "Division":
                    Division operacion3 = new Division();
                    double resultado3=operacion3.Calcular();
                    txtPantalla.Text = resultado3.ToString();
                    break;
                default:
                    break;

            }

            Operacion.numero1 = -1;
            Operacion.numero2 = -1;
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCalculadora_Click(object sender, EventArgs e)
        {

        }
    }
}