using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_MATE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double suma = 0;

            suma = numero1 + numero2;

            lblresultado.Text = Convert.ToString(string.Format("{0:N0}", suma));


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = string.Empty;
            txtnumero2.Text = string.Empty;
            lblresultado.Text = "0";
            txtnumero1.Focus();

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double restar = 0;

            restar = numero1 - numero2;

            lblresultado.Text = Convert.ToString(string.Format("{0:N0}", restar));
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double multiplicar = 0;

            multiplicar = numero1 * numero2;

            lblresultado.Text = Convert.ToString(string.Format("{0:N0}", multiplicar));
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double Dividir = 0;

            Dividir = numero1 / numero2;

            lblresultado.Text = Convert.ToString(string.Format("{0:N0}", Dividir));
        }
    }
    
}
