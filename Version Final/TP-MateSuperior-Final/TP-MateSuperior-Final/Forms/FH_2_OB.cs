using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_MateSuperior_Final.Clases;
using TP_MateSuperior_Final.Servicios;

namespace TP_MateSuperior_Final.Forms
{
    public partial class FH_2_OB : Form
    {
        public FH_2_OB()
        {
            InitializeComponent();
        }
        //===========================================================
        //private NComplejo c1 { get; set; }
        //private NComplejo c2 { get; set; }
        private NComplejo c1 = new NComplejo();
        private NComplejo c2 = new NComplejo();

        public double real, img, modulo, argumento;
        
        public string modo = "";
        public string modoN1 = "", modoN2 = "";
        public int operando = 0;

        private ServicesREPORT REPORTE = new ServicesREPORT();
        private ServicesOperator OPERADOR = new ServicesOperator();

        //===========================================================

        public string mensaje { get; set; } // Aca se guarda lo que se controla desde el HIJO

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            Selector(1);

            NComplejo cAuxiliar = new NComplejo();
            cAuxiliar = OPERADOR.SUMAR(c1, c2);
            REPORTE.BOTON_Complejo(cAuxiliar, btnRerporte, "BIN");
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            Selector(2);

            NComplejo cAuxiliar = new NComplejo();
            cAuxiliar = OPERADOR.RESTAR(c1, c2);
            REPORTE.BOTON_Complejo(cAuxiliar, btnRerporte, "BIN");
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Selector(3);

            NComplejo cAuxiliar = new NComplejo();
            cAuxiliar = OPERADOR.MULTIPLICAR(c1, c2);
            REPORTE.BOTON_Complejo(cAuxiliar, btnRerporte, "BIN");
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Selector(4);

            NComplejo cAuxiliar = new NComplejo();
            cAuxiliar = OPERADOR.DIVIDIR(c1, c2);
            REPORTE.BOTON_Complejo(cAuxiliar, btnRerporte, "BIN");
        }

        private void BtnCargado1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Numero Colmplejo: ({c1.REAL},{c1.IMG}");
            if(modoN1 == "BIN")
            {
                modoN1 = "POLAR";
                REPORTE.BOTON_Complejo(c1, btnCargado1, "POLAR");
            }
            else
            {
                modoN1 = "BIN";
                REPORTE.BOTON_Complejo(c1, btnCargado1, "BIN");
            }
            btnCargado1.BackColor = Color.FromArgb(49, 66, 82);
            btnCargado1.Visible = true;
            btnCarga1.Visible = false;
            LinkLabelEditar1.Visible = true;
        }

        private void BtnCargado2_Click(object sender, EventArgs e)
        {
            if (modoN2 == "BIN")
            {
                modoN2 = "POLAR";
                REPORTE.BOTON_Complejo(c2, btnCargado2, "POLAR");
            }
            else
            {
                modoN2 = "BIN";
                REPORTE.BOTON_Complejo(c2, btnCargado2, "BIN");
            }
            btnCargado2.BackColor = Color.FromArgb(49, 66, 82);
            btnCargado2.Visible = true;
            btnCarga2.Visible = false;
            LinkLabelEditar2.Visible = true;
        }
        private void BtnCarga1_Click(object sender, EventArgs e)
        {
            operando = 1;// <- Elijo que operando toma el dato
            real = 0; img = 0;
            modulo = 0; argumento = 0;
            //frmHIJO.textBox1.Text = "Contenido de Padre >>> Hijo";

            FCargaCpmlejo frmHIJO = new FCargaCpmlejo();
            AddOwnedForm(frmHIJO);
            frmHIJO.ShowDialog();

            //Esta parte espera que termine la ejecucion del HIJO
            if (modoN1 == "BIN")
            {
                c1.RELOAD("REAL", real);
                c1.RELOAD("IMG", img);
            }
            else
            {
                c1.RELOAD("MODULO", modulo);
                c1.RELOAD("ARGUMENTO", argumento);
            }

            //labelResultado.Text = mensaje;
        }

        private void BtnCarga2_Click(object sender, EventArgs e)
        {
            operando = 2;// <- Elijo que operando toma el dato
            real = 0; img = 0;
            modulo = 0; argumento = 0;

            FCargaCpmlejo formHIJO = new FCargaCpmlejo();
            AddOwnedForm(formHIJO);
            formHIJO.ShowDialog();

            //Esta parte espera que termine la ejecucion del HIJO
            if (modoN2 == "BIN")
            {
                c2.RELOAD("REAL", real);
                c2.RELOAD("IMG", img);
            }
            else
            {
                c2.RELOAD("MODULO", modulo);
                c2.RELOAD("ARGUMENTO", argumento);
            }

            //MessageBox.Show($"REAL = {c2.REAL}\nIMG = {c2.IMG}");
        }
        private void Selector(int selector)
        {
            switch (selector)
            {
                case 1:
                    btnSumar.BackColor = Color.FromArgb(0, 80, 200);
                    btnRestar.BackColor = Color.FromArgb(49, 66, 100);
                    btnMultiplicar.BackColor = Color.FromArgb(49, 66, 100);
                    btnDividir.BackColor = Color.FromArgb(49, 66, 100);
                    break;
                case 2:
                    btnSumar.BackColor = Color.FromArgb(49, 66, 100);
                    btnRestar.BackColor = Color.FromArgb(0, 80, 200);
                    btnMultiplicar.BackColor = Color.FromArgb(49, 66, 100);
                    btnDividir.BackColor = Color.FromArgb(49, 66, 100);
                    break;
                case 3:
                    btnSumar.BackColor = Color.FromArgb(49, 66, 100);
                    btnRestar.BackColor = Color.FromArgb(49, 66, 100);
                    btnMultiplicar.BackColor = Color.FromArgb(0, 80, 200);
                    btnDividir.BackColor = Color.FromArgb(49, 66, 100);
                    break;
                case 4:
                    btnSumar.BackColor = Color.FromArgb(49, 66, 100);
                    btnRestar.BackColor = Color.FromArgb(49, 66, 100);
                    btnMultiplicar.BackColor = Color.FromArgb(49, 66, 100);
                    btnDividir.BackColor = Color.FromArgb(0, 80, 200);
                    break;
                default:
                    btnSumar.BackColor = Color.FromArgb(49, 66, 100);
                    btnRestar.BackColor = Color.FromArgb(49, 66, 100);
                    btnMultiplicar.BackColor = Color.FromArgb(49, 66, 100);
                    btnDividir.BackColor = Color.FromArgb(49, 66, 100);
                    break;
            }
        }
    }
}
