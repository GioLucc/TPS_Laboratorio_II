using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        double resultado;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConvBinary_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            char operando;
            //string resultadoString;

            Operando primerNumero = new Operando(txtNumero1.Text);
            Operando segundoNumero = new Operando(txtNumero2.Text);

            char.TryParse(cmbOperador.Text, out operando);

            this.resultado = (Calculadora.Operar(primerNumero, segundoNumero, operando));

            lblResultado.Text = this.resultado.ToString();

            MessageBox.Show("El resultado de la suma fue: "+this.resultado);

            //resultadoString =this.resultado.ToString();


            //primerNumero = this.txtNumero1.Text;
            //segundoNumero = this.txtNumero2.Text;
            //MessageBox.Show("¿Porqué me tocas? \nBueno no importa ingresaste esto: "+ firstString + ", y esto: "+ secondString);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonConvDecimal_Click(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro que desea salir?", "Atención",
            MessageBoxButtons.YesNo,MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

            if(rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("¡Sigue corriendo la aplicación!","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void FormCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("¡Gracias por utilizar mi programa!", "Gracias",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOperaciones.Text = this.resultado.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            lblResultado.Text = this.resultado.ToString();
        }
    }
}
