using System.Data;
using System.Data.SqlClient;
namespace Tools
{
    public static class DBHelper
    {
        //
        private static string conStr = @"Data Source=175.178.160.50;
        database=supermarket;
        uid=sa;
      
         pwd=18365432303Liu.";

        //查询函数 第一个参数sql语句，
        public static DataSet Select(string sql) 
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(com);

                    sda.Fill(ds);

                    con.Close();
                }
            }
            return ds;
        }

        //修改函数
        public static bool Update(string sql)
        {
            bool flag = false;//标记是否更新成功
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    con.Open();
                    if (com.ExecuteNonQuery() > 0)
                    {
                        flag = true;
                    }
                    con.Close();
                }
            }
            return flag;
        }


        #region 标明函数意义
		 
	
        //插入函数
        public static bool Insert(string sql)
        {
            return Update(sql);
        }

        //删除函数
        public static bool Delete(string sql)
        {
            return Update(sql);
        }
        #endregion
    }
}
