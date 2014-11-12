using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autogara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("admin"))
            {
                if (textBox2.Text == ("parola"))
                {
                    Main ma = new Main();
                    ma.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password !");
                }
            }

            else
            {
                if (textBox1.Text == ("user"))
                {
                    if (textBox2.Text == ("user"))
                    {
                        Second ss = new Second();
                        ss.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password !");
                    }

                }


                else
                {
                    MessageBox.Show("Please enter a valid Username and/or Password !");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
