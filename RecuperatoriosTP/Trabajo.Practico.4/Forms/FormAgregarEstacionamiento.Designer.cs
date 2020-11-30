namespace Forms
{
    partial class FormAgregarEstacionamiento
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
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.textBoxUbi = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbicacion.Location = new System.Drawing.Point(12, 22);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(69, 16);
            this.labelUbicacion.TabIndex = 0;
            this.labelUbicacion.Text = "Ubicacion";
            // 
            // textBoxUbi
            // 
            this.textBoxUbi.Location = new System.Drawing.Point(12, 41);
            this.textBoxUbi.Name = "textBoxUbi";
            this.textBoxUbi.Size = new System.Drawing.Size(238, 20);
            this.textBoxUbi.TabIndex = 1;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(12, 122);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(110, 32);
            this.botonAceptar.TabIndex = 3;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(12, 64);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(47, 16);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(140, 122);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(110, 32);
            this.botonCancelar.TabIndex = 4;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Items.AddRange(new object[] {
            "50",
            "80",
            "100",
            "150",
            "200",
            "250"});
            this.comboBoxPrecio.Location = new System.Drawing.Point(12, 83);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(238, 21);
            this.comboBoxPrecio.TabIndex = 2;
            // 
            // FormAgregarEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 174);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.textBoxUbi);
            this.Controls.Add(this.labelUbicacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar a la Base de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.TextBox textBoxUbi;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
    }
}