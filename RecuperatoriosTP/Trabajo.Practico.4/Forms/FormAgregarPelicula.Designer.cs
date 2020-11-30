namespace Forms
{
    partial class FormAgregarPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.labelPelicula = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(261, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "CienciaFiccion",
            "Infantil",
            "Romance",
            "Suspenso",
            "Drama",
            "Otro"});
            this.comboBoxGenero.Location = new System.Drawing.Point(12, 100);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(261, 21);
            this.comboBoxGenero.TabIndex = 3;
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelicula.Location = new System.Drawing.Point(12, 24);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(141, 16);
            this.labelPelicula.TabIndex = 0;
            this.labelPelicula.Text = "Nombre de la Pelicula";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(12, 81);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(53, 16);
            this.labelGenero.TabIndex = 2;
            this.labelGenero.Text = "Genero";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(12, 143);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(47, 16);
            this.labelPrecio.TabIndex = 4;
            this.labelPrecio.Text = "Precio";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(12, 204);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(126, 33);
            this.botonAceptar.TabIndex = 6;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(144, 204);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(129, 33);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Items.AddRange(new object[] {
            "150",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500"});
            this.comboBoxPrecio.Location = new System.Drawing.Point(12, 162);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(261, 21);
            this.comboBoxPrecio.TabIndex = 5;
            // 
            // FormAgregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 249);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelPelicula);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.textBoxNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar pelicula a la Base de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label labelPelicula;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
    }
}