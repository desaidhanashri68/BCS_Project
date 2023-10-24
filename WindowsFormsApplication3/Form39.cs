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
    public partial class Form39 : Form
    {
        public string stdname { get; set; }
        public string sname { get; set; }
        public string aname { get; set; }
        public string bname { get; set; }
        public Form39()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox6.Text);
            b = Convert.ToInt32(textBox3.Text);
            c = a - b;
            textBox4.Text = c.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(textBox2.Text);
            y = Convert.ToInt32(textBox5.Text);
            z = x * y;
            textBox6.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.ShowDialog();
        }

        private void Form39_Load(object sender, EventArgs e)
        {
            textBox1.Text = stdname;
            textBox2.Text = sname;
            textBox5.Text = aname;
            textBox6.Text = bname;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\LAPTOP SELLS AND SERVICES FINAL PROJECT\Laptop sales & sevices\Profit_loss.accdb;Persist Security Info=True";
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "INSERT INTO bill(Product_name,Unit_price,Quantity,Total_price,Admin_price,Profit_loss) Values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            command1.ExecuteNonQuery();
            MessageBox.Show("Record save Succesfully");
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form43 f43 = new Form43();
            f43.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
