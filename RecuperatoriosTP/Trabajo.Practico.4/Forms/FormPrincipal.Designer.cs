namespace Forms
{
    partial class FormPrincipal
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
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.dgvEstacionamiento = new System.Windows.Forms.DataGridView();
            this.botonAgregarP = new System.Windows.Forms.Button();
            this.botonAgregarE = new System.Windows.Forms.Button();
            this.botonAgregarPBD = new System.Windows.Forms.Button();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.botonVender = new System.Windows.Forms.Button();
            this.labelPeliculas = new System.Windows.Forms.Label();
            this.labelEstacionamiento = new System.Windows.Forms.Label();
            this.labelTicket = new System.Windows.Forms.Label();
            this.botonAgregarEDB = new System.Windows.Forms.Button();
            this.textBoxVentas = new System.Windows.Forms.TextBox();
            this.labelAvisos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.AllowUserToResizeColumns = false;
            this.dgvEntradas.AllowUserToResizeRows = false;
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(11, 34);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(249, 352);
            this.dgvEntradas.TabIndex = 3;
            // 
            // dgvEstacionamiento
            // 
            this.dgvEstacionamiento.AllowUserToDeleteRows = false;
            this.dgvEstacionamiento.AllowUserToResizeColumns = false;
            this.dgvEstacionamiento.AllowUserToResizeRows = false;
            this.dgvEstacionamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstacionamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstacionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacionamiento.Location = new System.Drawing.Point(266, 34);
            this.dgvEstacionamiento.MultiSelect = false;
            this.dgvEstacionamiento.Name = "dgvEstacionamiento";
            this.dgvEstacionamiento.RowHeadersVisible = false;
            this.dgvEstacionamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstacionamiento.Size = new System.Drawing.Size(250, 352);
            this.dgvEstacionamiento.TabIndex = 4;
            // 
            // botonAgregarP
            // 
            this.botonAgregarP.Location = new System.Drawing.Point(11, 392);
            this.botonAgregarP.Name = "botonAgregarP";
            this.botonAgregarP.Size = new System.Drawing.Size(249, 34);
            this.botonAgregarP.TabIndex = 7;
            this.botonAgregarP.Text = "Agregar a la compra";
            this.botonAgregarP.UseVisualStyleBackColor = true;
            this.botonAgregarP.Click += new System.EventHandler(this.botonAgregarP_Click);
            // 
            // botonAgregarE
            // 
            this.botonAgregarE.Location = new System.Drawing.Point(266, 392);
            this.botonAgregarE.Name = "botonAgregarE";
            this.botonAgregarE.Size = new System.Drawing.Size(250, 34);
            this.botonAgregarE.TabIndex = 8;
            this.botonAgregarE.Text = "Agregar a la compra";
            this.botonAgregarE.UseVisualStyleBackColor = true;
            this.botonAgregarE.Click += new System.EventHandler(this.botonAgregarE_Click);
            // 
            // botonAgregarPBD
            // 
            this.botonAgregarPBD.Location = new System.Drawing.Point(11, 433);
            this.botonAgregarPBD.Name = "botonAgregarPBD";
            this.botonAgregarPBD.Size = new System.Drawing.Size(249, 37);
            this.botonAgregarPBD.TabIndex = 9;
            this.botonAgregarPBD.Text = "Agregar a la base de datos";
            this.botonAgregarPBD.UseVisualStyleBackColor = true;
            this.botonAgregarPBD.Click += new System.EventHandler(this.botonAgregarPBD_Click);
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(522, 34);
            this.textBoxTicket.Multiline = true;
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.ReadOnly = true;
            this.textBoxTicket.Size = new System.Drawing.Size(271, 158);
            this.textBoxTicket.TabIndex = 5;
            // 
            // botonVender
            // 
            this.botonVender.Location = new System.Drawing.Point(541, 198);
            this.botonVender.Name = "botonVender";
            this.botonVender.Size = new System.Drawing.Size(237, 34);
            this.botonVender.TabIndex = 6;
            this.botonVender.Text = "Vender";
            this.botonVender.UseVisualStyleBackColor = true;
            this.botonVender.Click += new System.EventHandler(this.botonVender_Click);
            // 
            // labelPeliculas
            // 
            this.labelPeliculas.AutoSize = true;
            this.labelPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeliculas.Location = new System.Drawing.Point(86, 6);
            this.labelPeliculas.Name = "labelPeliculas";
            this.labelPeliculas.Size = new System.Drawing.Size(99, 25);
            this.labelPeliculas.TabIndex = 0;
            this.labelPeliculas.Text = "Peliculas";
            // 
            // labelEstacionamiento
            // 
            this.labelEstacionamiento.AutoSize = true;
            this.labelEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstacionamiento.Location = new System.Drawing.Point(305, 6);
            this.labelEstacionamiento.Name = "labelEstacionamiento";
            this.labelEstacionamiento.Size = new System.Drawing.Size(171, 25);
            this.labelEstacionamiento.TabIndex = 1;
            this.labelEstacionamiento.Text = "Estacionamiento";
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicket.Location = new System.Drawing.Point(632, 9);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(60, 24);
            this.labelTicket.TabIndex = 2;
            this.labelTicket.Text = "Ticket";
            // 
            // botonAgregarEDB
            // 
            this.botonAgregarEDB.Location = new System.Drawing.Point(266, 432);
            this.botonAgregarEDB.Name = "botonAgregarEDB";
            this.botonAgregarEDB.Size = new System.Drawing.Size(250, 37);
            this.botonAgregarEDB.TabIndex = 10;
            this.botonAgregarEDB.Text = "Agregar a la base de datos";
            this.botonAgregarEDB.UseVisualStyleBackColor = true;
            this.botonAgregarEDB.Click += new System.EventHandler(this.botonAgregarEDB_Click);
            // 
            // textBoxVentas
            // 
            this.textBoxVentas.Location = new System.Drawing.Point(522, 281);
            this.textBoxVentas.Multiline = true;
            this.textBoxVentas.Name = "textBoxVentas";
            this.textBoxVentas.ReadOnly = true;
            this.textBoxVentas.Size = new System.Drawing.Size(271, 187);
            this.textBoxVentas.TabIndex = 13;
            // 
            // labelAvisos
            // 
            this.labelAvisos.AutoSize = true;
            this.labelAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisos.Location = new System.Drawing.Point(599, 245);
            this.labelAvisos.Name = "labelAvisos";
            this.labelAvisos.Size = new System.Drawing.Size(123, 20);
            this.labelAvisos.TabIndex = 11;
            this.labelAvisos.Text = "Ventas vigentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "(peliculas empezadas y estacionamientos ocupados)";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAvisos);
            this.Controls.Add(this.textBoxVentas);
            this.Controls.Add(this.botonAgregarEDB);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.labelEstacionamiento);
            this.Controls.Add(this.labelPeliculas);
            this.Controls.Add(this.botonVender);
            this.Controls.Add(this.textBoxTicket);
            this.Controls.Add(this.botonAgregarPBD);
            this.Controls.Add(this.botonAgregarE);
            this.Controls.Add(this.botonAgregarP);
            this.Controls.Add(this.dgvEstacionamiento);
            this.Controls.Add(this.dgvEntradas);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletería Auto Cine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonAgregarP;
        private System.Windows.Forms.Button botonAgregarE;
        private System.Windows.Forms.Button botonAgregarPBD;
        private System.Windows.Forms.Button botonVender;
        private System.Windows.Forms.Label labelPeliculas;
        private System.Windows.Forms.Label labelEstacionamiento;
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Button botonAgregarEDB;
        public System.Windows.Forms.DataGridView dgvEntradas;
        public System.Windows.Forms.DataGridView dgvEstacionamiento;
        public System.Windows.Forms.TextBox textBoxTicket;
        public System.Windows.Forms.TextBox textBoxVentas;
        private System.Windows.Forms.Label labelAvisos;
        private System.Windows.Forms.Label label1;
    }
}

