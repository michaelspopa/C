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
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 F1 = new Form3();
            F1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cauta ca = new Cauta();
            ca.Show();
            this.Hide();
        }

        private void Second_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";


            SqlConnection conDataBase = new SqlConnection(constring);
            SqlConnection conDataBaseL = new SqlConnection(constring);
            SqlConnection conDataBaseD = new SqlConnection(constring);



            SqlCommand cmdDataBase = new SqlCommand("select * from PLECARI ;", conDataBase);
            SqlCommand cmdDataBaseL = new SqlCommand("select * from SOSIRI ;", conDataBaseL);
            SqlCommand cmdDataBaseD = new SqlCommand("select * from PRINCIPAL ;", conDataBaseD);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;

                SqlDataAdapter sdaL = new SqlDataAdapter();
                sdaL.SelectCommand = cmdDataBaseL;

                SqlDataAdapter sdaD = new SqlDataAdapter();
                sdaD.SelectCommand = cmdDataBaseD;

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                DataTable dbdatasetL = new DataTable();
                sdaL.Fill(dbdatasetL);

                DataTable dbdatasetD = new DataTable();
                sdaD.Fill(dbdatasetD);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                BindingSource bSourceL = new BindingSource();

                bSourceL.DataSource = dbdatasetL;
                dataGridView2.DataSource = bSourceL;
                sdaL.Update(dbdatasetL);

                BindingSource bSourceD = new BindingSource();

                bSourceD.DataSource = dbdatasetD;
                dataGridView3.DataSource = bSourceD;
                sdaL.Update(dbdatasetD);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
