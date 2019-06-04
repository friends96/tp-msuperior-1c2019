namespace TP_Matematica_Superior_Demo.Forms
{
    partial class RadicacionDeUnNumeroComplejo
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
            this.lblIngresarNumero = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnCargarNumero = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.listBoxResultados = new System.Windows.Forms.ListBox();
            this.lblNumeroComplejo = new System.Windows.Forms.Label();
            this.numericUpDownIndice = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            this.btnRaizPrimitiva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarNumero
            // 
            this.lblIngresarNumero.AutoSize = true;
            this.lblIngresarNumero.Location = new System.Drawing.Point(9, 25);
            this.lblIngresarNumero.Name = "lblIngresarNumero";
            this.lblIngresarNumero.Size = new System.Drawing.Size(59, 13);
            this.lblIngresarNumero.TabIndex = 0;
            this.lblIngresarNumero.Text = "Radicando";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(9, 81);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(36, 13);
            this.lblIndice.TabIndex = 1;
            this.lblIndice.Text = "Indice";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(9, 192);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(40, 13);
            this.lblResultados.TabIndex = 2;
            this.lblResultados.Text = "Raices";
            // 
            // btnCargarNumero
            // 
            this.btnCargarNumero.Location = new System.Drawing.Point(169, 20);
            this.btnCargarNumero.Name = "btnCargarNumero";
            this.btnCargarNumero.Size = new System.Drawing.Size(75, 41);
            this.btnCargarNumero.TabIndex = 3;
            this.btnCargarNumero.Text = "Agregar Numero";
            this.btnCargarNumero.UseVisualStyleBackColor = true;
            this.btnCargarNumero.Click += new System.EventHandler(this.BtnCargarNumero_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // listBoxResultados
            // 
            this.listBoxResultados.FormattingEnabled = true;
            this.listBoxResultados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBoxResultados.Location = new System.Drawing.Point(12, 208);
            this.listBoxResultados.Name = "listBoxResultados";
            this.listBoxResultados.Size = new System.Drawing.Size(143, 134);
            this.listBoxResultados.TabIndex = 5;
            // 
            // lblNumeroComplejo
            // 
            this.lblNumeroComplejo.AutoSize = true;
            this.lblNumeroComplejo.Location = new System.Drawing.Point(102, 25);
            this.lblNumeroComplejo.Name = "lblNumeroComplejo";
            this.lblNumeroComplejo.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroComplejo.TabIndex = 6;
            this.lblNumeroComplejo.Text = "----";
            // 
            // numericUpDownIndice
            // 
            this.numericUpDownIndice.Location = new System.Drawing.Point(74, 79);
            this.numericUpDownIndice.Name = "numericUpDownIndice";
            this.numericUpDownIndice.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownIndice.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 168);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(19, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "----";
            // 
            // btnRaizPrimitiva
            // 
            this.btnRaizPrimitiva.Location = new System.Drawing.Point(169, 133);
            this.btnRaizPrimitiva.Name = "btnRaizPrimitiva";
            this.btnRaizPrimitiva.Size = new System.Drawing.Size(75, 72);
            this.btnRaizPrimitiva.TabIndex = 9;
            this.btnRaizPrimitiva.Text = "Raices primitivas de la unidad";
            this.btnRaizPrimitiva.UseVisualStyleBackColor = true;
            this.btnRaizPrimitiva.Click += new System.EventHandler(this.RaicesPrimitivas_Click);
            // 
            // RadicacionDeUnNumeroComplejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 373);
            this.Controls.Add(this.btnRaizPrimitiva);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.numericUpDownIndice);
            this.Controls.Add(this.lblNumeroComplejo);
            this.Controls.Add(this.listBoxResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCargarNumero);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.lblIngresarNumero);
            this.Name = "RadicacionDeUnNumeroComplejo";
            this.Text = "RadicacionDeUnNumeroComplejo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNumero;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnCargarNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNumeroComplejo;
        private System.Windows.Forms.NumericUpDown numericUpDownIndice;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.ListBox listBoxResultados;
        private System.Windows.Forms.Button btnRaizPrimitiva;
    }
}