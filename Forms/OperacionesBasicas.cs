using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Matematica_Superior_Demo
{
    public partial class OperacionesBasicas : Form
    {
        public Form parent;
        INumeroComplejo operando1;
        INumeroComplejo operando2;
        public OperacionesBasicas(Form _parent)
        {
            InitializeComponent();
            this.parent = _parent;
        }


        private void Close(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ElegirNumero1Button_Click(object sender, EventArgs e)
        {
            AgregarNumero dialog = new AgregarNumero();
            dialog.ShowDialog();
            operando1 = dialog.resultado;
            numero1.Text = operando1.GetFormaPolar().GetModulo().ToString();
        }

        private void ElegirNumero2Button_Click(object sender, EventArgs e)
        {
            AgregarNumero dialog = new AgregarNumero();
            dialog.ShowDialog();
            operando2 = dialog.resultado;
            numero2.Text = operando2.GetFormaPolar().GetModulo().ToString();
        }
    }
}
