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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f24 = new Form15();
            f24.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label12.Text;
            f28.aname = label13.Text;
            f28.ShowDialog();
        }

        private void Form27_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form28 f28 = new Form28();
            f28.sname = label4.Text;
            f28.aname = label5.Text;
            f28.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label10.Text;
            f28.aname = label9.Text;
            f28.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label6.Text;
            f28.aname = label3.Text;
            f28.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label2.Text;
            f28.aname = label11.Text;
            f28.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label8.Text;
            f28.aname = label7.Text;
            f28.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label16.Text;
            f28.aname = label17.Text;
            f28.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.sname = label15.Text;
            f28.aname = label14.Text;
            f28.ShowDialog();
        }
    }
}
