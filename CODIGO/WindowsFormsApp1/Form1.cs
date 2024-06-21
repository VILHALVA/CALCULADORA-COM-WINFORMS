using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        int cantclick = 0;
        int cantnum = 0;
        string operador;
        double resultado = 0;
        string mostrar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += "9";
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            cantnum += 1;
            if (cantnum == 1)
                txtAccActual.Clear();
            txtAccActual.Text += ".";
        }

        private void BtnPorciento_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtAccActual.Text);
            richPantalla.Text = txtAccActual.Text + " %";
            cantnum = 0;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            cantnum = 0;
            cantclick += 1;
            a = Convert.ToDouble(txtAccActual.Text);
            richPantalla.Text += txtAccActual.Text + "/";
            operador = "/";
            if (txtAccActual.Text != "")
                richPantalla.Text = txtAccActual.Text + " /";
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            cantnum = 0;
            cantclick += 1;
            a = Convert.ToDouble(txtAccActual.Text);
            richPantalla.Text += "×";
            operador = "*";
            if (txtAccActual.Text != "")
                richPantalla.Text = txtAccActual.Text + " ×";
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            cantnum = 0;
            cantclick += 1;
            a = Convert.ToDouble(txtAccActual.Text);
            richPantalla.Text += "-";
            operador = "-";
            if (txtAccActual.Text != "")
                richPantalla.Text = txtAccActual.Text + " -";
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            cantnum = 0;
            cantclick += 1;
            a = Convert.ToDouble(txtAccActual.Text);
            richPantalla.Text += "+";
            operador = "+";
            if (txtAccActual.Text != "")
                richPantalla.Text = txtAccActual.Text + " +";
        }
        //×
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            cantnum = 0;
            if (richPantalla.Text.Contains("/") == true)
            {
                b = Convert.ToDouble(txtAccActual.Text);
                resultado = a / b;
                txtAccActual.Text = resultado.ToString();
                richPantalla.Text = "";
            }
            if (richPantalla.Text.Contains("×") == true)
            {
                b = Convert.ToDouble(txtAccActual.Text);
                resultado = a * b;
                txtAccActual.Text = resultado.ToString();
                richPantalla.Text = "";
            }
            if (richPantalla.Text.Contains("-") == true)
            {
                b = Convert.ToDouble(txtAccActual.Text);
                resultado = a - b;
                txtAccActual.Text = resultado.ToString();
                richPantalla.Text = "";
            }
            if (richPantalla.Text.Contains("+") == true)
            {
                b = Convert.ToDouble(txtAccActual.Text);
                resultado = a + b;
                txtAccActual.Text = resultado.ToString();
                richPantalla.Text = "";
            }
            if (richPantalla.Text.Contains("%") == true)
            {
                b = Convert.ToDouble(txtAccActual.Text);
                resultado = a /100 * b;
                txtAccActual.Text = resultado.ToString();
                richPantalla.Text = "";

            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {

            richPantalla.Clear();
            txtAccActual.Clear();
        }
        
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (txtAccActual.Text.Length == 1)
                txtAccActual.Text = "";
            else
                txtAccActual.Text = txtAccActual.Text.Substring(0, txtAccActual.Text.Length - 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)
                Btn0_Click(sender, e);
        }

        private void txtAccActual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
