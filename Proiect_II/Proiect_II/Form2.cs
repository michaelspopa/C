using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;

namespace Proiect_II
{
    public partial class Form2 : Form
    {
        public Form2(string UserName)
        {
            InitializeComponent();
            //load_table();
            timer1.Start();
            label6.Text = UserName;

        }

        string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            

        DataTable dbdataset;
        string Gender;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
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
            // TODO: This line of code loads data into the 'database1DataSet.e_info' table. You can move, or remove it, as needed.
            this.e_infoTableAdapter.Fill(this.database1DataSet.e_info);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
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
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
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
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {


            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand("select * from e_info;", conDataBase);
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
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void id_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            string Query = "insert into e_info (idEmployee,first_name,last_name,age,gender,DOB  ) values(  '" + this.id_txt.Text + "','" + this.name_txt.Text + "','" + this.lname_txt.Text + "','" + this.age_txt.Text + "','" + Gender + "','" + this.dateTimePicker1.Text + "') ;";
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
            load_table();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            string Query = "update e_info set idEmployee='" + this.id_txt.Text + "',first_name='" + this.name_txt.Text + "',last_name='" + this.lname_txt.Text + "',age='" + this.age_txt.Text + "',DOB='" + this.dateTimePicker1.Text + "'where idEmployee ='" + this.id_txt.Text + "' ;";
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

        private void delete_Click_1(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
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
        void load_table() {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand("select idEmployee ,first_name , last_name , age from e_info;", conDataBase);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
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
        private void button4_Click_2(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand("select idEmployee ad 'ID',first_name as 'First Name', last_name as 'Last Name' , age as 'Age' from e_info;", conDataBase);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
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

        private void button4_Click_3(object sender, EventArgs e)
        {
            string myConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Serby\Desktop\Proiect II\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand("select idEmployee as 'ID',first_name as 'First Name', last_name as 'Last Name' , age as 'Age' , gender as 'Gender', DOB as 'Date of Birth' from e_info;", conDataBase);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                 dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                sda.Fill(dbdataset);
                ds.Tables.Add(dbdataset);
                ExcelLibrary.DataSetHelper.CreateWorkbook("EmployeeFile.xls", ds);



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id_txt.Text = row.Cells["ID"].Value.ToString();
                name_txt.Text = row.Cells["First Name"].Value.ToString();
                 lname_txt.Text = row.Cells["Last Name"].Value.ToString();
                 age_txt.Text = row.Cells["Age"].Value.ToString();
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DateTime = DateTime.Now;
            this.time_l.Text = DateTime.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("id LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = DV;
        }

        private void age_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void age_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void time_l_Click(object sender, EventArgs e)
        {

        }
    }
}
