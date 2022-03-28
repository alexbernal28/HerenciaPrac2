using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_Basicos
{
    public partial class Form1 : Form
    {
        CalculoBasic calculo = new CalculoBasic();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            calculo.Numero1 = Convert.ToInt32(textBox1.Text);
            calculo.Numero2 = Convert.ToInt32(textBox2.Text);

            int resultado = calculo.Suma(calculo.Numero1, calculo.Numero2);

            label4.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            calculo.Numero1 = Convert.ToInt32(textBox1.Text);
            calculo.Numero2 = Convert.ToInt32(textBox2.Text);

            int resultado = calculo.Resta(calculo.Numero1, calculo.Numero2);

            label4.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            calculo.Numero1 = Convert.ToInt32(textBox1.Text);
            calculo.Numero2 = Convert.ToInt32(textBox2.Text);

            int resultado = calculo.Multiplication(calculo.Numero1, calculo.Numero2);

            label4.Text = resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            calculo.Numero1 = Convert.ToInt32(textBox1.Text);
            calculo.Numero2 = Convert.ToInt32(textBox2.Text);

            int resultado = calculo.Division(calculo.Numero1, calculo.Numero2);

            label4.Text = resultado.ToString(); 
        }
    }
}
