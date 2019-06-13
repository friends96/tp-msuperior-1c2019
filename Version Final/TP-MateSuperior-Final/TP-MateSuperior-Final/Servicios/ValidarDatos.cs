using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MateSuperior_Final.Servicios
{
    class ValidarDatos
    {
        public ValidarDatos()
        {
        }
        public void TEXTO_Decimal(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) // Valida Numeros de 0-9
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 44 || e.KeyChar == 46) // Valida "," y "."
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8) // Valida "BackSpace" -> Para poder Borrar
            {
                e.Handled = false;
            }
            else
            {
                //MessageBox.Show("Solo se aceptna numeros");
                e.Handled = true;
            }
        }

        public bool NUMERO_Decimal(string texto)
        {
            bool resultado = true;
            int cont = 0;
            int i = 0;
            
            if(texto == "")
            {
                resultado = true;
                //MessageBox.Show("Numero VÁLIDO !!!!!!!! y VACIO = 0");
            }
            else if (texto.Length == 1)
            {
                if(texto[0] == '.' || texto[0] == ',')
                {
                    resultado = false;
                    //MessageBox.Show("El Número Ingresado no es Válido.. ;;;;;;;;");
                }
                else
                {
                    resultado = true;
                    //MessageBox.Show("Numero VÁLIDO !!!!!!!!");
                }
            }
            else if(texto[0] != ',' && texto[0] != '.')
            {
                for (i = 0; i < texto.Length; i++) // Contador de ',' o '.'
                {
                    if (texto[i] == ',' || texto[i] == '.') cont++;
                }

                if (cont <= 1)
                {
                    resultado = true;
                    //MessageBox.Show("Numero VÁLIDO !!!!!!!!");
                }
                else
                {
                    resultado = false;
                    //MessageBox.Show("El Número Ingresado no es Válido..");
                }
            }
            else
            {
                resultado = false;
                //MessageBox.Show("El Número Ingresado no es Válido..");
            }
            return resultado;
        }

        public string NORMALIZACION_Decimal(string texto) // Esta funcion convierte todas los puntos a coma decimal
        {
            string reporte = "";
            int i = 0;
            for (i = 0; i < texto.Length; i++)
            {
                if(texto[i] == '.')
                {
                    reporte = reporte + ",";
                }
                else
                {
                    //reporte = reporte + Convert.ToString(texto[i]);
                    reporte = reporte + texto[i];
                }
            }
            return reporte;
        }
        
    }
}
