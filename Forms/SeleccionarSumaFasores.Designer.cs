namespace TP_Matematica_Superior_Demo.Forms
{
    partial class SeleccionarSumaFasores
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
            this.labelFasor1 = new System.Windows.Forms.Label();
            this.lblFasor2 = new System.Windows.Forms.Label();
            this.btnFasor1 = new System.Windows.Forms.Button();
            this.btnFasor2 = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFasor1
            // 
            this.labelFasor1.AutoSize = true;
            this.labelFasor1.Location = new System.Drawing.Point(130, 72);
            this.labelFasor1.Name = "labelFasor1";
            this.labelFasor1.Size = new System.Drawing.Size(28, 13);
            this.labelFasor1.TabIndex = 0;
            this.labelFasor1.Text = "-------";
            // 
            // lblFasor2
            // 
            this.lblFasor2.AutoSize = true;
            this.lblFasor2.Location = new System.Drawing.Point(474, 72);
            this.lblFasor2.Name = "lblFasor2";
            this.lblFasor2.Size = new System.Drawing.Size(22, 13);
            this.lblFasor2.TabIndex = 1;
            this.lblFasor2.Text = "-----";
            // 
            // btnFasor1
            // 
            this.btnFasor1.Location = new System.Drawing.Point(83, 32);
            this.btnFasor1.Name = "btnFasor1";
            this.btnFasor1.Size = new System.Drawing.Size(110, 23);
            this.btnFasor1.TabIndex = 2;
            this.btnFasor1.Text = "Elegir Fasor 1";
            this.btnFasor1.UseVisualStyleBackColor = true;
            // 
            // btnFasor2
            // 
            this.btnFasor2.Location = new System.Drawing.Point(437, 32);
            this.btnFasor2.Name = "btnFasor2";
            this.btnFasor2.Size = new System.Drawing.Size(97, 23);
            this.btnFasor2.TabIndex = 3;
            this.btnFasor2.Text = "Elegir Fasor 2";
            this.btnFasor2.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSumar.Location = new System.Drawing.Point(276, 273);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(151, 56);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(337, 348);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(22, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "-----";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(359, 198);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 6;
            // 
            // SeleccionarSumaFasores
            // 
            this.ClientSize = new System.Drawing.Size(779, 478);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnFasor2);
            this.Controls.Add(this.btnFasor1);
            this.Controls.Add(this.lblFasor2);
            this.Controls.Add(this.labelFasor1);
            this.Name = "SeleccionarSumaFasores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFasor1;
        private System.Windows.Forms.Label lblFasor2;
        private System.Windows.Forms.Button btnFasor1;
        private System.Windows.Forms.Button btnFasor2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}
