using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConversaoDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double taxaDeJurosMensal, valorDaParcela,TotalFinanciamento, TotalJuros;
            
            taxaDeJurosMensal = (Convert.ToDouble(txtTaxadeJuros.Text) / 100) / 12;
            valorDaParcela = Convert.ToDouble(txtValorFinanciamento.Text) * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, -Convert.ToDouble(txtParcelas.Text))));
            TotalFinanciamento = valorDaParcela * Convert.ToDouble(txtParcelas.Text);
            TotalJuros=TotalFinanciamento - Convert.ToDouble(txtValorFinanciamento.Text);
            labelResultadoParcela.Text ="Valor em U$:"+valorDaParcela.ToString("N2");
            labelTotalJuros.Text = "Total em juros:" + TotalJuros.ToString("N2");
            labelValorTotal.Text = "Valor total pago: " + TotalFinanciamento.ToString("N2");
            txtTaxadeJuros.Clear();
            txtTaxadeJuros.Focus();
            txtValorFinanciamento.Clear();
            txtParcelas.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtValorReal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
