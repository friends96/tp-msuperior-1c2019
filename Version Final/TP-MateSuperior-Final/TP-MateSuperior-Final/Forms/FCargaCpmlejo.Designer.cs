namespace TP_MateSuperior_Final.Forms
{
    partial class FCargaCpmlejo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEleccion1 = new System.Windows.Forms.Button();
            this.textREAL = new System.Windows.Forms.TextBox();
            this.textIMG = new System.Windows.Forms.TextBox();
            this.labelIMG = new System.Windows.Forms.Label();
            this.labelREAL = new System.Windows.Forms.Label();
            this.panelBinomica = new System.Windows.Forms.Panel();
            this.btnEleccion2 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelPolar = new System.Windows.Forms.Panel();
            this.labelAngulo = new System.Windows.Forms.Label();
            this.btnAngulo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textArgumento = new System.Windows.Forms.TextBox();
            this.textModulo = new System.Windows.Forms.TextBox();
            this.panelBinomica.SuspendLayout();
            this.panelPolar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(57, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(274, 49);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEleccion1
            // 
            this.btnEleccion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEleccion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEleccion1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEleccion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEleccion1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleccion1.ForeColor = System.Drawing.Color.White;
            this.btnEleccion1.Location = new System.Drawing.Point(57, 48);
            this.btnEleccion1.Name = "btnEleccion1";
            this.btnEleccion1.Size = new System.Drawing.Size(137, 49);
            this.btnEleccion1.TabIndex = 9;
            this.btnEleccion1.Text = "BINÓMICA";
            this.btnEleccion1.UseVisualStyleBackColor = false;
            this.btnEleccion1.Click += new System.EventHandler(this.BtnEleccion1_Click);
            // 
            // textREAL
            // 
            this.textREAL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textREAL.Location = new System.Drawing.Point(133, 17);
            this.textREAL.Name = "textREAL";
            this.textREAL.Size = new System.Drawing.Size(126, 31);
            this.textREAL.TabIndex = 0;
            this.textREAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textREAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextREAL_KeyPress);
            // 
            // textIMG
            // 
            this.textIMG.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIMG.Location = new System.Drawing.Point(133, 59);
            this.textIMG.Name = "textIMG";
            this.textIMG.Size = new System.Drawing.Size(126, 31);
            this.textIMG.TabIndex = 4;
            this.textIMG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIMG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextIMG_KeyPress);
            // 
            // labelIMG
            // 
            this.labelIMG.AutoSize = true;
            this.labelIMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMG.ForeColor = System.Drawing.Color.White;
            this.labelIMG.Location = new System.Drawing.Point(16, 64);
            this.labelIMG.Name = "labelIMG";
            this.labelIMG.Size = new System.Drawing.Size(98, 20);
            this.labelIMG.TabIndex = 2;
            this.labelIMG.Text = "Imaginaria:";
            // 
            // labelREAL
            // 
            this.labelREAL.AutoSize = true;
            this.labelREAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelREAL.ForeColor = System.Drawing.Color.White;
            this.labelREAL.Location = new System.Drawing.Point(16, 22);
            this.labelREAL.Name = "labelREAL";
            this.labelREAL.Size = new System.Drawing.Size(51, 20);
            this.labelREAL.TabIndex = 1;
            this.labelREAL.Text = "Real:";
            // 
            // panelBinomica
            // 
            this.panelBinomica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBinomica.Controls.Add(this.labelREAL);
            this.panelBinomica.Controls.Add(this.labelIMG);
            this.panelBinomica.Controls.Add(this.textIMG);
            this.panelBinomica.Controls.Add(this.textREAL);
            this.panelBinomica.Location = new System.Drawing.Point(57, 115);
            this.panelBinomica.Name = "panelBinomica";
            this.panelBinomica.Size = new System.Drawing.Size(274, 119);
            this.panelBinomica.TabIndex = 6;
            // 
            // btnEleccion2
            // 
            this.btnEleccion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEleccion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEleccion2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEleccion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEleccion2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleccion2.ForeColor = System.Drawing.Color.White;
            this.btnEleccion2.Location = new System.Drawing.Point(194, 48);
            this.btnEleccion2.Name = "btnEleccion2";
            this.btnEleccion2.Size = new System.Drawing.Size(137, 49);
            this.btnEleccion2.TabIndex = 10;
            this.btnEleccion2.Text = "POLAR";
            this.btnEleccion2.UseVisualStyleBackColor = false;
            this.btnEleccion2.Click += new System.EventHandler(this.BtnEleccion2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(348, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 36);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelPolar
            // 
            this.panelPolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPolar.Controls.Add(this.labelAngulo);
            this.panelPolar.Controls.Add(this.btnAngulo);
            this.panelPolar.Controls.Add(this.label8);
            this.panelPolar.Controls.Add(this.label9);
            this.panelPolar.Controls.Add(this.textArgumento);
            this.panelPolar.Controls.Add(this.textModulo);
            this.panelPolar.Location = new System.Drawing.Point(57, 115);
            this.panelPolar.Name = "panelPolar";
            this.panelPolar.Size = new System.Drawing.Size(274, 119);
            this.panelPolar.TabIndex = 12;
            this.panelPolar.Visible = false;
            // 
            // labelAngulo
            // 
            this.labelAngulo.AutoSize = true;
            this.labelAngulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAngulo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngulo.ForeColor = System.Drawing.Color.White;
            this.labelAngulo.Location = new System.Drawing.Point(27, 84);
            this.labelAngulo.Name = "labelAngulo";
            this.labelAngulo.Size = new System.Drawing.Size(49, 18);
            this.labelAngulo.TabIndex = 15;
            this.labelAngulo.Text = "( rad )";
            // 
            // btnAngulo
            // 
            this.btnAngulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAngulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAngulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAngulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAngulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngulo.ForeColor = System.Drawing.Color.White;
            this.btnAngulo.Location = new System.Drawing.Point(221, 59);
            this.btnAngulo.Name = "btnAngulo";
            this.btnAngulo.Size = new System.Drawing.Size(38, 31);
            this.btnAngulo.TabIndex = 13;
            this.btnAngulo.Text = "π";
            this.btnAngulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAngulo.UseVisualStyleBackColor = false;
            this.btnAngulo.Click += new System.EventHandler(this.BtnAngulo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Módulo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Argumento:";
            // 
            // textArgumento
            // 
            this.textArgumento.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArgumento.Location = new System.Drawing.Point(133, 59);
            this.textArgumento.Name = "textArgumento";
            this.textArgumento.Size = new System.Drawing.Size(82, 31);
            this.textArgumento.TabIndex = 4;
            this.textArgumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textArgumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextArgumento_KeyPress);
            // 
            // textModulo
            // 
            this.textModulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModulo.Location = new System.Drawing.Point(133, 17);
            this.textModulo.Name = "textModulo";
            this.textModulo.Size = new System.Drawing.Size(126, 31);
            this.textModulo.TabIndex = 3;
            this.textModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textModulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextModulo_KeyPress);
            // 
            // FCargaCpmlejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(388, 350);
            this.Controls.Add(this.panelPolar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEleccion2);
            this.Controls.Add(this.btnEleccion1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelBinomica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCargaCpmlejo";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FCargaCpmlejo";
            this.panelBinomica.ResumeLayout(false);
            this.panelBinomica.PerformLayout();
            this.panelPolar.ResumeLayout(false);
            this.panelPolar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEleccion1;
        private System.Windows.Forms.TextBox textREAL;
        private System.Windows.Forms.TextBox textIMG;
        private System.Windows.Forms.Label labelIMG;
        private System.Windows.Forms.Label labelREAL;
        private System.Windows.Forms.Panel panelBinomica;
        private System.Windows.Forms.Button btnEleccion2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelPolar;
        private System.Windows.Forms.Label labelAngulo;
        private System.Windows.Forms.Button btnAngulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textArgumento;
        private System.Windows.Forms.TextBox textModulo;
    }
}