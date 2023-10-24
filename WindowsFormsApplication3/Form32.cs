using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
            f31.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = a * 28580;
            textBox2.Text = b.ToString();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int c, d;
            c = Convert.ToInt32(textBox6.Text);
            d = c * 67990;
            textBox15.Text = d.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int f, g;
            f = Convert.ToInt32(textBox11.Text);
            g = f * 34000;
            textBox14.Text = g.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int h, i;
            h = Convert.ToInt32(textBox8.Text);
            i = h * 24000;
            textBox13.Text = i.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int j, k;
            j = Convert.ToInt32(textBox10.Text);
            k = j * 34000;
            textBox12.Text = k.ToString();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int l, m;
            l = Convert.ToInt32(textBox17.Text);
            m = l * 35700;
            textBox27.Text = m.ToString();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int n, o;
            n = Convert.ToInt32(textBox16.Text);
            o = n * 38000;
            textBox28.Text = o.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int p, q;
            p = Convert.ToInt32(textBox20.Text);
            q = p * 25000;
            textBox25.Text = q.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int r, s;
            r = Convert.ToInt32(textBox19.Text);
            s = r * 38000;
            textBox24.Text = s.ToString();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int t, u;
            t = Convert.ToInt32(textBox18.Text);
            u = t * 61220;
            textBox21.Text = u.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int v, w;
            v = Convert.ToInt32(textBox23.Text);
            w = v * 53990;
            textBox31.Text = w.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text) + int.Parse(textBox15.Text) + int.Parse(textBox14.Text) + int.Parse(textBox13.Text) + int.Parse(textBox12.Text) + int.Parse(textBox27.Text) + int.Parse(textBox28.Text) + int.Parse(textBox25.Text) + int.Parse(textBox24.Text) + int.Parse(textBox21.Text) + int.Parse(textBox31.Text);
            textBox35.Text = n.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\OM\Desktop\Laptop sales & sevices\Bill_f32.accdb;Persist Security Info=True";
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "INSERT INTO bill(bill_f32) Values('" + textBox35.Text + "')";
            command1.ExecuteNonQuery();
            MessageBox.Show("saved successfully!!!!");
            connection.Close();
        }
    }
}
