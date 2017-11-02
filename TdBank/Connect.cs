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
        
        public Connect() {
            string constr = "Server=127.0.0.1;User Id=root;password=;Database=GoodPage";
            MySqlConnection con = new MySqlConnection(constr);
            bool isConnectedOk = false;
            try
            {
                con.Open();
                isConnectedOk = true;
            }
            catch
            {
                isConnectedOk = false;
                MessageBox.Show("远程连接数据库失败!");
            }
            finally
            {
                con.Clone();
            }
        }
    }
}
