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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void Form31_Load(object sender, EventArgs e)
        {

        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form32 f32 = new Form32();
            f32.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = a * 113500;
            textBox9.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c, d;
            c = Convert.ToInt32(textBox3.Text);
            d = c * 80000;
            textBox7.Text = d.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int f, g;
            f = Convert.ToInt32(textBox4.Text);
            g = f * 21900;
            textBox10.Text = g.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int h, i;
            h = Convert.ToInt32(textBox2.Text);
            i = h * 72499;
            textBox16.Text = i.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int j, k;
            j = Convert.ToInt32(textBox5.Text);
            k = j * 174990;
            textBox22.Text = k.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int l, m;
            l = Convert.ToInt32(textBox15.Text);
            m = l * 75000;
            textBox13.Text = m.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n, o;
            n = Convert.ToInt32(textBox12.Text);
            o = n * 78000;
            textBox20.Text = o.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int p, q;
            p = Convert.ToInt32(textBox37.Text);
            q = p * 71551;
            textBox18.Text = q.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int r, s;
            r = Convert.ToInt32(textBox36.Text);
            s = r * 36900;
            textBox38.Text = s.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int t, u;
            t = Convert.ToInt32(textBox35.Text);
            u = t * 39950;
            textBox28.Text = u.ToString(); 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int v, w;
            v = Convert.ToInt32(textBox34.Text);
            w = v * 32990;
            textBox27.Text = w.ToString(); 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(textBox33.Text);
            y = x * 58000;
            textBox26.Text = y.ToString(); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int z, y1;
            z = Convert.ToInt32(textBox39.Text);
            y1 = z * 38000;
            textBox24.Text = y1.ToString();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox9.Text) + int.Parse(textBox7.Text) + int.Parse(textBox10.Text) + int.Parse(textBox16.Text) + int.Parse(textBox22.Text) + int.Parse(textBox13.Text) + int.Parse(textBox20.Text) + int.Parse(textBox18.Text) + int.Parse(textBox38.Text) + int.Parse(textBox28.Text) + int.Parse(textBox27.Text) + int.Parse(textBox26.Text) + int.Parse(textBox24.Text);
            textBox40.Text = n.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\OM\Desktop\Laptop sales & sevices\Bill_f31.accdb;Persist Security Info=True";
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "INSERT INTO bill(bill_f31) Values('" + textBox40.Text + "')";
            command1.ExecuteNonQuery();
            MessageBox.Show("saved successfully!!!!");
            connection.Close();
        }
    }
}
