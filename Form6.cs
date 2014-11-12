﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            load_table();
        }

        void load_table()
        {

            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlConnection conDataBaseL = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand("select * from SOSIRI ;", conDataBase);
            SqlCommand cmdDataBaseL = new SqlCommand("select * from PRINCIPAL ;", conDataBaseL);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;

                SqlDataAdapter sdaL = new SqlDataAdapter();
                sdaL.SelectCommand = cmdDataBaseL;

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                DataTable dbdatasetL = new DataTable();
                sdaL.Fill(dbdatasetL);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                BindingSource bSourceL = new BindingSource();

                bSourceL.DataSource = dbdatasetL;
                dataGridView2.DataSource = bSourceL;
                sdaL.Update(dbdatasetL);






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlConnection conDataBaseL = new SqlConnection(constring);


            SqlCommand cmdDataBase = new SqlCommand("select * from SOSIRI ;", conDataBase);
            SqlCommand cmdDataBaseL = new SqlCommand("select * from PRINCIPAL ;", conDataBaseL);


            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;

                SqlDataAdapter sdaL = new SqlDataAdapter();
                sdaL.SelectCommand = cmdDataBaseL;

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                DataTable dbdatasetL = new DataTable();
                sdaL.Fill(dbdatasetL);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                BindingSource bSourceL = new BindingSource();

                bSourceL.DataSource = dbdatasetL;
                dataGridView2.DataSource = bSourceL;
                sdaL.Update(dbdatasetL);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            string Query = " insert into SOSIRI (ID, AUTOVEHICOL, ORIGINE, TIP_DIRECTIE, PERON, ORA, LOCURI) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "', '" + this.textBox7.Text + "' );";
            string Query1 = "insert into PRINCIPAL (ID, AUTOVEHICOL, TIP_DIRECTIE, ORA, ZIUA) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox4.Text + "', '" + this.textBox6.Text + "', '" + this.textBox8.Text + "' );";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlConnection conDataBaseL = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlCommand cmdDataBaseL = new SqlCommand(Query1, conDataBaseL);



            SqlDataReader myReader;
            SqlDataReader myReaderL;

            try
            {
                conDataBaseL.Open();
                myReaderL = cmdDataBaseL.ExecuteReader();

                MessageBox.Show("Salvat");
                while (myReaderL.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("Salvat");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            string Query = " update SOSIRI set ID='" + this.textBox1.Text + "', AUTOVEHICOL='" + this.textBox2.Text + "', ORIGINE='" + this.textBox3.Text + "',TIP_DIRECTIE= '" + this.textBox4.Text + "',PERON= '" + this.textBox5.Text + "',ORA= '" + this.textBox6.Text + "',LOCURI= '" + this.textBox7.Text + "' where ID ='" + this.textBox1.Text + "' ;";
            string Query1 = "update PRINCIPAL set ID='" + this.textBox1.Text + "',AUTOVEHICOL='" + this.textBox2.Text + "', TIP_DIRECTIE='" + this.textBox4.Text + "', ORA='" + this.textBox6.Text + "', ZIUA='" + this.textBox8.Text + "'where ID ='" + this.textBox1.Text + "';";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlConnection conDataBaseL = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlCommand cmdDataBaseL = new SqlCommand(Query1, conDataBaseL);



            SqlDataReader myReader;
            SqlDataReader myReaderL;




            try
            {
                conDataBaseL.Open();
                myReaderL = cmdDataBaseL.ExecuteReader();

                MessageBox.Show("Modificat");
                while (myReaderL.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Modificat");
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
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\serby\documents\visual studio 2010\Projects\Autogara\Autogara\Autogara.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            string Query1 = " delete from PRINCIPAL where ID='" + this.textBox1.Text + "'  ;";
            string Query = " delete from SOSIRI where ID='" + this.textBox1.Text + "'  ;";


            SqlConnection conDataBase = new SqlConnection(constring);
            SqlConnection conDataBaseL = new SqlConnection(constring);

            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlCommand cmdDataBaseL = new SqlCommand(Query1, conDataBaseL);



            SqlDataReader myReader;
            SqlDataReader myReaderL;

            try
            {
                conDataBaseL.Open();
                myReaderL = cmdDataBaseL.ExecuteReader();

                MessageBox.Show("Sters");
                while (myReaderL.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Sters");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main mm = new Main();
            mm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
