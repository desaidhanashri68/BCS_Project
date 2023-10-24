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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'antivirus_servicesDataSet.anti' table. You can move, or remove it, as needed.
            this.antiTableAdapter.Fill(this.antivirus_servicesDataSet.anti);

            this.reportViewer1.RefreshReport();
        }
    }
}
