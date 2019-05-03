namespace TP_Matematica_Superior_Demo
{
    partial class OperacionesBasicas
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
            this.Cerrar = new System.Windows.Forms.Button();
            this.Operando1Label = new System.Windows.Forms.Label();
            this.Operando2Label = new System.Windows.Forms.Label();
            this.SumaButton = new System.Windows.Forms.RadioButton();
            this.RestaButton = new System.Windows.Forms.RadioButton();
            this.MultiplicacionButton = new System.Windows.Forms.RadioButton();
            this.DivisionButton = new System.Windows.Forms.RadioButton();
            this.numero1 = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.Label();
            this.elegirNumero1Button = new System.Windows.Forms.Button();
            this.elegirNumero2Button = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(378, 469);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(76, 43);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Close);
            // 
            // Operando1Label
            // 
            this.Operando1Label.AutoSize = true;
            this.Operando1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Operando1Label.Location = new System.Drawing.Point(82, 68);
            this.Operando1Label.Name = "Operando1Label";
            this.Operando1Label.Size = new System.Drawing.Size(220, 31);
            this.Operando1Label.TabIndex = 1;
            this.Operando1Label.Text = "Primer Operando";
            // 
            // Operando2Label
            // 
            this.Operando2Label.AutoSize = true;
            this.Operando2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Operando2Label.Location = new System.Drawing.Point(512, 68);
            this.Operando2Label.Name = "Operando2Label";
            this.Operando2Label.Size = new System.Drawing.Size(249, 31);
            this.Operando2Label.TabIndex = 2;
            this.Operando2Label.Text = "Segundo Operando";
            // 
            // SumaButton
            // 
            this.SumaButton.AutoSize = true;
            this.SumaButton.Checked = true;
            this.SumaButton.Location = new System.Drawing.Point(392, 81);
            this.SumaButton.Name = "SumaButton";
            this.SumaButton.Size = new System.Drawing.Size(52, 17);
            this.SumaButton.TabIndex = 3;
            this.SumaButton.TabStop = true;
            this.SumaButton.Text = "Suma";
            this.SumaButton.UseVisualStyleBackColor = true;
            // 
            // RestaButton
            // 
            this.RestaButton.AutoSize = true;
            this.RestaButton.Location = new System.Drawing.Point(392, 105);
            this.RestaButton.Name = "RestaButton";
            this.RestaButton.Size = new System.Drawing.Size(53, 17);
            this.RestaButton.TabIndex = 4;
            this.RestaButton.Text = "Resta";
            this.RestaButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicacionButton
            // 
            this.MultiplicacionButton.AutoSize = true;
            this.MultiplicacionButton.Location = new System.Drawing.Point(392, 129);
            this.MultiplicacionButton.Name = "MultiplicacionButton";
            this.MultiplicacionButton.Size = new System.Drawing.Size(89, 17);
            this.MultiplicacionButton.TabIndex = 5;
            this.MultiplicacionButton.Text = "Multiplicacion";
            this.MultiplicacionButton.UseVisualStyleBackColor = true;
            // 
            // DivisionButton
            // 
            this.DivisionButton.AutoSize = true;
            this.DivisionButton.Location = new System.Drawing.Point(392, 153);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(62, 17);
            this.DivisionButton.TabIndex = 6;
            this.DivisionButton.Text = "Division";
            this.DivisionButton.UseVisualStyleBackColor = true;
            // 
            // numero1
            // 
            this.numero1.AutoSize = true;
            this.numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numero1.Location = new System.Drawing.Point(146, 197);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(54, 25);
            this.numero1.TabIndex = 7;
            this.numero1.Text = "------";
            // 
            // numero2
            // 
            this.numero2.AutoSize = true;
            this.numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numero2.Location = new System.Drawing.Point(612, 197);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(54, 25);
            this.numero2.TabIndex = 8;
            this.numero2.Text = "------";
            // 
            // elegirNumero1Button
            // 
            this.elegirNumero1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elegirNumero1Button.Location = new System.Drawing.Point(111, 236);
            this.elegirNumero1Button.Name = "elegirNumero1Button";
            this.elegirNumero1Button.Size = new System.Drawing.Size(128, 76);
            this.elegirNumero1Button.TabIndex = 9;
            this.elegirNumero1Button.Text = "Asignar Valor";
            this.elegirNumero1Button.UseVisualStyleBackColor = true;
            this.elegirNumero1Button.Click += new System.EventHandler(this.ElegirNumero1Button_Click);
            // 
            // elegirNumero2Button
            // 
            this.elegirNumero2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.elegirNumero2Button.Location = new System.Drawing.Point(576, 236);
            this.elegirNumero2Button.Name = "elegirNumero2Button";
            this.elegirNumero2Button.Size = new System.Drawing.Size(128, 76);
            this.elegirNumero2Button.TabIndex = 10;
            this.elegirNumero2Button.Text = "Asignar Valor";
            this.elegirNumero2Button.UseVisualStyleBackColor = true;
            this.elegirNumero2Button.Click += new System.EventHandler(this.ElegirNumero2Button_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.CalcularButton.Location = new System.Drawing.Point(325, 393);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(192, 70);
            this.CalcularButton.TabIndex = 11;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.resultadoLabel.Location = new System.Drawing.Point(63, 341);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(698, 49);
            this.resultadoLabel.TabIndex = 12;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.elegirNumero2Button);
            this.Controls.Add(this.elegirNumero1Button);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicacionButton);
            this.Controls.Add(this.RestaButton);
            this.Controls.Add(this.SumaButton);
            this.Controls.Add(this.Operando2Label);
            this.Controls.Add(this.Operando1Label);
            this.Controls.Add(this.Cerrar);
            this.Name = "OperacionesBasicas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label Operando1Label;
        private System.Windows.Forms.Label Operando2Label;
        private System.Windows.Forms.RadioButton SumaButton;
        private System.Windows.Forms.RadioButton RestaButton;
        private System.Windows.Forms.RadioButton MultiplicacionButton;
        private System.Windows.Forms.RadioButton DivisionButton;
        private System.Windows.Forms.Label numero1;
        private System.Windows.Forms.Label numero2;
        private System.Windows.Forms.Button elegirNumero1Button;
        private System.Windows.Forms.Button elegirNumero2Button;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label resultadoLabel;
    }
}