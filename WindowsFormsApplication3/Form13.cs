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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
         
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label15.Text;
            f26.sname = label14.Text;
            f26.aname = label16.Text;
            f26.bname = label17.Text;
            f26.cname = label8.Text;
            f26.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label20.Text;
            f26.sname = label19.Text;
            f26.aname = label18.Text;
            f26.bname = label2.Text;
            f26.cname = label9.Text;
            f26.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label23.Text;
            f26.sname = label22.Text;
            f26.aname = label21.Text;
            f26.bname = label7.Text;
            f26.cname = label10.Text;
            f26.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label26.Text;
            f26.sname = label25.Text;
            f26.aname = label24.Text;
            f26.bname = label3.Text;
            f26.cname = label11.Text;
            f26.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label29.Text;
            f26.sname = label28.Text;
            f26.aname = label27.Text;
            f26.bname = label4.Text;
            f26.cname = label12.Text;
            f26.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label32.Text;
            f26.sname = label31.Text;
            f26.aname = label30.Text;
            f26.bname = label5.Text;
            f26.cname = label13.Text;
            f26.ShowDialog();
        }
    }
}
