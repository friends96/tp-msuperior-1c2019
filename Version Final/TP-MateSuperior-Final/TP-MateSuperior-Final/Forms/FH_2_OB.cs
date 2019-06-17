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
    public partial class FH_2_OB : Form
    {
        public FH_2_OB()
        {
            InitializeComponent();
        }
        //===========================================================
        //private NComplejo c1 { get; set; }
        //private NComplejo c2 { get; set; }
        private NComplejo c1 = new NComplejo();
        private NComplejo c2 = new NComplejo();

        public double real, img, modulo, argumento;
        
        public int numerosIngresados = 0;
        public int operando = 0;
        //===========================================================

        public string mensaje { get; set; } // Aca se guarda lo que se controla desde el HIJO
        private void BtnCarga1_Click(object sender, EventArgs e)
        {
            operando = 1;
            FCargaCpmlejo frmHIJO = new FCargaCpmlejo();
            real = 0;
            img = 0;
            //frmHIJO.textBox1.Text = "Contenido de Padre >>> Hijo";

            AddOwnedForm(frmHIJO);
            frmHIJO.ShowDialog();

            c1.RELOAD("REAL", real);
            c1.RELOAD("IMG", img);

            //labelResultado.Text = mensaje;
        }

        private void BtnCarga2_Click(object sender, EventArgs e)
        {
            operando = 2;
            FCargaCpmlejo formHIJO = new FCargaCpmlejo();
            real = 0;
            img = 0;

            AddOwnedForm(formHIJO);
            formHIJO.ShowDialog();
            
            c2.RELOAD("REAL", real);
            c2.RELOAD("IMG", img);

            MessageBox.Show($"REAL = {c2.REAL}\nIMG = {c2.IMG}");
        }
    }
}
