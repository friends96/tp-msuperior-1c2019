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
            this.SumarButton = new System.Windows.Forms.RadioButton();
            this.RestarButton = new System.Windows.Forms.RadioButton();
            this.MultiplicarButton = new System.Windows.Forms.RadioButton();
            this.DividirButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(368, 359);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(99, 43);
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
            // SumarButton
            // 
            this.SumarButton.AutoSize = true;
            this.SumarButton.Checked = true;
            this.SumarButton.Location = new System.Drawing.Point(392, 81);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(55, 17);
            this.SumarButton.TabIndex = 3;
            this.SumarButton.TabStop = true;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            // 
            // RestarButton
            // 
            this.RestarButton.AutoSize = true;
            this.RestarButton.Location = new System.Drawing.Point(392, 105);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(56, 17);
            this.RestarButton.TabIndex = 4;
            this.RestarButton.Text = "Restar";
            this.RestarButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.AutoSize = true;
            this.MultiplicarButton.Location = new System.Drawing.Point(392, 129);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(72, 17);
            this.MultiplicarButton.TabIndex = 5;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            // 
            // DividirButton
            // 
            this.DividirButton.AutoSize = true;
            this.DividirButton.Location = new System.Drawing.Point(392, 153);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(54, 17);
            this.DividirButton.TabIndex = 6;
            this.DividirButton.Text = "Dividir";
            this.DividirButton.UseVisualStyleBackColor = true;
            // 
            // OperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DividirButton);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.SumarButton);
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
        private System.Windows.Forms.RadioButton SumarButton;
        private System.Windows.Forms.RadioButton RestarButton;
        private System.Windows.Forms.RadioButton MultiplicarButton;
        private System.Windows.Forms.RadioButton DividirButton;
    }
}