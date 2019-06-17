using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TP_MateSuperior_Final.Forms;

namespace TP_MateSuperior_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMesage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMesage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0) this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new F_Home());
            SELECCION_Activa(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FH_1_EDT());
            SELECCION_Activa(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FH_2_OB());
            SELECCION_Activa(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FH_3_OA());
            SELECCION_Activa(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FH_4_SF());
            SELECCION_Activa(4);
        }

        private void SELECCION_Activa(int selector)
        {
            switch (selector)
            {
                case 1:
                    button1.BackColor = Color.FromArgb(0, 80, 200);
                    button2.BackColor = Color.FromArgb(26, 32, 40);
                    button3.BackColor = Color.FromArgb(26, 32, 40);
                    button4.BackColor = Color.FromArgb(26, 32, 40);
                    break;
                case 2:
                    button1.BackColor = Color.FromArgb(26, 32, 40);
                    button2.BackColor = Color.FromArgb(0, 80, 200);
                    button3.BackColor = Color.FromArgb(26, 32, 40);
                    button4.BackColor = Color.FromArgb(26, 32, 40);
                    break;
                case 3:
                    button1.BackColor = Color.FromArgb(26, 32, 40);
                    button2.BackColor = Color.FromArgb(26, 32, 40);
                    button3.BackColor = Color.FromArgb(0, 80, 200);
                    button4.BackColor = Color.FromArgb(26, 32, 40);
                    break;
                case 4:
                    button1.BackColor = Color.FromArgb(26, 32, 40);
                    button2.BackColor = Color.FromArgb(26, 32, 40);
                    button3.BackColor = Color.FromArgb(26, 32, 40);
                    button4.BackColor = Color.FromArgb(0, 80, 200);
                    break;
                default:
                    button1.BackColor = Color.FromArgb(26, 32, 40);
                    button2.BackColor = Color.FromArgb(26, 32, 40);
                    button3.BackColor = Color.FromArgb(26, 32, 40);
                    button4.BackColor = Color.FromArgb(26, 32, 40);
                    break;
            }
        }
    }
}
