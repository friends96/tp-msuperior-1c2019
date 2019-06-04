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
            this.lblNumeroComplejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComplejo.Location = new System.Drawing.Point(34, 38);
            this.lblNumeroComplejo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroComplejo.Name = "lblNumeroComplejo";
            this.lblNumeroComplejo.Size = new System.Drawing.Size(165, 24);
            this.lblNumeroComplejo.TabIndex = 0;
            this.lblNumeroComplejo.Text = "Numero Complejo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exponente";
            // 
            // numericUpDownExponente
            // 
            this.numericUpDownExponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownExponente.Location = new System.Drawing.Point(272, 111);
            this.numericUpDownExponente.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownExponente.Name = "numericUpDownExponente";
            this.numericUpDownExponente.Size = new System.Drawing.Size(85, 29);
            this.numericUpDownExponente.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(34, 175);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(34, 24);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "----";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroCargado
            // 
            this.lblNumeroCargado.AutoSize = true;
            this.lblNumeroCargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCargado.Location = new System.Drawing.Point(291, 38);
            this.lblNumeroCargado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroCargado.Name = "lblNumeroCargado";
            this.lblNumeroCargado.Size = new System.Drawing.Size(34, 24);
            this.lblNumeroCargado.TabIndex = 5;
            this.lblNumeroCargado.Text = "----";
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNumero.Location = new System.Drawing.Point(403, 19);
            this.btnAgregarNumero.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(93, 62);
            this.btnAgregarNumero.TabIndex = 6;
            this.btnAgregarNumero.Text = "Agregar Numero";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            this.btnAgregarNumero.Click += new System.EventHandler(this.BtnAgregarNumero_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(38, 217);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 51);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // PotenciaDeUnNumeroComplejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 283);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregarNumero);
            this.Controls.Add(this.lblNumeroCargado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.numericUpDownExponente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroComplejo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
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