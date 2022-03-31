using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 酒店后台管理应用
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str= "Data Source=LAPTOP-8PAESPIS;Initial Catalog=HotelDB;Persist Security Info=True;User ID=sa;Password=asdjb12138";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//更新
        {
            return command(sql).ExecuteNonQuery();
          
        }
    
        public SqlDataReader read(string sql)//读取
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();
        }
    }
}
