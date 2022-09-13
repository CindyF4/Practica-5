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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            string N1 = txtN1.Text;
            MessageBox.Show(N1);

            string N2 = txtN2.Text;
            MessageBox.Show(N2);

            string itemSelected = comboOpciones.Text;
            double num1 = double.Parse(txtN1.Text);
            double num2 = Convert.ToDouble(txtN2.Text);
            switch (itemSelected)
            {
                case "Suma":

                    var suma = num1 + num2;
                    MessageBox.Show(suma.ToString());
                    break;

                case "Resta":

                    var resta = num1 - num2;
                    MessageBox.Show(resta.ToString());
                    break;

                case "Multiplicacion":

                    var multiplicacion = num1 * num2;
                    MessageBox.Show(multiplicacion.ToString());
                    break;

                case "Division":

                    var division = num1 / num2;
                    MessageBox.Show(division.ToString());
                    break;

                    


            }
            MessageBox.Show(itemSelected);
        }
    }
}
