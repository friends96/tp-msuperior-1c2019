using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Matematica_Superior_Demo.Clases;
using TP_Matematica_Superior_Demo.Services;

namespace TP_Matematica_Superior_Demo.Forms
{
    public partial class SeleccionarSumaFunciones : Form
    {
        private NComplejo complejo1 { get; set; }
        private NComplejo complejo2 { get; set; }
        private NComplejo resultado { get; set; }

        private Operador Servicio = new Operador();

        public SeleccionarSumaFunciones()
        {
            InitializeComponent();
            this.CenterToScreen();
            //txtBoxModulo1.Focus();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSumarFasores(object sender, EventArgs e)
        {
            Fasoriando();
        }

        private void Fasoriando()
        {
            if(txtBoxPulso1.Text == txtBoxPulso2.Text)
            {
                linkLabel1.Visible = true;
                NComplejo fasor1 = new NComplejo(Convert.ToDouble(txtBoxModulo1.Text), Convert.ToDouble(txtBoxArgumento1.Text), "POLAR");
                NComplejo fasor2 = new NComplejo(Convert.ToDouble(txtBoxModulo2.Text), Convert.ToDouble(txtBoxArgumento2.Text), "POLAR");
                NComplejo fasorFinal = new NComplejo();

                fasorFinal = Servicio.Sumar(fasor1, fasor2);

                //Asignando
                complejo1 = fasor1;
                complejo2 = fasor2;
                resultado = fasorFinal;

                lblReporteFinal.Text = $"f1 + f2 = {Math.Round(fasorFinal.modulo, 3)} sen( {txtBoxPulso1.Text} X  + {Math.Round(fasorFinal.argumento, 4)} )";
            }
            else
            {
                linkLabel1.Visible = false;
                lblReporteFinal.Text = "---";
                MessageBox.Show("Frecuencias Diferentes!!!!!\nNo es posible realizar la suma");
            }
            
        }

        private void SeleccionarSumaFunciones_Load(object sender, EventArgs e)
        {
            //txtBoxModulo1.Focus();
            this.ActiveControl = txtBoxModulo1;
        }

        private void TxtBoxModulo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtBoxPulso1.Focus();
            }
        }

        private void TxtBoxPulso1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtBoxArgumento1.Focus();
            }
        }

        private void TxtBoxArgumento1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtBoxModulo2.Focus();
            }
        }

        private void TxtBoxModulo2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtBoxPulso2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtBoxArgumento2.Focus();
            }
        }

        private void TxtBoxModulo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtBoxPulso2.Focus();
            }
        }

        private void TxtBoxArgumento2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.Focus();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Servicio.REPORTARfasores(complejo1, complejo2, resultado);
        }
    }
}
