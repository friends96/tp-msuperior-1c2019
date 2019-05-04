using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Matematica_Superior_Demo.Services;

namespace TP_Matematica_Superior_Demo
{
    public partial class OperacionesBasicas : Form
    {
        INumeroComplejo operando1;
        INumeroComplejo operando2;
        INumeroComplejo resultado;

        public OperacionesBasicas()
        {
            InitializeComponent();
            operando1 = null;
            operando2 = null;
            resultado = null;
        }


        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ElegirNumero1Button_Click(object sender, EventArgs e)
        {
            ElegirNumeroYMostrar(ref operando1, ref numero1);
        }

        private void ElegirNumero2Button_Click(object sender, EventArgs e)
        {
            ElegirNumeroYMostrar(ref operando2, ref numero2);
        }
        private void ElegirNumeroYMostrar(ref INumeroComplejo unNumero, ref Label unLabel)
        {
            AgregarNumero dialog = new AgregarNumero();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                unNumero = dialog.resultado;
                unLabel.Text = unNumero.Show();
            }
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            if( INumeroComplejo.Equals(operando1,null) || INumeroComplejo.Equals(operando2, null))
            {
                resultadoLabel.Text = "Falta asignar algun operando, asignelo y vuelva a intentar";
            }
            else
            {
                if(SumaButton.Checked)
                {
                    //logica de la suma. en lo posible delegar todas las cuentas a un servicio asi queda limpia esta parte del codigo ?
                    resultado = OperacionesService.Sumar(operando1, operando2);
                    
                }
                if (RestaButton.Checked)
                {
                    //resta
                    resultado = OperacionesService.Resta(operando1, operando2);
                }
                if(MultiplicacionButton.Checked)
                {
                    //multiplicacion
                    resultadoLabel.Text = "mult";
                }
                if(DivisionButton.Checked)
                {
                    resultadoLabel.Text = "division";

                }

                resultadoLabel.Text = resultado.Show();
            }


        }
    }
}
