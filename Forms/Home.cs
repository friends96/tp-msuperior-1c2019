using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Matematica_Superior_Demo.Forms;

namespace TP_Matematica_Superior_Demo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void OperacionesBasicas_Click(object sender, EventArgs e)
        {
            Form formulario = new OperacionesBasicas();
            formulario.ShowDialog();
        }

        private void OperacionesAvanzadas_Click(object sender, EventArgs e)
        {
            Form formSeleccionarOperacion = new SeleccionarOperacionAvanzada();
            formSeleccionarOperacion.ShowDialog();
        }

        private void SumaFasores_Click(object sender, EventArgs e)
        {
            Form formSeleccionarOperacion = new SeleccionarSumaFasores();
            formSeleccionarOperacion.ShowDialog();

        }
    }
}
