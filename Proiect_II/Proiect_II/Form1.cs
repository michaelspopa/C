using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password_txt.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
                SqlConnection myConn = new SqlConnection(myConnection);

                SqlCommand SelectCommand = new SqlCommand("SELECT * FROM e_info where user_name = '" + this.username_txt.Text + "'and password='" + this.password_txt.Text + "';", myConn);

                SqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;

                }
                if (count == 1)
                {
                    //MessageBox.Show("Username and password is correct");
                    this.Hide();
                    Form2 f2 = new Form2("Welcome:"+username_txt.Text);
                    f2.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Dupplicate username and password....Access DENIED");
                }
                else

                    MessageBox.Show("username and password is not correct....Please try again");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}