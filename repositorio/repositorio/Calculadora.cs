using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace repositorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor =Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Total = Valor + Valor2;
            txtTotal.Text = Total.ToString();
        //    MessageBox.Show(Total.ToString());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Valor = Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Total = Valor - Valor2;
            txtTotal.Text = Total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Valor = Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Total = Valor * Valor2;
            txtTotal.Text = Total.ToString();
        }

        private void Resto_Click(object sender, EventArgs e)
        {
            decimal Valor = Convert.ToDecimal(txtValor1.Text);
            decimal Valor2 = Convert.ToDecimal (txtValor2.Text);
            decimal Total = Valor2 / Valor;
            txtTotal.Text = Total.ToString();
        }

       
    }
}
