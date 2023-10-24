﻿using System;
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
    public partial class Form26 : Form
    {
        public string stdname { get; set; }
        public string sname { get; set; }
        public string aname { get; set; }
        public string bname { get; set; }
        public string cname { get; set; }
      

        
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\LAPTOP SELLS AND SERVICES FINAL PROJECT\Laptop sales & sevices\Laptop_bill.accdb;Persist Security Info=True";
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "INSERT INTO bill(Customer_name,Mob_no,Laptop_name,Processor,RAM,SSD,Other_specification,Unit_price,Quantity,Bill) Values('" + textBox8.Text + "' ,'" + textBox9.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox10.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                command1.ExecuteNonQuery();
                MessageBox.Show("Paid Succesfully");
                connection.Close();

               
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(textBox5.Text);
            y = Convert.ToInt32(textBox6.Text);
            z = x * y;
            textBox7.Text = z.ToString();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form42 f42 = new Form42();
            f42.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "*******************************\n";
            richTextBox1.Text += "*********BILL GENRATE**********\n";
            richTextBox1.Text += "*******************************\n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "customer name:     " + textBox8.Text + "\n\n";
            richTextBox1.Text += "Mobile no:     " + textBox9.Text + "\n\n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "DATE:-     "+  DateTime.Now +"\n \n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Laptop name:   " + textBox1.Text + "\n\n";
            richTextBox1.Text += "processer:   " +textBox2.Text + "\n\n";
            richTextBox1.Text += "RAM:    " + textBox3.Text + "\n\n";
            richTextBox1.Text += "SSD:   " + textBox4.Text + "\n\n";
            richTextBox1.Text += "Other specification:    " + textBox10.Text + "\n\n";
            richTextBox1.Text += "unit price:    " + textBox5.Text + "\n\n";
            richTextBox1.Text += "quantity:    " + textBox6.Text + "\n\n";
            richTextBox1.Text += "TOTAL AMOUNT:    " + textBox7.Text + "\n\n";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif",22,FontStyle.Bold),Brushes.Black,new Point(10,10));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
        }

        private void Form26_Load(object sender, EventArgs e)
        {

            textBox1.Text = stdname;
            textBox2.Text = sname;
            textBox3.Text = aname;
            textBox4.Text = bname;
            textBox5.Text = cname;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,A Phone Number cannot contain letters");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form39 f39 = new Form39();
            f39.stdname = textBox1.Text;
            f39.sname = textBox5.Text;
            f39.aname = textBox6.Text;
            f39.bname = textBox7.Text;
            f39.ShowDialog();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 10)
            {
                MessageBox.Show("The contact number validated succesfully");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
