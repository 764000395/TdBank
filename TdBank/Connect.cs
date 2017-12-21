using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace TdBank
{
    class Connect
    {
        MySqlConnection con;
        MySqlCommand cmd = null;
        MySqlDataReader reader;
        //连接数据库
        public Connect() {
            yzy_1610121031.SomeString someStr = new yzy_1610121031.SomeString();
            string constr = someStr.getMySqlStr();
            con = new MySqlConnection(constr);
            //bool isConnectedOk = false;
            try
            {
                con.Open();
                
                //isConnectedOk = true;
            }
            catch
            {
                //isConnectedOk = false;
                MessageBox.Show("远程连接数据库失败!");
            }
            finally
            {
                con.Clone();
            }
        }

        //关闭数据库连接
        public void close() {
            con.Close();
        }

        //验证登录
        public int login(string username, string password) {
            //查询到结果 result为user_id  查不到 为0
            int result = 0;
            string sb = "SELECT user_id FROM users WHERE username = ?username AND password = ?password";
            
            cmd = new MySqlCommand(sb, con);
            cmd.Parameters.AddWithValue("?username", username);
            cmd.Parameters.AddWithValue("?password", password);
            reader = cmd.ExecuteReader();
            if(reader.Read()) {
                result = int.Parse(reader[0].ToString());
            }
            return result;
        }

        //注册
        public void register( string []data ) {

        }
    }
}
