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


        /// <summary>
        /// Carga todos los componentes del WForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
        }

        /// <summary>
        /// A partir del resultado del label efectua una conversión a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numeroDecimal = new Operando();
            string auxString;
            string resultadoAnterior;

            resultadoAnterior = lblResultado.Text;
            auxString = numeroDecimal.DecimalBinario(lblResultado.Text);

            this.lblResultado.Text = auxString;

            this.lstOperaciones.Items.Add(resultadoAnterior + " --> " + auxString);

        }

        /// <summary>
        /// A partir del resultado del label efectua una conversión a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numeroBinario = new Operando();
            string auxString;
            string resultadoAnterior;

            resultadoAnterior = lblResultado.Text;
            auxString = numeroBinario.BinarioDecimal(lblResultado.Text);

            this.lblResultado.Text = auxString;

            this.lstOperaciones.Items.Add(resultadoAnterior + " --> " + auxString);
        }

        /// <summary>
        /// Cierra el WForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Valida que los textboxs no tengan strings.
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns>0 si los textboxs tienen strings o characters, si tienen valores numericos devuelve el valor numerico.</returns>
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

        /// <summary>
        /// Instancia 2 objetos a partir de los numeros recibidos para realizar las validaciones pertinentes y usarlos.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Llamada a la función operar de la clase calculadora.</returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            Operando primerNumero = new Operando(numero1);
            Operando segundoNumero = new Operando(numero2);
            char convOperador;

            char.TryParse(operador, out convOperador);

            return Calculadora.Operar(primerNumero, segundoNumero, convOperador);
        }

        /// <summary>
        /// Al apretar click sobre este evento el mismo se encarga de mostrar el resultado en el label y de agregarlo a la listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            mensaje = ValidarTextBoxs(this.txtNumero1.Text) + " " + operador + " " + ValidarTextBoxs(this.txtNumero2.Text) + " = " + resultado;
            this.lblResultado.Text = resultado;

            if (resultado == double.MinValue.ToString())
            {
                mensaje = "¡No se puede dividir por 0!";
                this.lblResultado.Text = mensaje;
            }
           
            this.lstOperaciones.Items.Add(mensaje);
        }

        /// <summary>
        /// Llama al metodo Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Encargado de cerrar el WForm pero no sin antes realizar una confirmación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Pequeño mensaje de agradecimiento a la hora de que el formulario se cierre luego de la confirmación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("¡Gracias por utilizar mi programa!", "Gracias",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Se encarga de limpiar: Label, ambos TextBoxs y el ComboBox.
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = -1;
        }
    }
}
