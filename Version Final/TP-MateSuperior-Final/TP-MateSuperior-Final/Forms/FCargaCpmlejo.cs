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
    public partial class FCargaCpmlejo : Form
    {
        public FCargaCpmlejo()
        {
            InitializeComponent();
            MODO = "BIN";
        }

        //================================================
        //public string MODO { get; set; }
        public string MODO = "BIN";
        public int conradorIngreso { get; set; }
        private NComplejo c1 { get; set; }

        private double anguloFormato = Math.PI;
        private string normalizado_real, normalizado_imaginario;
        private string normalizado_modulo, normalizado_argumetno;

        //HERRAMIENTAS
        private ValidarDatos validador = new ValidarDatos();
        private ServicesREPORT REPORTE = new ServicesREPORT();
        private NComplejo nulo = new NComplejo();

        //================================================
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEleccion1_Click(object sender, EventArgs e)
        {
            btnEleccion1.BackColor = Color.FromArgb(0, 80, 200);
            btnEleccion2.BackColor = Color.FromArgb(26, 32, 40);
            MODO = "BIN";
            panelPolar.Visible = false;
            panelBinomica.Visible = true;
        }

        private void BtnEleccion2_Click(object sender, EventArgs e)
        {
            btnEleccion1.BackColor = Color.FromArgb(26, 32, 40);
            btnEleccion2.BackColor = Color.FromArgb(0, 80, 200);
            MODO = "POLAR";
            panelPolar.Visible = true;
            panelBinomica.Visible = false;
        }

        private void TextREAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void TextIMG_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void TextModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_ENTERO_Positivo(e);
        }

        private void BtnAngulo_Click(object sender, EventArgs e)
        {
            if(btnAngulo.Text == "π")
            {
                btnAngulo.Text = "°";
                anguloFormato = Math.PI / 180;
                labelAngulo.Text = "( grados )";
            }
            else
            {
                btnAngulo.Text = "π";
                anguloFormato = Math.PI;
                labelAngulo.Text = "( rad )";
            }
        }

        private void TextArgumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.TEXTO_KeyPress_Decimal(e);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(MODO == "BIN")
            {
                if (validador.TEXTO_EsDecimalValido(textREAL.Text) && validador.TEXTO_EsDecimalValido(textIMG.Text))
                {
                    FH_2_OB frmPadre = this.Owner as FH_2_OB;
                    // Esto es para Normalizar las letras de ingreso
                    normalizado_real = validador.TEXTO_Normalizado(textREAL.Text);
                    normalizado_imaginario = validador.TEXTO_Normalizado(textIMG.Text);
                    //normalizado_modulo = validador.TEXTO_Normalizado(textModulo.Text);
                    //normalizado_argumetno = validador.TEXTO_Normalizado(textArgumento.Text);

                    double real, img;
                    //double modulo, argumento;
                    NComplejo complejoAUX = new NComplejo();

                    if (textREAL.Text == "") real = 0;
                    else real = Convert.ToDouble(normalizado_real);
                    if (textIMG.Text == "") img = 0;
                    else img = Convert.ToDouble(normalizado_imaginario);

                    complejoAUX.RELOAD("REAL", real);
                    complejoAUX.RELOAD("IMG", img);

                    REPORTE.TEXTBOX_esValido(textREAL, "OK");
                    REPORTE.TEXTBOX_esValido(textIMG, "OK");

                    if (frmPadre.operando == 1)
                    {
                        REPORTE.BOTON_Complejo(complejoAUX, frmPadre.btnCargado1, "BIN");
                        frmPadre.modoN1 = "BIN";

                        frmPadre.btnCargado1.BackColor = Color.FromArgb(49, 66, 82);
                        frmPadre.btnCargado1.Visible = true;
                        frmPadre.btnCarga1.Visible = false;
                        frmPadre.LinkLabelEditar1.Visible = true;
                    }
                    else
                    {
                        REPORTE.BOTON_Complejo(complejoAUX, frmPadre.btnCargado2, "BIN");
                        frmPadre.modoN2 = "BIN";

                        frmPadre.btnCargado2.BackColor = Color.FromArgb(49, 66, 82);
                        frmPadre.btnCargado2.Visible = true;
                        frmPadre.btnCarga2.Visible = false;
                        frmPadre.LinkLabelEditar2.Visible = true;
                    }

                    frmPadre.real = complejoAUX.REAL;
                    frmPadre.img = complejoAUX.IMG;

                    this.Close();
                }
                else
                {
                    if (validador.TEXTO_EsDecimalValido(textREAL.Text)) REPORTE.TEXTBOX_esValido(textREAL, "OK");
                    else REPORTE.TEXTBOX_esValido(textREAL, "INVALIDO");

                    if (validador.TEXTO_EsDecimalValido(textIMG.Text)) REPORTE.TEXTBOX_esValido(textIMG, "OK");
                    else REPORTE.TEXTBOX_esValido(textIMG, "INVALIDO");

                    //REPORTE.BOTON_Complejo(nulo, btnReporte1, "ERROR");
                    MessageBox.Show("El DATO ingresado NO es Válido");
                }
            }
            else
            {/////////////////////////////////////////////////////////////
                if (validador.TEXTO_EsDecimalValido(textModulo.Text) && validador.TEXTO_EsDecimalValido(textArgumento.Text))
                {
                    FH_2_OB frmPadre = this.Owner as FH_2_OB;
                    // Esto es para Normalizar las letras de ingreso
                    //normalizado_real = validador.TEXTO_Normalizado(textREAL.Text);
                    //normalizado_imaginario = validador.TEXTO_Normalizado(textIMG.Text);
                    normalizado_modulo = validador.TEXTO_Normalizado(textModulo.Text);
                    normalizado_argumetno = validador.TEXTO_Normalizado(textArgumento.Text);

                    //double real, img;
                    double modulo, argumento;
                    NComplejo complejoAUX = new NComplejo();

                    if (textModulo.Text == "") modulo = 0;
                    else modulo = Convert.ToDouble(normalizado_modulo);
                    if (textArgumento.Text == "") argumento = 0;
                    else argumento = Convert.ToDouble(normalizado_argumetno);

                    complejoAUX.RELOAD("MODULO", modulo);
                    complejoAUX.RELOAD("ARGUMENTO", argumento * anguloFormato);

                    REPORTE.TEXTBOX_esValido(textModulo, "OK");
                    REPORTE.TEXTBOX_esValido(textArgumento, "OK");

                    if (frmPadre.operando == 1)
                    {   //Configuracion en ca sa que el Padre sea llamado por el BOTOM 1
                        REPORTE.BOTON_Complejo(complejoAUX, frmPadre.btnCargado1, "POLAR");
                        frmPadre.modoN1 = "POLAR";

                        frmPadre.btnCargado1.BackColor = Color.FromArgb(49, 66, 82);
                        frmPadre.btnCargado1.Visible = true;
                        frmPadre.btnCarga1.Visible = false;
                        frmPadre.LinkLabelEditar1.Visible = true;
                    }
                    else
                    {   //Configuracion en ca sa que el Padre sea llamado por el BOTOM 2
                        REPORTE.BOTON_Complejo(complejoAUX, frmPadre.btnCargado2, "POLAR");
                        frmPadre.modoN2 = "POLAR";

                        frmPadre.btnCargado2.BackColor = Color.FromArgb(49, 66, 82);
                        frmPadre.btnCargado2.Visible = true;
                        frmPadre.btnCarga2.Visible = false;
                        frmPadre.LinkLabelEditar2.Visible = true;
                    }

                    frmPadre.modulo = complejoAUX.MODULO;
                    frmPadre.argumento = complejoAUX.ARGUMENTO;

                    this.Close();
                }
                else
                {
                    if (validador.TEXTO_EsDecimalValido(textModulo.Text)) REPORTE.TEXTBOX_esValido(textModulo, "OK");
                    else REPORTE.TEXTBOX_esValido(textModulo, "INVALIDO");

                    if (validador.TEXTO_EsDecimalValido(textArgumento.Text)) REPORTE.TEXTBOX_esValido(textArgumento, "OK");
                    else REPORTE.TEXTBOX_esValido(textArgumento, "INVALIDO");

                    MessageBox.Show("El DATO ingresado NO es Válido");
                }
            }
            
            
        }
    }
}
