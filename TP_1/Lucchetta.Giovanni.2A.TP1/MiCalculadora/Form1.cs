using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            MessageBox.Show("¿Porqué me tocas?");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonConvDecimal_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
