
namespace supermarket
{
    partial class update
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.commoditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDataSet = new supermarket.supermarketDataSet();
            this.commoditBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new supermarket.supermarketDataSetTableAdapters.typesTableAdapter();
            this.typesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commoditTableAdapter = new supermarket.supermarketDataSetTableAdapters.commoditTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.commoditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(285, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "修改商品信息";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "过期时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "商品数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "商品类型";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(280, 132);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 29);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(280, 239);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 29);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commoditBindingSource
            // 
            this.commoditBindingSource.DataMember = "commodit";
            this.commoditBindingSource.DataSource = this.supermarketDataSet;
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "supermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commoditBindingSource1
            // 
            this.commoditBindingSource1.DataMember = "commodit";
            this.commoditBindingSource1.DataSource = this.supermarketDataSetBindingSource;
            // 
            // supermarketDataSetBindingSource
            // 
            this.supermarketDataSetBindingSource.DataSource = this.supermarketDataSet;
            this.supermarketDataSetBindingSource.Position = 0;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.supermarketDataSet;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // typesBindingSource1
            // 
            this.typesBindingSource1.DataMember = "types";
            this.typesBindingSource1.DataSource = this.supermarketDataSet;
            // 
            // commoditTableAdapter
            // 
            this.commoditTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "饮料",
            "辣条",
            "速冻饺子",
            "酱油"});
            this.comboBox1.Location = new System.Drawing.Point(280, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 25);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commoditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoditBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private supermarketDataSet supermarketDataSet;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private supermarketDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource1;
        private System.Windows.Forms.BindingSource commoditBindingSource;
        private supermarketDataSetTableAdapters.commoditTableAdapter commoditTableAdapter;
        private System.Windows.Forms.BindingSource commoditBindingSource1;
        private System.Windows.Forms.BindingSource supermarketDataSetBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}