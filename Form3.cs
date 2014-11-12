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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Second F1 = new Second();
            F1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+5);

            if (progressBar1.Value == 95)
            {
                Form1 fu = new Form1();
                fu.Show();
                this.Hide();

            }
        }
    }
}
