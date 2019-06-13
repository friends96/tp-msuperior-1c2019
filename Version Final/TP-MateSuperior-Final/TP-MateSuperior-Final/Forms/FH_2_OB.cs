using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MateSuperior_Final.Forms
{
    public partial class FH_2_OB : Form
    {
        public FH_2_OB()
        {
            InitializeComponent();
        }

        public string mensaje { get; set; }
        private void BtnCarga1_Click(object sender, EventArgs e)
        {
            FormCargaComplejo frmHIJO = new FormCargaComplejo();
            frmHIJO.textBox1.Text = "Contenido de Padre >>> Hijo";

            AddOwnedForm(frmHIJO);
            frmHIJO.ShowDialog();

            labelResultado.Text = mensaje;
        }
    }
}
