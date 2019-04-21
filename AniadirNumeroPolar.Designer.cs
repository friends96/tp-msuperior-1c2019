namespace TP_Matematica_Superior_Demo
{
    partial class AniadirNumeroPolar
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
            this.numericUpDownModulo = new System.Windows.Forms.NumericUpDown();
            this.labelModulo = new System.Windows.Forms.Label();
            this.labelArgumento = new System.Windows.Forms.Label();
            this.numericUpDownArgumento = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBinomicoAMostrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArgumento)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownModulo
            // 
            this.numericUpDownModulo.DecimalPlaces = 2;
            this.numericUpDownModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownModulo.Location = new System.Drawing.Point(250, 88);
            this.numericUpDownModulo.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownModulo.Name = "numericUpDownModulo";
            this.numericUpDownModulo.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownModulo.TabIndex = 10;
            // 
            // labelModulo
            // 
            this.labelModulo.AutoSize = true;
            this.labelModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModulo.Location = new System.Drawing.Point(46, 93);
            this.labelModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelModulo.Name = "labelModulo";
            this.labelModulo.Size = new System.Drawing.Size(74, 24);
            this.labelModulo.TabIndex = 11;
            this.labelModulo.Text = "Modulo";
            // 
            // labelArgumento
            // 
            this.labelArgumento.AutoSize = true;
            this.labelArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArgumento.Location = new System.Drawing.Point(46, 158);
            this.labelArgumento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelArgumento.Name = "labelArgumento";
            this.labelArgumento.Size = new System.Drawing.Size(104, 24);
            this.labelArgumento.TabIndex = 12;
            this.labelArgumento.Text = "Argumento";
            // 
            // numericUpDownArgumento
            // 
            this.numericUpDownArgumento.DecimalPlaces = 2;
            this.numericUpDownArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.numericUpDownArgumento.Location = new System.Drawing.Point(250, 156);
            this.numericUpDownArgumento.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownArgumento.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownArgumento.Name = "numericUpDownArgumento";
            this.numericUpDownArgumento.Size = new System.Drawing.Size(220, 29);
            this.numericUpDownArgumento.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F);
            this.label1.Location = new System.Drawing.Point(159, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "[PI Rad]";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(50, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Convertir a Binomico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Forma Binomica";
            // 
            // labelBinomicoAMostrar
            // 
            this.labelBinomicoAMostrar.AutoSize = true;
            this.labelBinomicoAMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinomicoAMostrar.Location = new System.Drawing.Point(217, 295);
            this.labelBinomicoAMostrar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBinomicoAMostrar.Name = "labelBinomicoAMostrar";
            this.labelBinomicoAMostrar.Size = new System.Drawing.Size(16, 24);
            this.labelBinomicoAMostrar.TabIndex = 17;
            this.labelBinomicoAMostrar.Text = "-";
            // 
            // AniadirNumeroPolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.labelBinomicoAMostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownArgumento);
            this.Controls.Add(this.labelArgumento);
            this.Controls.Add(this.labelModulo);
            this.Controls.Add(this.numericUpDownModulo);
            this.Name = "AniadirNumeroPolar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArgumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownModulo;
        private System.Windows.Forms.Label labelModulo;
        private System.Windows.Forms.Label labelArgumento;
        private System.Windows.Forms.NumericUpDown numericUpDownArgumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBinomicoAMostrar;
    }
}