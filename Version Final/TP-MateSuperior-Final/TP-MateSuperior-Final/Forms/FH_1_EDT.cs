using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private bool texto1OK = true;
        private string string_decimal;
        private double numero;
        // ======================================================================================

        private void TextReal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_Decimal(e);
        }

        private void TextImaginario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_Decimal(e);
        }

        private void TextModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_Decimal(e);
        }

        private void TextArgumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_Decimal(e);
        }

        private void BtnConvertir1_Click(object sender, EventArgs e)
        {
            texto1OK = validador.NUMERO_Decimal(textReal.Text);
            if (texto1OK)
            {
                string_decimal = validador.NORMALIZACION_Decimal(textReal.Text);
                btnReporte1.Text = string_decimal;
                numero = Convert.ToDouble(string_decimal);
                numero = numero + 10;
                MessageBox.Show("->" + numero);
            }
            else
            {
            }
        }
    }
}
