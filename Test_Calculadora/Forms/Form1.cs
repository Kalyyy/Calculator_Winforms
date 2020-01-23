using Clases;
using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class formCalculadora : Form
    {
        public formCalculadora()
        {
            InitializeComponent();
        }
        /*Operaciones codigo reutilizable // Operations with reusable code*/
        Operaciones llamar = new Operaciones();
        public void HacerOperaciones()
        {
            switch (llamar.Operador)
            {
                case "+":
                    Double sum;
                    llamar.SegundoNumero = Convert.ToDouble(txtNumeros.Text);
                    sum = llamar.Sumar((llamar.PrimerNumero), (llamar.SegundoNumero));
                    txtOperaciones.Text = Convert.ToString(sum);
                    txtNumeros.Clear();
                    llamar.PrimerNumero = sum;
                    break;
                case "-":
                    Double subtract;
                    llamar.SegundoNumero = Convert.ToDouble(txtNumeros.Text);
                    subtract = llamar.Restar((llamar.PrimerNumero), (llamar.SegundoNumero));
                    txtOperaciones.Text = Convert.ToString(subtract);
                    txtNumeros.Clear();
                    llamar.PrimerNumero = subtract;
                    break;

                case "*":
                    Double multiplication;
                    llamar.SegundoNumero = Convert.ToDouble(txtNumeros.Text);
                    multiplication = llamar.Multiplicar((llamar.PrimerNumero), (llamar.SegundoNumero));
                    txtOperaciones.Text = Convert.ToString(multiplication);
                    txtNumeros.Clear();
                    llamar.PrimerNumero = multiplication;
                    break;

                case "/":
                    Double division;
                    llamar.SegundoNumero = Convert.ToDouble(txtNumeros.Text);
                    division = llamar.Dividir((llamar.PrimerNumero), (llamar.SegundoNumero));
                    txtOperaciones.Text = Convert.ToString(division);
                    txtNumeros.Clear();
                    llamar.PrimerNumero = division;
                    break;
                default:
                    break;
            }
        }
        /*Botones en windows forms // Buttons on Windows Forms*/
        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "0";
        }
        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "1";
        }
        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "2";
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "3";
        }
        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "4";
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "5";
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "6";
        }
        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "7";
        }
        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "8";
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + "9";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
            txtOperaciones.Clear();
            llamar.PrimerNumero = 0;
            llamar.SegundoNumero = 0;
            llamar.Operador = "";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = txtNumeros.Text + ".";
        }
        /*Botones de los operadores // buttons of operators*/
        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                MessageBox.Show("Campo vacio");
            }

            else if (llamar.PrimerNumero == 0)
            {
                txtOperaciones.Clear();
                txtOperaciones.Text = txtOperaciones.Text + "" + txtNumeros.Text;
                llamar.PrimerNumero = Convert.ToDouble(txtNumeros.Text);
                llamar.Operador = "+";
                txtNumeros.Clear();
            }
            else if (llamar.PrimerNumero != 0)
            {
                HacerOperaciones();
                llamar.Operador = "+";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                MessageBox.Show("Campo vacio");
            }

            else if (llamar.PrimerNumero == 0)
            {
                txtOperaciones.Clear();
                txtOperaciones.Text = txtOperaciones.Text + "" + txtNumeros.Text;
                llamar.PrimerNumero = Convert.ToDouble(txtNumeros.Text);
                llamar.Operador = "-";
                txtNumeros.Clear();

            }
            else if (llamar.PrimerNumero != 0)
            {
                HacerOperaciones();
                llamar.Operador = "-";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                MessageBox.Show("Campo vacio");
            }

            else if (llamar.PrimerNumero == 0)
            {
                txtOperaciones.Clear();
                txtOperaciones.Text = txtOperaciones.Text + "" + txtNumeros.Text;
                llamar.PrimerNumero = Convert.ToDouble(txtNumeros.Text);
                llamar.Operador = "*";
                txtNumeros.Clear();

            }
            else if (llamar.PrimerNumero != 0)
            {
                HacerOperaciones();
                llamar.Operador = "*";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                MessageBox.Show("Campo vacio");
            }

            else if (llamar.PrimerNumero == 0)
            {
                txtOperaciones.Clear();
                txtOperaciones.Text = txtOperaciones.Text + "" + txtNumeros.Text;
                llamar.PrimerNumero = Convert.ToDouble(txtNumeros.Text);
                llamar.Operador = "/";
                txtNumeros.Clear();
            }
            else if (llamar.PrimerNumero != 0)
            {
                HacerOperaciones();
                llamar.Operador = "/";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtNumeros.Text == "")
            {
                MessageBox.Show("Campo vacio");
            }
            else if(txtNumeros.Text!="" && llamar.PrimerNumero==0)
            {
                MessageBox.Show("Necesitas hacer alguna operacion antes de esto!");
            }
            else if (llamar.PrimerNumero == 0)
            {
                txtOperaciones.Clear();
                txtOperaciones.Text = txtOperaciones.Text + "" + txtNumeros.Text;
                llamar.PrimerNumero = Convert.ToDouble(txtNumeros.Text);
                txtNumeros.Clear();
            }
            else if (llamar.PrimerNumero != 0)
            {
                HacerOperaciones();
                txtNumeros.Text = txtOperaciones.Text;
                txtOperaciones.Clear();
                llamar.PrimerNumero = 0;
                llamar.SegundoNumero = 0;
                llamar.Operador = "";
            }
        }
    }
}
