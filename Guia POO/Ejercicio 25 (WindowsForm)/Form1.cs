using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ejercicio_22;

namespace Ejercicio_25__WindowsForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
              txtResultBinADec.Text = Conversor.BinarioDecimal(txtIngresoBin.Text).ToString();  
            }
            catch(Exception)
            {
                MessageBox.Show("Ha Ingresado Un Numero Que No Es Binario.");   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultDecABin.Text = Conversor.DecimalBinario(txtIngresoDec.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha Ingresado Un Numero Que No Es Decimal");
            }
        }

       
    }
}
