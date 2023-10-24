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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    MessageBox.Show("Please fill all the fields");
                }
                else
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\LAPTOP SELLS AND SERVICES FINAL PROJECT\Laptop sales & sevices\register_form.accdb;Persist Security Info=True";
                    connection.Open();
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;
                    command1.CommandText = "INSERT INTO reg(fname,lname,eid,mob_no,address,state,pin,y_password,c_password) Values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "')";
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Registration Succesfully");
                    connection.Close();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox9.UseSystemPasswordChar = true;
            }
            else
            {
                textBox9.UseSystemPasswordChar = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox8.UseSystemPasswordChar = true;
            }
            else
            {
                textBox8.UseSystemPasswordChar = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,A Phone Number cannot contain letters");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 10)
            {
                MessageBox.Show("The maximum length of text in the textbox to ten");
            }
            double i = 0;
            if (double.TryParse(textBox9.Text, out i))
            {
                errorProvider2.SetError(textBox9, "");
            }
            else
            {
                errorProvider2.SetError(textBox9, "Its allows number only");
            }
           
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 10)
            {
                MessageBox.Show("The maximum length of text in the textbox to ten");
            }
            if (textBox9.Text != "" && textBox8.Text == textBox9.Text)
            {
                errorProvider1.SetError(textBox8, "");
            }
            else
            {
                errorProvider1.SetError(textBox8, "Password and confirm password does not matched");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error,A Pin code cannot contain letters");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
           
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (textBox3.Text.Length > 0)
            {
                if (!rEMail.IsMatch(textBox3.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.SelectAll();
                    e.Cancel = true;
                }
            }
               
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form30 f30 = new Form30();
            f30.Show();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox5.Text == "Permenant Address")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}

