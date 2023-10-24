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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label21.Text;
            f26.sname = label20.Text;
            f26.aname = label15.Text;
            f26.bname = label14.Text;
            f26.cname = label8.Text;
            f26.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label24.Text;
            f26.sname = label23.Text;
            f26.aname = label22.Text;
            f26.bname = label2.Text;
            f26.cname = label19.Text;
            f26.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label27.Text;
            f26.sname = label26.Text;
            f26.aname = label25.Text;
            f26.bname = label3.Text;
            f26.cname = label16.Text;
            f26.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label30.Text;
            f26.sname = label29.Text;
            f26.aname = label28.Text;
            f26.bname = label17.Text;
            f26.cname = label12.Text;
            f26.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label33.Text;
            f26.sname = label32.Text;
            f26.aname = label31.Text;
            f26.bname = label13.Text;
            f26.cname = label11.Text;
            f26.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label36.Text;
            f26.sname = label35.Text;
            f26.aname = label34.Text;
            f26.bname = label10.Text;
            f26.cname = label18.Text;
            f26.ShowDialog();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
