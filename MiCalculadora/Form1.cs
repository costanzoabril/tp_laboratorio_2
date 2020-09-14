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
        /// Toma los valores y el operador elegidos por el usuario y muestra su resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOperar_Click(object sender, EventArgs e)
        {
            string op = this.comboBoxOperador.Text;
            string num1 = this.textBoxNum1.Text;
            string num2 = this.textBoxNum2.Text;

            this.textBoxResultado.Text = (Operar(num1, num2, op)).ToString();
        }

        /// <summary>
        /// Llama a Calculadora.Operar() y devuelve el resultado de la operacion
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string num1, string num2, string op)
        {
            Numero aux1 = new Numero(num1);
            Numero aux2 = new Numero(num2);

            return Calculadora.Operar(aux1, aux2, op);
        }

        /// <summary>
        /// Llama al Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Vacia todos los textBox y el comboBox
        /// </summary>
        private void Limpiar()
        {
            comboBoxOperador.Text = "";
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";          
            textBoxResultado.Text = "";
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Convierte el resultado a binario (de ser posible)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bABinario_Click(object sender, EventArgs e)
        {
            string resultDecimal = this.textBoxResultado.Text;
            this.textBoxResultado.Text = Numero.DecimalBinario(resultDecimal);
            bADecimal.Enabled = true;
            bABinario.Enabled = false;
        }

        /// <summary>
        /// Convierte el resultado a decimal (de ser posible)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bADecimal_Click(object sender, EventArgs e)
        {
            string resultBinario = this.textBoxResultado.Text;
            this.textBoxResultado.Text = Numero.BinarioDecimal(resultBinario);
            bABinario.Enabled = true;
            bADecimal.Enabled = false;
        }
    }
}
