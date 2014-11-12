namespace Autogara
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.autogaraDataSet8 = new Autogara.AutogaraDataSet8();
            this.sOSIRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOSIRITableAdapter = new Autogara.AutogaraDataSet8TableAdapters.SOSIRITableAdapter();
            this.autogaraDataSet9 = new Autogara.AutogaraDataSet9();
            this.pLECARIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLECARITableAdapter = new Autogara.AutogaraDataSet9TableAdapters.PLECARITableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autogaraDataSet10 = new Autogara.AutogaraDataSet10();
            this.sOSIRIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sOSIRITableAdapter1 = new Autogara.AutogaraDataSet10TableAdapters.SOSIRITableAdapter();
            this.autogaraDataSet11 = new Autogara.AutogaraDataSet11();
            this.pLECARIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pLECARITableAdapter1 = new Autogara.AutogaraDataSet11TableAdapters.PLECARITableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOSIRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECARIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOSIRIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECARIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reload Sosiri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reload Plecari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1159, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // autogaraDataSet8
            // 
            this.autogaraDataSet8.DataSetName = "AutogaraDataSet8";
            this.autogaraDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOSIRIBindingSource
            // 
            this.sOSIRIBindingSource.DataMember = "SOSIRI";
            this.sOSIRIBindingSource.DataSource = this.autogaraDataSet8;
            // 
            // sOSIRITableAdapter
            // 
            this.sOSIRITableAdapter.ClearBeforeFill = true;
            // 
            // autogaraDataSet9
            // 
            this.autogaraDataSet9.DataSetName = "AutogaraDataSet9";
            this.autogaraDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLECARIBindingSource
            // 
            this.pLECARIBindingSource.DataMember = "PLECARI";
            this.pLECARIBindingSource.DataSource = this.autogaraDataSet9;
            // 
            // pLECARITableAdapter
            // 
            this.pLECARITableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(638, 440);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(614, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sosiri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(690, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plecari";
            // 
            // autogaraDataSet10
            // 
            this.autogaraDataSet10.DataSetName = "AutogaraDataSet10";
            this.autogaraDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOSIRIBindingSource1
            // 
            this.sOSIRIBindingSource1.DataMember = "SOSIRI";
            this.sOSIRIBindingSource1.DataSource = this.autogaraDataSet10;
            // 
            // sOSIRITableAdapter1
            // 
            this.sOSIRITableAdapter1.ClearBeforeFill = true;
            // 
            // autogaraDataSet11
            // 
            this.autogaraDataSet11.DataSetName = "AutogaraDataSet11";
            this.autogaraDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLECARIBindingSource1
            // 
            this.pLECARIBindingSource1.DataMember = "PLECARI";
            this.pLECARIBindingSource1.DataSource = this.autogaraDataSet11;
            // 
            // pLECARITableAdapter1
            // 
            this.pLECARITableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 313);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(638, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(614, 313);
            this.dataGridView2.TabIndex = 11;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOSIRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECARIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOSIRIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autogaraDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECARIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private AutogaraDataSet8 autogaraDataSet8;
        private System.Windows.Forms.BindingSource sOSIRIBindingSource;
        private AutogaraDataSet8TableAdapters.SOSIRITableAdapter sOSIRITableAdapter;
        private AutogaraDataSet9 autogaraDataSet9;
        private System.Windows.Forms.BindingSource pLECARIBindingSource;
        private AutogaraDataSet9TableAdapters.PLECARITableAdapter pLECARITableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AutogaraDataSet10 autogaraDataSet10;
        private System.Windows.Forms.BindingSource sOSIRIBindingSource1;
        private AutogaraDataSet10TableAdapters.SOSIRITableAdapter sOSIRITableAdapter1;
        private AutogaraDataSet11 autogaraDataSet11;
        private System.Windows.Forms.BindingSource pLECARIBindingSource1;
        private AutogaraDataSet11TableAdapters.PLECARITableAdapter pLECARITableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}