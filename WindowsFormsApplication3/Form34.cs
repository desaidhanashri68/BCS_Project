﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Keyboard_billDataSet.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.Keyboard_billDataSet.bill);

            this.reportViewer1.RefreshReport();
        }
    }
}
