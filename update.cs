using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tools;

namespace supermarket
{
   
    public partial class update : Form
    {
        private static commodit com = null;
        public update()
        {
            InitializeComponent();
        }
        public void Co(commodit commodit)
        {
            com = commodit;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void update_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodit”中。您可以根据需要移动或删除它。
            //this.commoditTableAdapter.Fill(this.supermarketDataSet.commodit);
            // TODO: 这行代码将数据加载到表“supermarketDataSet.types”中。您可以根据需要移动或删除它。
            //this.typesTableAdapter.Fill(this.supermarketDataSet.types);
            int id = com.id;
             
            this.textBox1.Text = com.name;
            this.textBox3.Text = com.price.ToString();
            this.dateTimePicker1.Value = com.time;
            this.textBox4.Text = com.number.ToString();
            this.comboBox1.Text = com.type;

        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = com.id;
            string name = this.textBox1.Text;
            decimal price = Convert.ToDecimal(this.textBox3.Text);
            DateTime time = this.dateTimePicker1.Value;
            int number = Convert.ToInt32( this.textBox4.Text );
            string type = this.comboBox1.Text;
            string sql = "update  commodit set name = '" + name+ "'," +
                                               "price ='"+price+"', " +
                                               "time ='" + time + "'," +
                                                "number ='" + number + "'," +
                                                "type ='" + type + 
                                                "'where id = '"+ id+"' " ;
            bool bo = DBHelper.Update(sql);
            if (bo)
            {
                MessageBox.Show("修改成功，即将跳转首页");
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
