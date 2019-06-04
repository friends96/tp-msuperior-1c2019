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

namespace TP_Matematica_Superior_Demo.Forms
{
    public partial class PotenciaDeUnNumeroComplejo : Form
    {
        INumeroComplejo numeroComplejo;

        public PotenciaDeUnNumeroComplejo()
        {
            InitializeComponent();
        }

        private void BtnAgregarNumero_Click(object sender, EventArgs e)
        {
            ElegirNumeroYMostrar(ref numeroComplejo, ref lblNumeroCargado);
        }

        private void ElegirNumeroYMostrar(ref INumeroComplejo unNumero, ref Label labelValorCargado)
        {
            AgregarNumero dialog = new AgregarNumero();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                unNumero = dialog.resultado;
                labelValorCargado.Text = unNumero.Show();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(INumeroComplejo.Equals(numeroComplejo, null))
            {
                lblResultado.Text = "Ingrese un número complejo válido";
            }
            else
            {
                lblResultado.Text = OperacionesService.Potenciacion(numeroComplejo, (int)numericUpDownExponente.Value).Show();
            }
        }
    }
}
