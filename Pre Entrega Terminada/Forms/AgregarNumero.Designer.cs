namespace TP_Matematica_Superior_Demo
{
    partial class AgregarNumero
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
            this.piRadLabel = new System.Windows.Forms.Label();
            this.numericUpDownArgumento = new System.Windows.Forms.NumericUpDown();
            this.labelArgumento = new System.Windows.Forms.Label();
            this.labelModulo = new System.Windows.Forms.Label();
            this.numericUpDownModulo = new System.Windows.Forms.NumericUpDown();
            this.CambiarTipoNumeroButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.numericUpDownParteImaginaria = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParteReal = new System.Windows.Forms.NumericUpDown();
            this.labelParteImaginaria = new System.Windows.Forms.Label();
            this.labelParteReal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArgumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteImaginaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteReal)).BeginInit();
            this.SuspendLayout();
            // 
            // piRadLabel
            // 
            this.piRadLabel.AccessibleName = "formsPolar";
            this.piRadLabel.AutoSize = true;
            this.piRadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.piRadLabel.Location = new System.Drawing.Point(207, 158);
            this.piRadLabel.Name = "piRadLabel";
            this.piRadLabel.Size = new System.Drawing.Size(82, 25);
            this.piRadLabel.TabIndex = 19;
            this.piRadLabel.Text = "[PI Rad]";
            // 
            // numericUpDownArgumento
            // 
            this.numericUpDownArgumento.AccessibleName = "formsPolar";
            this.numericUpDownArgumento.DecimalPlaces = 2;
            this.numericUpDownArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownArgumento.Location = new System.Drawing.Point(298, 156);
            this.numericUpDownArgumento.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownArgumento.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownArgumento.Name = "numericUpDownArgumento";
            this.numericUpDownArgumento.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownArgumento.TabIndex = 18;
            // 
            // labelArgumento
            // 
            this.labelArgumento.AccessibleName = "formsPolar";
            this.labelArgumento.AutoSize = true;
            this.labelArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArgumento.Location = new System.Drawing.Point(94, 158);
            this.labelArgumento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelArgumento.Name = "labelArgumento";
            this.labelArgumento.Size = new System.Drawing.Size(104, 24);
            this.labelArgumento.TabIndex = 17;
            this.labelArgumento.Text = "Argumento";
            // 
            // labelModulo
            // 
            this.labelModulo.AccessibleName = "formsPolar";
            this.labelModulo.AutoSize = true;
            this.labelModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModulo.Location = new System.Drawing.Point(94, 93);
            this.labelModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelModulo.Name = "labelModulo";
            this.labelModulo.Size = new System.Drawing.Size(74, 24);
            this.labelModulo.TabIndex = 16;
            this.labelModulo.Text = "Modulo";
            // 
            // numericUpDownModulo
            // 
            this.numericUpDownModulo.AccessibleName = "formsPolar";
            this.numericUpDownModulo.DecimalPlaces = 2;
            this.numericUpDownModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownModulo.Location = new System.Drawing.Point(298, 88);
            this.numericUpDownModulo.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownModulo.Name = "numericUpDownModulo";
            this.numericUpDownModulo.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownModulo.TabIndex = 15;
            // 
            // CambiarTipoNumeroButton
            // 
            this.CambiarTipoNumeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CambiarTipoNumeroButton.Location = new System.Drawing.Point(212, 246);
            this.CambiarTipoNumeroButton.Name = "CambiarTipoNumeroButton";
            this.CambiarTipoNumeroButton.Size = new System.Drawing.Size(177, 33);
            this.CambiarTipoNumeroButton.TabIndex = 20;
            this.CambiarTipoNumeroButton.Text = "a Binomico";
            this.CambiarTipoNumeroButton.UseVisualStyleBackColor = true;
            this.CambiarTipoNumeroButton.Click += new System.EventHandler(this.CambiarTipoNumeroButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.okButton.Location = new System.Drawing.Point(239, 333);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(113, 81);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // numericUpDownParteImaginaria
            // 
            this.numericUpDownParteImaginaria.DecimalPlaces = 2;
            this.numericUpDownParteImaginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownParteImaginaria.Location = new System.Drawing.Point(298, 152);
            this.numericUpDownParteImaginaria.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownParteImaginaria.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParteImaginaria.Name = "numericUpDownParteImaginaria";
            this.numericUpDownParteImaginaria.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownParteImaginaria.TabIndex = 25;
            this.numericUpDownParteImaginaria.Visible = false;
            // 
            // numericUpDownParteReal
            // 
            this.numericUpDownParteReal.DecimalPlaces = 2;
            this.numericUpDownParteReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownParteReal.Location = new System.Drawing.Point(298, 91);
            this.numericUpDownParteReal.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownParteReal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParteReal.Name = "numericUpDownParteReal";
            this.numericUpDownParteReal.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownParteReal.TabIndex = 24;
            this.numericUpDownParteReal.Visible = false;
            // 
            // labelParteImaginaria
            // 
            this.labelParteImaginaria.AutoSize = true;
            this.labelParteImaginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteImaginaria.Location = new System.Drawing.Point(94, 154);
            this.labelParteImaginaria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParteImaginaria.Name = "labelParteImaginaria";
            this.labelParteImaginaria.Size = new System.Drawing.Size(144, 24);
            this.labelParteImaginaria.TabIndex = 23;
            this.labelParteImaginaria.Text = "Parte Imaginaria";
            this.labelParteImaginaria.Visible = false;
            // 
            // labelParteReal
            // 
            this.labelParteReal.AutoSize = true;
            this.labelParteReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteReal.Location = new System.Drawing.Point(94, 93);
            this.labelParteReal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParteReal.Name = "labelParteReal";
            this.labelParteReal.Size = new System.Drawing.Size(96, 24);
            this.labelParteReal.TabIndex = 22;
            this.labelParteReal.Text = "Parte Real";
            this.labelParteReal.Visible = false;
            // 
            // AgregarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.numericUpDownParteImaginaria);
            this.Controls.Add(this.numericUpDownParteReal);
            this.Controls.Add(this.labelParteImaginaria);
            this.Controls.Add(this.labelParteReal);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.CambiarTipoNumeroButton);
            this.Controls.Add(this.piRadLabel);
            this.Controls.Add(this.numericUpDownArgumento);
            this.Controls.Add(this.labelArgumento);
            this.Controls.Add(this.labelModulo);
            this.Controls.Add(this.numericUpDownModulo);
            this.Name = "AgregarNumero";
            this.Text = "AgregarNumero";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArgumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteImaginaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteReal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label piRadLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownArgumento;
        private System.Windows.Forms.Label labelArgumento;
        private System.Windows.Forms.Label labelModulo;
        private System.Windows.Forms.NumericUpDown numericUpDownModulo;
        private System.Windows.Forms.Button CambiarTipoNumeroButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown numericUpDownParteImaginaria;
        private System.Windows.Forms.NumericUpDown numericUpDownParteReal;
        private System.Windows.Forms.Label labelParteImaginaria;
        private System.Windows.Forms.Label labelParteReal;
    }
}