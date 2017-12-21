using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// 天地银行登录界面
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        private int status = 0;
        public LoginWindow()
        {
            InitializeComponent();

            //登录按钮点击事件注册
            login.Click += login_Click;

            //注册按钮点击事件注册
            register.Click += Register_Click;

            //登录窗口关闭事件
            this.Closing += LoginWindow_Closing;
        }

        

        //登录
        private void login_Click(object sender, RoutedEventArgs e)
        {
            var username = usernameText.Text;
            var password = passwordText.Password;
            Connect con = new Connect();
            int result = con.login(username, password);
            if (result != 0)
            {
                MainWindow.userId = result;
                con.close();
                this.status = 1;
                this.Close();
            }
            else {
                MessageBox.Show("卡号或密码错误");
                con.close();
            }
        }

        //注册
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        //登录窗口关闭
        private void LoginWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.status == 0) {
                App.Current.Shutdown();
            }
        }

    }
}
