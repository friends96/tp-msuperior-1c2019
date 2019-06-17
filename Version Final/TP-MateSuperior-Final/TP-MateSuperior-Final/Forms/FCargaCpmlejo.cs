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
using TP_MateSuperior_Final.Servicios;

namespace TP_MateSuperior_Final.Forms
{
    public partial class FCargaCpmlejo : Form
    {
        public FCargaCpmlejo()
        {
            InitializeComponent();
        }

        //================================================
        public string MODO { get; set; }
        public int conradorIngreso { get; set; }
        private NComplejo c1 { get; set; }

        private double anguloFormato = Math.PI;
        private string normalizado_real, normalizado_imaginario;
        private string normalizado_modulo, normalizado_argumetno;

        //HERRAMIENTAS
        private ValidarDatos validador = new ValidarDatos();
        private ServicesREPORT REPORTE = new ServicesREPORT();
        private NComplejo nulo = new NComplejo();

        //================================================
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEleccion1_Click(object sender, EventArgs e)
        {
            btnEleccion1.BackColor = Color.FromArgb(0, 80, 200);
            btnEleccion2.BackColor = Color.FromArgb(26, 32, 40);
            MODO = "BIN";
            panelPolar.Visible = false;
            panelBinomica.Visible = true;
        }

        private void BtnEleccion2_Click(object sender, EventArgs e)
        {
            btnEleccion1.BackColor = Color.FromArgb(26, 32, 40);
            btnEleccion2.BackColor = Color.FromArgb(0, 80, 200);
            MODO = "POLAR";
            panelPolar.Visible = true;
            panelBinomica.Visible = false;
        }

        private void TextREAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void TextIMG_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void TextModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_ENTERO_Positivo(e);
        }

        private void TextArgumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validador.TEXTO_EsDecimalValido(textREAL.Text) && validador.TEXTO_EsDecimalValido(textIMG.Text))
            {
                FH_2_OB frmPadre = this.Owner as FH_2_OB;

                normalizado_real = validador.TEXTO_Normalizado(textREAL.Text);
                normalizado_imaginario = validador.TEXTO_Normalizado(textIMG.Text);

                double real;
                double img;

                if (textREAL.Text == "") real = 0;
                else real = Convert.ToDouble(normalizado_real);
                if (textIMG.Text == "") img = 0;
                else img = Convert.ToDouble(normalizado_imaginario);

                NComplejo complejo2 = new NComplejo(real, img, "BIN");

                REPORTE.TEXTBOX_esValido(textREAL, "OK");
                REPORTE.TEXTBOX_esValido(textIMG, "OK");
                REPORTE.BOTON_Complejo(complejo2, frmPadre.btnCargado2, "BIN");

                frmPadre.btnCargado2.BackColor = Color.FromArgb(49, 66, 82);
                frmPadre.real = complejo2.REAL;
                frmPadre.img = complejo2.IMG;
                frmPadre.btnCargado2.Visible = true;
                frmPadre.btnCarga2.Visible = false;

                this.Close();
            }
            else
            {
                if(validador.TEXTO_EsDecimalValido(textREAL.Text)) REPORTE.TEXTBOX_esValido(textREAL, "OK");
                else REPORTE.TEXTBOX_esValido(textREAL, "INVALIDO");

                if (validador.TEXTO_EsDecimalValido(textIMG.Text)) REPORTE.TEXTBOX_esValido(textIMG, "OK");
                else REPORTE.TEXTBOX_esValido(textIMG, "INVALIDO");

                //REPORTE.BOTON_Complejo(nulo, btnReporte1, "ERROR");
                MessageBox.Show("El DATO ingresado NO es Válido");
            }
        }
    }
}
