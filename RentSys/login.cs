using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentSys
{
    public partial class login : Form
    {
        public static string loginUser;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户名和密码
            string username = this.username.Text;
            string password = this.password.Text;
            //判断用户名密码是否正确/为空
            if (username.Equals("") || password.Equals(""))
            {
                warning.Visible = true;
            }
            else
            {
                string connectionString = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "Select * from admins where ad_name='" + username + "' and ad_psw='" + password + "'";//查找用户sql语句
                SqlCommand cmd = new SqlCommand(sql, SqlCon);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                if (sdr.Read())         //从结果中找到
                {
                    loginUser = username;
                    系统主页 main = new 系统主页();
                    main.Show();
                    this.Hide();
                }
                //输入用户名和密码错误的情况
                else
                {
                    warning.Visible = true;
                    return;
                }
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register Register = new register();
            Register.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forget_psw forgetpsw = new forget_psw();
            forgetpsw.Show();
        }
    }
}
