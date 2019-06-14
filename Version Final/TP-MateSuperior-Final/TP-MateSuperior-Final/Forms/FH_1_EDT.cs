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
            validador.TEXTO_KeyPress(e);
        }

        private void TextImaginario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress(e);
        }

        private void TextModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress(e);
        }

        private void TextArgumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress(e);
        }

        private void BtnConvertir1_Click(object sender, EventArgs e)
        {
            texto1OK = validador.TEXTO_EsDecimalValido(textReal.Text);
            if (texto1OK)
            {
                string_decimal = validador.TEXTO_Normalizado(textReal.Text); // Cambia '.' por ','

                btnReporte1.Text = string_decimal;
                btnReporte1.BackColor = Color.FromArgb(0,80,200);

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
