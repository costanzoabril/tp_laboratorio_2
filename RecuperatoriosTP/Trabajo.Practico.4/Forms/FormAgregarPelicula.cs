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

namespace Forms
{
    public partial class FormAgregarPelicula : Form
    {
        public Entrada nuevaEntrada;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormAgregarPelicula()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crea una nueva instancia de una entrada de pelicula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && comboBoxGenero.Text != "" && comboBoxPrecio.Text != "" )
            {
                nuevaEntrada = new Entrada(comboBoxPrecio.Text, textBoxNombre.Text, Entrada.MapearEnum(comboBoxGenero.Text));

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos");
            }
        }

        /// <summary>
        /// Cancela la adicion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
