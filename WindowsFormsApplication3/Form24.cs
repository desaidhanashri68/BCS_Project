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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace(textBox2.Text)||string.IsNullOrWhiteSpace(textBox3.Text)||string.IsNullOrWhiteSpace(textBox4.Text)||string.IsNullOrWhiteSpace(textBox5.Text)||string.IsNullOrWhiteSpace(textBox6.Text)||string.IsNullOrWhiteSpace(textBox7.Text))
           {
               MessageBox.Show("Please fill all the fields");
           }
           else
           {
               OleDbConnection connection = new OleDbConnection();
               connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\LAPTOP SELLS AND SERVICES FINAL PROJECT\Laptop sales & sevices\lapii_repair_service.accdb;Persist Security Info=True";
               connection.Open();
               OleDbCommand command1 = new OleDbCommand();
               command1.Connection = connection;
               command1.CommandText = "INSERT INTO repair(cname,mob_no,address,comp_id,company,os,processor) Values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox7.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
               command1.ExecuteNonQuery();
               MessageBox.Show("Your Order has been placed");
               connection.Close();
              
              
           }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,A Phone number cannot contain letters");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 10)
            {
                MessageBox.Show("The contact number validated succesfully");
            }
           
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}