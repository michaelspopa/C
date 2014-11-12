using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("Welcome:" + username_txt.Text);
            f2.Show();
            this.Hide();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'database1DataSet1.e_info' table. You can move, or remove it, as needed.
            this.e_infoTableAdapter.Fill(this.database1DataSet1.e_info);

            timer1.Start();
            timer1.Enabled = true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(+3);
            if (progressBar1.Value == 99)
            { 
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            
            }


        }
    }
}
