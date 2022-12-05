using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            DataGridViewButtonColumn dgv_button_col = new DataGridViewButtonColumn();

            // 设定列的名字
            dgv_button_col.Name = "update";

            // 在所有按钮上表示"查看详情"
            dgv_button_col.UseColumnTextForButtonValue = true;
            dgv_button_col.Text = "修改";

            // 设置列标题
            dgv_button_col.HeaderText = "操作";

            // 向DataGridView追加
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, dgv_button_col);

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();

            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            

            this.dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

           
            this.dataGridView1.RowsDefaultCellStyle = headerStyle;


        } 
        commodit c = new commodit();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "update")
            {
                //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; 被点击了");
               int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
               string  name = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
               decimal price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
               DateTime time = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
               
               int number = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
               string type = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                //string id = dataGridView1.Rows[0].Cells[0].ToString();
               
                c.id = id;
                c.name = name;
                c.price = price;
                c.time = time;
                c.number = number;
                c.type = type;

                update update = new update();
                update.Co(c);
                this.Hide();
                update.Show();
                
            }
        }
    }
}
