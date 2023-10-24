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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
      

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
           
          
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
        
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label9.Text;
            f26.sname = label10.Text;
            f26.aname = label16.Text;
            f26.bname = label17.Text;
            f26.cname = label1.Text;
            f26.ShowDialog();
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label13.Text;
            f26.sname = label12.Text;
            f26.aname = label11.Text;
            f26.bname = label8.Text;
            f26.cname = label3.Text;
            f26.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label19.Text;
            f26.sname = label18.Text;
            f26.aname = label15.Text;
            f26.bname = label14.Text;
            f26.cname = label4.Text;
            f26.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label24.Text;
            f26.sname = label22.Text;
            f26.aname = label21.Text;
            f26.bname = label20.Text;
            f26.cname = label5.Text;
            f26.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label29.Text;
            f26.sname = label28.Text;
            f26.aname = label27.Text;
            f26.bname = label26.Text;
            f26.cname = label6.Text;
            f26.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.stdname = label32.Text;
            f26.sname = label31.Text;
            f26.aname = label30.Text;
            f26.bname = label23.Text;
            f26.cname = label7.Text;
            f26.ShowDialog();
        }
            

           
        }
    }

