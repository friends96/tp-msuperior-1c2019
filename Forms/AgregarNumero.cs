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
    public partial class AgregarNumero : Form
    {
        private Boolean estaEnPolar = true;
        private HashSet<Control> botonesDeModoPolar = new HashSet<Control>();
        private HashSet<Control> botonesDeModoBinomico = new HashSet<Control>();

        public INumeroComplejo resultado;
        public AgregarNumero()
        {
            InitializeComponent();

            botonesDeModoPolar.Add(numericUpDownArgumento);
            botonesDeModoPolar.Add(numericUpDownModulo);
            botonesDeModoPolar.Add(piRadLabel);
            botonesDeModoPolar.Add(labelArgumento);
            botonesDeModoPolar.Add(labelModulo);

            botonesDeModoBinomico.Add(numericUpDownParteReal);
            botonesDeModoBinomico.Add(numericUpDownParteImaginaria);
            botonesDeModoBinomico.Add(labelParteReal);
            botonesDeModoBinomico.Add(labelParteImaginaria);
        }

        public static INumeroComplejo ConstruirNumero()
        {

            AgregarNumero dialog = new AgregarNumero();
            if( dialog.DialogResult == DialogResult.OK)
            {

            }


            return new NumeroComplejoPolar(1,1);
        }

        private void CambiarTipoNumeroButton_Click(object sender, EventArgs e)
        {  
            if(estaEnPolar)
            {
                estaEnPolar = false;
                CambiarTipoNumeroButton.Text = "a Polar";
                foreach (Control item in botonesDeModoPolar)
                {
                    item.Visible = false;
                }
                foreach (Control item in botonesDeModoBinomico)
                {
                    item.Visible = true;
                }
            }
            else
            {
                estaEnPolar = true;
                CambiarTipoNumeroButton.Text = "a Binomico";
                foreach (Control item in botonesDeModoPolar)
                {
                    item.Visible = true;
                }
                foreach (Control item in botonesDeModoBinomico)
                {
                    item.Visible = false;
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (estaEnPolar)
                resultado = new NumeroComplejoPolar((double)numericUpDownModulo.Value, (double)numericUpDownArgumento.Value * Math.PI);
            else
                resultado = NumeroComplejoBinomico.NewNumeroComplejoBinomico((double)numericUpDownParteReal.Value, (double)numericUpDownParteImaginaria.Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
