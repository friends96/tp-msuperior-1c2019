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
    public partial class RadicacionDeUnNumeroComplejo : Form
    {
        private INumeroComplejo radicando;
        private int indice = 0;
        public RadicacionDeUnNumeroComplejo()
        {
            InitializeComponent();
        }





        private void BtnCargarNumero_Click(object sender, EventArgs e)
        {
            ElegirNumeroYMostrar(ref radicando, ref lblNumeroComplejo);
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
            lblError.Text = "";
            indice = (int)numericUpDownIndice.Value;
            if (INumeroComplejo.Equals(radicando, null) || indice <= 0)
            {
                if (INumeroComplejo.Equals(radicando, null))
                {
                    lblError.Text = "Ingrese un número complejo válido";
                }
                if (indice <= 0)
                {
                    lblError.Text += "ingrese un indice positivo";
                }
                return;
            }
            else
            {
                listBoxResultados.Items.Clear();
                foreach (INumeroComplejo item in OperacionesService.Radicacion(radicando, indice))
                {
                    listBoxResultados.Items.Add(item.Show());//
                }

            }

        }
        private void RaicesPrimitivas_Click(object sender, EventArgs e)
        {
            indice = (int)numericUpDownIndice.Value;
            if (indice <= 0)
            {
                lblError.Text += "ingrese un indice positivo";
                return;
            }
            listBoxResultados.Items.Clear();
            foreach (var item in OperacionesService.RaicesPrimitivasDeLaUnidadReal(indice))
            {
                listBoxResultados.Items.Add(item);
            }

        }
    }
}




