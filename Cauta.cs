using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
 
namespace Autogara
{
    public partial class Cauta : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        DataTable dbdataset;
        DataTable dbdatasetD;
        
        public Cauta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Second ss = new Second();
            ss.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("select * from PLECARI ;", conDataBase);


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






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string Query = " SELECT * from PLECARI WHERE DESTINATIE ='" + this.textBox1.Text + "' ;";

            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);


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

                BindingSource bSourceL = new BindingSource();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string Query = " SELECT * from SOSIRI WHERE ORIGINE ='" + this.textBox2.Text + "' ;";

            SqlConnection conDataBase = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);


            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;



                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);



                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);

                BindingSource bSourceL = new BindingSource();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("select * from SOSIRI ;", conDataBase);


            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;



                dbdataset = new DataTable();
                sda.Fill(dbdataset);



                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Cauta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autogaraDataSet13.PLECARI' table. You can move, or remove it, as needed.
            this.pLECARITableAdapter2.Fill(this.autogaraDataSet13.PLECARI);
            // TODO: This line of code loads data into the 'autogaraDataSet12.SOSIRI' table. You can move, or remove it, as needed.
            this.sOSIRITableAdapter2.Fill(this.autogaraDataSet12.SOSIRI);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





    }
}
