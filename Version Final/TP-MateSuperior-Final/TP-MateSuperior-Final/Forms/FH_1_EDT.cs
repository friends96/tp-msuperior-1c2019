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
    public partial class FH_1_EDT : Form
    {
        public FH_1_EDT()
        {
            InitializeComponent();
        }

        //Declarando Objetos y Servicios ===========================================================

        private ValidarDatos validador = new ValidarDatos();
        private ServicesREPORT REPORTE = new ServicesREPORT();
        private NComplejo nulo = new NComplejo();

        private string normalizado_real, normalizado_imaginario;
        private string normalizado_modulo, normalizado_argumetno;
        private double numero;

        // ======================================================================================

        private void TextReal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void TextImaginario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void TextModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_ENTERO_Positivo(e);
        }

        private void BtnConvertir2_Click(object sender, EventArgs e)
        {
            if (validador.TEXTO_EsDecimalValido(textModulo.Text) && validador.TEXTO_EsDecimalValido(textArgumento.Text))
            {
                normalizado_modulo = validador.TEXTO_Normalizado(textModulo.Text); // Cambia '.' por ','
                normalizado_argumetno = validador.TEXTO_Normalizado(textArgumento.Text);
                double modulo;
                double argumetno;

                if (textModulo.Text == "") modulo = 0;
                else modulo = Convert.ToDouble(normalizado_modulo);
                if (textArgumento.Text == "") argumetno = 0;
                else argumetno = Convert.ToDouble(normalizado_argumetno);

                NComplejo complejo2 = new NComplejo(modulo, argumetno*Math.PI, "POLAR");

                REPORTE.TEXTBOX_esValido(textModulo, "OK");
                REPORTE.TEXTBOX_esValido(textArgumento, "OK");
                REPORTE.BOTON_Complejo(complejo2, btnReporte2, "BIN");
            }
            else
            {
                if (validador.TEXTO_EsDecimalValido(textModulo.Text)) REPORTE.TEXTBOX_esValido(textModulo, "OK");
                else REPORTE.TEXTBOX_esValido(textModulo, "INVALIDO");

                if (validador.TEXTO_EsDecimalValido(textArgumento.Text)) REPORTE.TEXTBOX_esValido(textArgumento, "OK");
                else REPORTE.TEXTBOX_esValido(textArgumento, "INVALIDO");

                REPORTE.BOTON_Complejo(nulo, btnReporte2, "ERROR");
                MessageBox.Show("El DATO ingresado NO es Válido");
            }
        }

        private void TextArgumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void BtnConvertir1_Click(object sender, EventArgs e)
        {
            // Valida
            if (validador.TEXTO_EsDecimalValido(textReal.Text) && validador.TEXTO_EsDecimalValido(textImaginario.Text)) 
            {
                normalizado_real = validador.TEXTO_Normalizado(textReal.Text); // Cambia '.' por ','
                normalizado_imaginario = validador.TEXTO_Normalizado(textImaginario.Text);
                double real;
                double img;

                if (textReal.Text == "") real = 0;
                else real = Convert.ToDouble(normalizado_real);
                if (textImaginario.Text == "") img = 0;
                else img = Convert.ToDouble(normalizado_imaginario);

                NComplejo complejo1 = new NComplejo(real, img, "BIN");

                REPORTE.TEXTBOX_esValido(textReal, "OK");
                REPORTE.TEXTBOX_esValido(textImaginario, "OK");
                REPORTE.BOTON_Complejo(complejo1, btnReporte1, "POLAR");
            }
            else
            {
                if (validador.TEXTO_EsDecimalValido(textReal.Text)) REPORTE.TEXTBOX_esValido(textReal, "OK");
                else REPORTE.TEXTBOX_esValido(textReal, "INVALIDO");

                if(validador.TEXTO_EsDecimalValido(textImaginario.Text)) REPORTE.TEXTBOX_esValido(textImaginario, "OK");
                else REPORTE.TEXTBOX_esValido(textImaginario, "INVALIDO");

                REPORTE.BOTON_Complejo(nulo, btnReporte1, "ERROR");
                MessageBox.Show("El DATO ingresado NO es Válido");
            }

            
        }
    }
}
