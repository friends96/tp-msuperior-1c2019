namespace TP_Matematica_Superior_Demo
{
    partial class FormBasico
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
            this.labelParteReal = new System.Windows.Forms.Label();
            this.labelParteImaginaria = new System.Windows.Forms.Label();
            this.labelFormaPolar = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labelNumeroEnFormaPolar = new System.Windows.Forms.Label();
            this.numericUpDownParteReal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParteImaginaria = new System.Windows.Forms.NumericUpDown();
            this.switchForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteImaginaria)).BeginInit();
            this.SuspendLayout();
            // 
            // labelParteReal
            // 
            this.labelParteReal.AutoSize = true;
            this.labelParteReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteReal.Location = new System.Drawing.Point(53, 53);
            this.labelParteReal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParteReal.Name = "labelParteReal";
            this.labelParteReal.Size = new System.Drawing.Size(96, 24);
            this.labelParteReal.TabIndex = 2;
            this.labelParteReal.Text = "Parte Real";
            // 
            // labelParteImaginaria
            // 
            this.labelParteImaginaria.AutoSize = true;
            this.labelParteImaginaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteImaginaria.Location = new System.Drawing.Point(53, 114);
            this.labelParteImaginaria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelParteImaginaria.Name = "labelParteImaginaria";
            this.labelParteImaginaria.Size = new System.Drawing.Size(144, 24);
            this.labelParteImaginaria.TabIndex = 3;
            this.labelParteImaginaria.Text = "Parte Imaginaria";
            // 
            // labelFormaPolar
            // 
            this.labelFormaPolar.AutoSize = true;
            this.labelFormaPolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaPolar.Location = new System.Drawing.Point(53, 271);
            this.labelFormaPolar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFormaPolar.Name = "labelFormaPolar";
            this.labelFormaPolar.Size = new System.Drawing.Size(113, 24);
            this.labelFormaPolar.TabIndex = 5;
            this.labelFormaPolar.Text = "Forma Polar";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(57, 178);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(171, 42);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Convertir a Polar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // labelNumeroEnFormaPolar
            // 
            this.labelNumeroEnFormaPolar.AutoSize = true;
            this.labelNumeroEnFormaPolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEnFormaPolar.Location = new System.Drawing.Point(271, 271);
            this.labelNumeroEnFormaPolar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumeroEnFormaPolar.Name = "labelNumeroEnFormaPolar";
            this.labelNumeroEnFormaPolar.Size = new System.Drawing.Size(16, 24);
            this.labelNumeroEnFormaPolar.TabIndex = 8;
            this.labelNumeroEnFormaPolar.Text = "-";
            // 
            // numericUpDownParteReal
            // 
            this.numericUpDownParteReal.DecimalPlaces = 2;
            this.numericUpDownParteReal.Location = new System.Drawing.Point(257, 51);
            this.numericUpDownParteReal.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownParteReal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParteReal.Name = "numericUpDownParteReal";
            this.numericUpDownParteReal.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownParteReal.TabIndex = 9;
            // 
            // numericUpDownParteImaginaria
            // 
            this.numericUpDownParteImaginaria.DecimalPlaces = 2;
            this.numericUpDownParteImaginaria.Location = new System.Drawing.Point(257, 112);
            this.numericUpDownParteImaginaria.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownParteImaginaria.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownParteImaginaria.Name = "numericUpDownParteImaginaria";
            this.numericUpDownParteImaginaria.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownParteImaginaria.TabIndex = 10;
            // 
            // switchForm
            // 
            this.switchForm.Location = new System.Drawing.Point(309, 162);
            this.switchForm.Name = "switchForm";
            this.switchForm.Size = new System.Drawing.Size(149, 75);
            this.switchForm.TabIndex = 11;
            this.switchForm.Text = "switchForm";
            this.switchForm.UseVisualStyleBackColor = true;
            this.switchForm.Click += new System.EventHandler(this.SwitchForm_Click);
            // 
            // FormBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 380);
            this.Controls.Add(this.switchForm);
            this.Controls.Add(this.numericUpDownParteImaginaria);
            this.Controls.Add(this.numericUpDownParteReal);
            this.Controls.Add(this.labelNumeroEnFormaPolar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labelFormaPolar);
            this.Controls.Add(this.labelParteImaginaria);
            this.Controls.Add(this.labelParteReal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormBasico";
            this.Text = "FormBasico";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParteImaginaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParteReal;
        private System.Windows.Forms.Label labelParteImaginaria;
        private System.Windows.Forms.Label labelFormaPolar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label labelNumeroEnFormaPolar;
        private System.Windows.Forms.NumericUpDown numericUpDownParteReal;
        private System.Windows.Forms.NumericUpDown numericUpDownParteImaginaria;
        private System.Windows.Forms.Button switchForm;
    }
}

