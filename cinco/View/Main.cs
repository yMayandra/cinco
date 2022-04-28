using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinco.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorCompra = 0;
            decimal valorPago = 0;
            decimal valorTroco = 0;



            valorCompra = Convert.ToDecimal( tbxCompra.Text);
            valorPago = Convert.ToDecimal(tbxPago.Text);
            valorTroco = valorPago - valorCompra;

            lblResultado.Text = valorTroco.ToString();

            int moeda100 = (int) valorTroco / 1;
            lblResultado100.Text = moeda100.ToString();

            int moeda050 = (int)(valorTroco / 0.50m);
            lblResultado050.Text = moeda050.ToString();

            int moeda025 = (int)(valorTroco / 0.25m);
            lblResultado025.Text = moeda025.ToString();

            int moeda010 = (int)(valorTroco / 0.10m);
            lblResultado010.Text = moeda010.ToString();

            int moeda005 = (int)(valorTroco / 0.05m);
            lblResultado005.Text = moeda005.ToString();

            int moeda001 = (int)(valorTroco / 0.01m);
            lblResultado001.Text = moeda001.ToString();

        }
    }
}
