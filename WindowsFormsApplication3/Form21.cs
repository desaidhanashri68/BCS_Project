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
    public partial class Form21 : Form
    {
        
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form31 f31 = new Form31();
            f31.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a,b;
            a = Convert.ToInt32(textBox4.Text);
            b = a * 47;
            textBox5.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int c, d;
            c = Convert.ToInt32(textBox7.Text);
            d = c * 50;
            textBox9.Text = d.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int g, f;
            g = Convert.ToInt32(textBox19.Text);
            f = g * 69;
            textBox21.Text = f.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int h, i;
            h = Convert.ToInt32(textBox11.Text);
            i = h * 18;
            textBox18.Text = i.ToString();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int j, k;
            j = Convert.ToInt32(textBox13.Text);
            k = j * 46;
            textBox17.Text = k.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int l, m;
            l = Convert.ToInt32(textBox15.Text);
            m = l * 60;
            textBox16.Text = m.ToString();
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a1, b1;
            a1 = Convert.ToInt32(textBox39.Text);
            b1 = a1 * 38;
            textBox38.Text = b1.ToString();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int c1, d1;
            c1 = Convert.ToInt32(textBox37.Text);
            d1 = c1 * 37;
            textBox25.Text = d1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int g1, h1;
            g1 = Convert.ToInt32(textBox36.Text);
            h1 = g1 * 75;
            textBox24.Text = h1.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i1, j1;
            i1 = Convert.ToInt32(textBox35.Text);
            j1 = i1 * 48;
            textBox22.Text = j1.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int k1, l1;
            k1 = Convert.ToInt32(textBox34.Text);
            l1 = k1 * 72;
            textBox41.Text = l1.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int m1, n1;
            m1 = Convert.ToInt32(textBox33.Text);
            n1 = m1 * 10000;
            textBox40.Text = n1.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox5.Text) + int.Parse(textBox9.Text) + int.Parse(textBox21.Text) + int.Parse(textBox18.Text) + int.Parse(textBox17.Text) + int.Parse(textBox16.Text) + int.Parse(textBox38.Text) + int.Parse(textBox25.Text) + int.Parse(textBox24.Text) + int.Parse(textBox22.Text) + int.Parse(textBox41.Text) + int.Parse(textBox40.Text);
            textBox42.Text = n.ToString();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 10)
            {
                MessageBox.Show("The contact number validated succesfully");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,A Phone Number cannot contain letters");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\OM\Desktop\Laptop sales & sevices\Bill.accdb;Persist Security Info=True";
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "INSERT INTO bill(namess,address,mob_no,bill_f21) Values('" + textBox1.Text + "' ,'" + textBox3.Text + "','" + textBox2.Text + "','" + textBox42.Text + "')";
            command1.ExecuteNonQuery();
            MessageBox.Show("saved successfully!!!!");
            connection.Close();
        }
    }
}
