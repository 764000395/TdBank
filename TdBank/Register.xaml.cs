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

            /*用户名*/
            string username = usernameText.Text;
            //用户名只能包含数字和字母
            if (Regex.IsMatch(username, @"\W") || username.Length < 1)
            {   //    "\W" : 匹配任何非单词字符。等价于“[^A-Za-z0-9_]”。
                MessageBox.Show("卡号只能包含数字和字母，请重新输入用户名", "错误");
                return;
            }

            data[0] = username;

            /*密码*/
            string password = passwordText.Password;
            //密码只能包含数字字母 和 .!@#_
            if (Regex.IsMatch(username, "[^a-zA-z0-9.!@#_]") || password.Length < 1)
            {
                MessageBox.Show("密码只能包含数字和字母和 .!@#_这五个字符，请重新输", "错误");
                return;
            }
            //检查两次输入密码是否一致
            string password1 = passwordText1.Password;
            if (!string.Equals(password, password1)) {
                MessageBox.Show("两次输入的密码不一致，请重新输入", "错误");
                return;
            }

            data[1] = password;

            /*姓名*/
            string nickname = nicknameText.Text;
            if (Regex.IsMatch(nickname, @"[<\/>]") || nickname.Length < 1 ) {
                MessageBox.Show("昵称不能为空且不能包含非法字符，请重新输入", "错误");
                return;
            }

            data[2] = nickname;

        }
    }
}
