namespace TP_Matematica_Superior_Demo
{
    partial class Home
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
            this.OperacionesBasicas = new System.Windows.Forms.Button();
            this.OperacionesAvanzadas = new System.Windows.Forms.Button();
            this.SumaFasores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OperacionesBasicas
            // 
            this.OperacionesBasicas.Location = new System.Drawing.Point(302, 37);
            this.OperacionesBasicas.Name = "OperacionesBasicas";
            this.OperacionesBasicas.Size = new System.Drawing.Size(234, 64);
            this.OperacionesBasicas.TabIndex = 0;
            this.OperacionesBasicas.Text = "Operaciones Basicas";
            this.OperacionesBasicas.UseVisualStyleBackColor = true;
            this.OperacionesBasicas.Click += new System.EventHandler(this.OperacionesBasicas_Click);
            // 
            // OperacionesAvanzadas
            // 
            this.OperacionesAvanzadas.Location = new System.Drawing.Point(303, 128);
            this.OperacionesAvanzadas.Name = "OperacionesAvanzadas";
            this.OperacionesAvanzadas.Size = new System.Drawing.Size(232, 62);
            this.OperacionesAvanzadas.TabIndex = 1;
            this.OperacionesAvanzadas.Text = "Operaciones Avanzadas";
            this.OperacionesAvanzadas.UseVisualStyleBackColor = true;
            this.OperacionesAvanzadas.Click += new System.EventHandler(this.OperacionesAvanzadas_Click);
            // 
            // SumaFasores
            // 
            this.SumaFasores.Location = new System.Drawing.Point(305, 218);
            this.SumaFasores.Name = "SumaFasores";
            this.SumaFasores.Size = new System.Drawing.Size(230, 66);
            this.SumaFasores.TabIndex = 2;
            this.SumaFasores.Text = "Suma Fasores";
            this.SumaFasores.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumaFasores);
            this.Controls.Add(this.OperacionesAvanzadas);
            this.Controls.Add(this.OperacionesBasicas);
            this.Name = "Home";
            this.Text = "NCOM";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OperacionesBasicas;
        private System.Windows.Forms.Button OperacionesAvanzadas;
        private System.Windows.Forms.Button SumaFasores;
    }
}