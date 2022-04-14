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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
        }

        private void buttonConvBinary_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string ValidarTextBoxs(string txtBox)
        {
            double retorno = 0;

            if (!double.TryParse(txtBox, out retorno))
            {
                retorno = 0;
                txtBox = retorno.ToString();
            }

            return txtBox;
        }
        private double Operar(string numero1, string numero2, string operador)
        {
            Operando primerNumero = new Operando(numero1);
            Operando segundoNumero = new Operando(numero2);
            char convOperador;

            char.TryParse(operador, out convOperador);

            return Calculadora.Operar(primerNumero, segundoNumero, convOperador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado;
            string mensaje;
            string operador = this.cmbOperador.Text;

            resultado = Convert.ToString(Operar(this.txtNumero1.Text, this.txtNumero2.Text, operador));

            if(string.IsNullOrEmpty(operador))
            {
                operador = "+";
            }
            else
            {
                operador = this.cmbOperador.Text;
            }

            this.txtNumero1.Text = ValidarTextBoxs(this.txtNumero1.Text);
            this.txtNumero2.Text = ValidarTextBoxs(this.txtNumero2.Text);

            mensaje = this.txtNumero1.Text + " " + operador + " " + this.txtNumero2.Text + " = " + resultado;
            this.lblResultado.Text = resultado;
            this.lstOperaciones.Items.Add(mensaje);

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
            this.cmbOperador.Text = " ";
        }

        //private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("¡ERROR - No puedes ingresar letras - ERROR!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("¡ERROR - No puedes ingresar letras - ERROR!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


    }
}
