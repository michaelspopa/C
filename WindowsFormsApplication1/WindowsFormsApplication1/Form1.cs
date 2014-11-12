using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sima\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            string Query = "insert into e_info (idEmployee,first_name,last_name,age  ) values(  '" + this.id_txt.Text + "','" + this.name_txt.Text + "','" + this.lname_txt.Text + "','" + this.age_txt.Text + "') ;";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);

            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sima\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            string Query = "update e_info set idEmployee='" + this.id_txt.Text + "',first_name='" + this.name_txt.Text + "',last_name='" + this.lname_txt.Text + "',age='" + this.age_txt.Text + "'where idEmployee ='" + this.id_txt.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);

            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Update");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sima\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            string Query = "delete from e_info where idEmployee ='" + this.id_txt.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);

            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // id_txt.Text = comboBox1.Text; 
        }

        private void age_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3();
           // f3.Show();
          //  this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Sima\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand("select * from e_info;",conDataBase);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }




    }
}

        