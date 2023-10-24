using System;
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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Mouse_billDataSet.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.Mouse_billDataSet.bill);

            this.reportViewer1.RefreshReport();
        }
    }
}
