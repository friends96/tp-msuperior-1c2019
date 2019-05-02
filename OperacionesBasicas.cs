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
    }
}
