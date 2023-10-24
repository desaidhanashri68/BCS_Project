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
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void Form38_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'New_stockDataSet1.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.New_stockDataSet1.bill);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
