using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_MateSuperior_Final.Clases;

namespace TP_MateSuperior_Final.Servicios
{
    class ServicesREPORT
    {
        public ServicesREPORT()
        {

        }
        public void BOTON_Complejo(NComplejo c1, Button boton, String modo)
        {
            if (modo == "BIN")
            {
                boton.BackColor = Color.FromArgb(0, 80, 200);
                boton.Text = $"( {Math.Round(c1.REAL, 3)} ; {Math.Round(c1.IMG, 3)} )";
            }
            else if(modo == "POLAR")
            {
                boton.BackColor = Color.FromArgb(0, 80, 200);
                boton.Text = $"[ {Math.Round(c1.MODULO, 3)} ; {Math.Round(c1.ARGUMENTO, 3)} ]";
            }
            else
            {
                boton.BackColor = Color.FromArgb(242, 23, 40);
                boton.Text = $"--- ERROR ---";
            }
        }
        public void TEXTBOX_esValido(TextBox cajaTexto, String modo)
        {
            if(modo == "OK" || modo == "ok") cajaTexto.BackColor = Color.FromArgb(255,255,255);
            else cajaTexto.BackColor = Color.FromArgb(238, 143, 148);
        }
    }
}
