using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arduino_Logger
{
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void frmAcerca_Load(object sender, EventArgs e)
        {
            string texto = "Arduino Logger";
            texto += "\n   Versión 0.1";
            texto += "\n   http://www.programnation.com/";
            lbl.Text = texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
