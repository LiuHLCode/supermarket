using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Tools;

namespace supermarket
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = "";
            string str1 = textBox1.Text.Trim();
            string str2 = textBox2.Text.Trim();
            if (!str1.Equals(null) && !str1.Equals(""))
            {
                List<commodit> list = new List<commodit>();
                string sql = "select * from commodit where name like '" + '%' + str1 + '%' + "' ";
                DataSet ds = DBHelper.Select(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
               
            }
              if (!str2.Equals(null) && !str2.Equals(""))
                {
                    List<commodit> list = new List<commodit>();
                    string sql = "select * from commodit where price = '" + str2 + "'";
                    DataSet ds = DBHelper.Select(sql);
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
            if ( str1.Equals("")
                 && str2.Equals(""))
            {
                List<commodit> list = new List<commodit>();
                string sql = "select * from commodit";
                DataSet ds = DBHelper.Select(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodit”中。您可以根据需要移动或删除它。
            //this.commoditTableAdapter.Fill(this.supermarketDataSet.commodit);
            List<commodit> list = new List<commodit>();
            string sql = "select * from commodit";
            DataSet ds = DBHelper.Select(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 添加_Click(object sender, EventArgs e)
        {

        }
    }
}
