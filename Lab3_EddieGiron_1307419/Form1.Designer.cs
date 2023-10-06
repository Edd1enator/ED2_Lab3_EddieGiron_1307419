namespace Lab3_EddieGiron_1307419
{
    partial class Form1
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
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.txtBuscarDPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarDPI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersona = new System.Windows.Forms.ListBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(731, 258);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(121, 24);
            this.cmbCompanies.TabIndex = 42;
            this.cmbCompanies.SelectedIndexChanged += new System.EventHandler(this.cmbCompanies_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Decodificar DPI";
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(858, 254);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(75, 30);
            this.btnDecodificar.TabIndex = 40;
            this.btnDecodificar.Text = "Decode";
            this.btnDecodificar.UseVisualStyleBackColor = true;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // txtBuscarDPI
            // 
            this.txtBuscarDPI.Location = new System.Drawing.Point(734, 189);
            this.txtBuscarDPI.Name = "txtBuscarDPI";
            this.txtBuscarDPI.Size = new System.Drawing.Size(118, 22);
            this.txtBuscarDPI.TabIndex = 39;
            this.txtBuscarDPI.TextChanged += new System.EventHandler(this.txtBuscarDPI_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Buscar por dpi";
            // 
            // btnBuscarDPI
            // 
            this.btnBuscarDPI.Location = new System.Drawing.Point(858, 185);
            this.btnBuscarDPI.Name = "btnBuscarDPI";
            this.btnBuscarDPI.Size = new System.Drawing.Size(75, 30);
            this.btnBuscarDPI.TabIndex = 37;
            this.btnBuscarDPI.Text = "Mostrar";
            this.btnBuscarDPI.UseVisualStyleBackColor = true;
            this.btnBuscarDPI.Click += new System.EventHandler(this.btnBuscarDPI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Exportar personas";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(734, 338);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 30);
            this.btnExportar.TabIndex = 35;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(124, 374);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(88, 46);
            this.btnAnterior.TabIndex = 34;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(218, 374);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 46);
            this.btnSiguiente.TabIndex = 33;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(734, 118);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(118, 22);
            this.txtBuscar.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar persona";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(858, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Mostrar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lista de personas";
            // 
            // lstPersona
            // 
            this.lstPersona.FormattingEnabled = true;
            this.lstPersona.ItemHeight = 16;
            this.lstPersona.Location = new System.Drawing.Point(12, 12);
            this.lstPersona.Name = "lstPersona";
            this.lstPersona.Size = new System.Drawing.Size(713, 356);
            this.lstPersona.TabIndex = 28;
            this.lstPersona.SelectedIndexChanged += new System.EventHandler(this.lstPersona_SelectedIndexChanged);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(734, 41);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 30);
            this.btnLista.TabIndex = 27;
            this.btnLista.Text = "Mostrar";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 458);
            this.Controls.Add(this.cmbCompanies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDecodificar);
            this.Controls.Add(this.txtBuscarDPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarDPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPersona);
            this.Controls.Add(this.btnLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.TextBox txtBuscarDPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarDPI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersona;
        private System.Windows.Forms.Button btnLista;
    }
}

