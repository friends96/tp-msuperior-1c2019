using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Matematica_Superior_Demo.Forms
{
    public partial class SeleccionarOperacionAvanzada : Form
    {
        public SeleccionarOperacionAvanzada()
        {
            InitializeComponent();
            comboBoxOperacion.SelectedItem = "Potencia de un complejo";
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (comboBoxOperacion.Text == "Potencia de un complejo")
            {
                Form formPotenciaDeComplejo = new PotenciaDeUnNumeroComplejo();
                formPotenciaDeComplejo.ShowDialog();
            }
            else
            {

            }
        }
    }
}
