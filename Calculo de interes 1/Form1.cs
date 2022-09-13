using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_interes_1
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

            string N3 = txtN3.Text;
            MessageBox.Show(N3);

            string itemSelected = comboOpciones.Text;
            double num1 = double.Parse(txtN1.Text);
            double num2 = double.Parse(txtN2.Text);
            double num3 = Convert.ToDouble(txtN3.Text);

            switch (itemSelected)
            {
                case "Anual":
                    var Anual = num1 * num2 * num3;
                    MessageBox.Show(Anual.ToString());
                    break;

                case "Mensual":
                    var Mensual = num1 * num2 * num3 / 12;
                    MessageBox.Show(Mensual.ToString());
                    break;

                case "Diario":
                    var Diario = num1 * num2 * num3 / 360;
                    MessageBox.Show(Diario.ToString());
                    break;

            }
            MessageBox.Show(itemSelected);
        }
    }
}
