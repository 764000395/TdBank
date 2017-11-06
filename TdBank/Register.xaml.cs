using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TdBank
{
    /// <summary>
    /// Register.xaml 的交互逻辑
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] data =new string[6];

            /*卡号*/
            string username = usernameText.Text;
            //用户名只能包含数字和字母
            if (Regex.IsMatch(username, "[^a-zA-z0-9]") || username.Length < 1){
                MessageBox.Show("卡号只能包含数字和字母，请重新输入卡号");
                return;
            }

            data[0] = username;

            /*密码*/
            string password = passwordText.Password;
            //密码只能包含数字字母 和 .!@#_
            if (Regex.IsMatch(username, "[^a-zA-z0-9.!@#_]") || password.Length < 1)
            {
                MessageBox.Show("密码只能包含数字和字母和 .!@#_这五个字符，请重新输");
                return;
            }
            //检查两次输入密码是否一致
            string password1 = passwordText1.Password;
            if (!string.Equals(password, password1)) {
                MessageBox.Show("两次输入的密码不一致，请重新输入");
                return;
            }

            data[1] = password;

            /*姓名*/
            string realname = realnameText.Text;
            if (realname.Length < 1 ) {
                MessageBox.Show("姓名不能为空，请输入姓名");
                return;
            }

            data[2] = realname;

            /*身份证*/
            string id_card = id_cardText.Text;
            if (!Regex.IsMatch(id_card, "[0-9]{17}[0-9a-z]+$") || id_card.Length != 18 ) {
                MessageBox.Show("身份证号正确，请重新输入");
                return;
            }

            data[3] = id_card;

            /*存款类型*/

        }
    }
}
