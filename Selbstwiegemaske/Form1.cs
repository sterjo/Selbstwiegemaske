﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Selbstwiegemaske
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.lblHallo.Text = "Hallo Männer!";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selbstzerstörung wird eingeleitet");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.ShowWSLSPruefung"BOOOOOM!!!!!";
        }
    }
}
