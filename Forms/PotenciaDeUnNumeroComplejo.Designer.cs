namespace TP_Matematica_Superior_Demo.Forms
{
    partial class PotenciaDeUnNumeroComplejo
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
            this.lblNumeroComplejo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownExponente = new System.Windows.Forms.NumericUpDown();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNumeroCargado = new System.Windows.Forms.Label();
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExponente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroComplejo
            // 
            this.lblNumeroComplejo.AutoSize = true;
            this.lblNumeroComplejo.Location = new System.Drawing.Point(31, 30);
            this.lblNumeroComplejo.Name = "lblNumeroComplejo";
            this.lblNumeroComplejo.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroComplejo.TabIndex = 0;
            this.lblNumeroComplejo.Text = "Numero Complejo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exponente";
            // 
            // numericUpDownExponente
            // 
            this.numericUpDownExponente.Location = new System.Drawing.Point(34, 127);
            this.numericUpDownExponente.Name = "numericUpDownExponente";
            this.numericUpDownExponente.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownExponente.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(171, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(19, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "----";
            // 
            // lblNumeroCargado
            // 
            this.lblNumeroCargado.AutoSize = true;
            this.lblNumeroCargado.Location = new System.Drawing.Point(31, 58);
            this.lblNumeroCargado.Name = "lblNumeroCargado";
            this.lblNumeroCargado.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroCargado.TabIndex = 5;
            this.lblNumeroCargado.Text = "----";
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.Location = new System.Drawing.Point(129, 53);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(95, 23);
            this.btnAgregarNumero.TabIndex = 6;
            this.btnAgregarNumero.Text = "Agregar Numero";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 185);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // PotenciaDeUnNumeroComplejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 255);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregarNumero);
            this.Controls.Add(this.lblNumeroCargado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.numericUpDownExponente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroComplejo);
            this.Name = "PotenciaDeUnNumeroComplejo";
            this.Text = "PotenciaDeUnNumeroComplejo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroComplejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownExponente;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNumeroCargado;
        private System.Windows.Forms.Button btnAgregarNumero;
        private System.Windows.Forms.Button btnCalcular;
    }
}