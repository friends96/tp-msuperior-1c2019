using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_MateSuperior_Final.Clases;

namespace TP_MateSuperior_Final.Forms
{
    public partial class FormCargaComplejo : Form
    {
        public FormCargaComplejo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FH_2_OB frmPadre = this.Owner as FH_2_OB;

            frmPadre.mensaje = textBox1.Text;
            frmPadre.btnCargado1.Visible = true;
            frmPadre.btnCargado1.Text = textBox1.Text;
            frmPadre.btnCarga1.Visible = false;

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
