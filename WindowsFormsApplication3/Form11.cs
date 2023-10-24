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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label14.Text;
            f26.sname = label12.Text;
            f26.aname = label16.Text;
            f26.bname = label17.Text;
            f26.cname = label2.Text;
            f26.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
         
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label21.Text;
            f26.sname = label20.Text;
            f26.aname = label19.Text;
            f26.bname = label13.Text;
            f26.cname = label4.Text;
            f26.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label25.Text;
            f26.sname = label23.Text;
            f26.aname = label22.Text;
            f26.bname = label15.Text;
            f26.cname = label6.Text;
            f26.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label29.Text;
            f26.sname = label28.Text;
            f26.aname = label27.Text;
            f26.bname = label26.Text;
            f26.cname = label10.Text;
            f26.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label32.Text;
            f26.sname = label31.Text;
            f26.aname = label30.Text;
            f26.bname = label3.Text;
            f26.cname = label8.Text;
            f26.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label35.Text;
            f26.sname = label34.Text;
            f26.aname = label33.Text;
            f26.bname = label18.Text;
            f26.cname = label7.Text;
            f26.ShowDialog();
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }
    }
}
