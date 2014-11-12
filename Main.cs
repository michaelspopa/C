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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F1 = new Form2();
            F1.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autogaraDataSet4.PRINCIPAL' table. You can move, or remove it, as needed.
            this.pRINCIPALTableAdapter.Fill(this.autogaraDataSet4.PRINCIPAL);
            // TODO: This line of code loads data into the 'autogaraDataSet3.SOSIRI' table. You can move, or remove it, as needed.
            this.sOSIRITableAdapter1.Fill(this.autogaraDataSet3.SOSIRI);
            // TODO: This line of code loads data into the 'autogaraDataSet2.SOSIRI' table. You can move, or remove it, as needed.
            this.sOSIRITableAdapter.Fill(this.autogaraDataSet2.SOSIRI);
            // TODO: This line of code loads data into the 'autogaraDataSet1.PLECARI' table. You can move, or remove it, as needed.
            this.pLECARITableAdapter.Fill(this.autogaraDataSet1.PLECARI);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search se = new Search();
            se.Show();
            this.Hide();
        }
    }
}
