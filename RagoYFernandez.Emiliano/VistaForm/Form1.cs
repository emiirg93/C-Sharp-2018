using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private DirectorTecnico dt ;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxApellido.Text != "" && (int)numericUpDownEdad.Value > 18 && (int)numericUpDownDni.Value > 0 && (int)numericUpDownExperiencia.Value > 0)
            {
                this.dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);
                MessageBox.Show("Se Ha Creado El DT!");
            }
            else
            {
                MessageBox.Show("Ingrese Todos Los Datos Para Crear Un DT.");
            }   
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
           if(dt == null)
           {
               MessageBox.Show("Aun No Se Ha Creado El DT Del Formulario.");
           }
           else if (dt.ValidarAptitud())
           {
               MessageBox.Show("El DT Es Apto.");   
           }
           else
           {
               MessageBox.Show("El DT No Es Apto.");
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
    }
}
