namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.bOperar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bABinario = new System.Windows.Forms.Button();
            this.bADecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum1.Location = new System.Drawing.Point(12, 67);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(132, 35);
            this.textBoxNum1.TabIndex = 0;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperador.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperador.Location = new System.Drawing.Point(152, 68);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(132, 34);
            this.comboBoxOperador.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultado.Location = new System.Drawing.Point(290, 12);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(132, 35);
            this.textBoxResultado.TabIndex = 2;
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNum2.Location = new System.Drawing.Point(290, 67);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(132, 35);
            this.textBoxNum2.TabIndex = 3;
            // 
            // bOperar
            // 
            this.bOperar.Location = new System.Drawing.Point(12, 120);
            this.bOperar.Name = "bOperar";
            this.bOperar.Size = new System.Drawing.Size(132, 47);
            this.bOperar.TabIndex = 4;
            this.bOperar.Text = "Operar";
            this.bOperar.UseVisualStyleBackColor = true;
            this.bOperar.Click += new System.EventHandler(this.bOperar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(152, 120);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(132, 47);
            this.bLimpiar.TabIndex = 5;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(290, 120);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(132, 47);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bABinario
            // 
            this.bABinario.Location = new System.Drawing.Point(12, 173);
            this.bABinario.Name = "bABinario";
            this.bABinario.Size = new System.Drawing.Size(202, 48);
            this.bABinario.TabIndex = 7;
            this.bABinario.Text = "Convertir a binario";
            this.bABinario.UseVisualStyleBackColor = true;
            this.bABinario.Click += new System.EventHandler(this.bABinario_Click);
            // 
            // bADecimal
            // 
            this.bADecimal.Location = new System.Drawing.Point(220, 173);
            this.bADecimal.Name = "bADecimal";
            this.bADecimal.Size = new System.Drawing.Size(202, 48);
            this.bADecimal.TabIndex = 8;
            this.bADecimal.Text = "Convertir a decimal";
            this.bADecimal.UseVisualStyleBackColor = true;
            this.bADecimal.Click += new System.EventHandler(this.bADecimal_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 234);
            this.Controls.Add(this.bADecimal);
            this.Controls.Add(this.bABinario);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bOperar);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textBoxNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculadora de Abril Costanzo del curso 2°A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Button bOperar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bABinario;
        private System.Windows.Forms.Button bADecimal;
    }
}

