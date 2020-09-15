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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login Login = new login();
            Login.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //初始化
            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;
            warning4.Visible = false;
            //获取输入的用户名 
            string name = username.Text.Trim();
            string mail = email.Text.Trim();
            string psw = password.Text.Trim();
            string psw2 = pswdCheck.Text.Trim();
            //检查是否空
            if (name == "" || mail == "" || psw == "" || psw2 == "")
            {
                warning3.Visible = true;
                return;
            }
            //检查二次确认密码
            if (psw2 != psw)
            {
                warning2.Text = "密码不一致";
                warning2.Visible = true;
            }
            if (psw.Length > 50)
            {
                warning2.Text = "密码长度>50";
                warning2.Visible = true;
            }
            //检查邮箱格式
            if (!mail.Contains("@"))
            {
                warning1.Text = "邮箱格式错误";
                warning1.Visible = true;
            }
            if (mail.Length > 255)
            {
                warning1.Text = "邮箱长度>255";
                warning1.Visible = true;
            }

            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();
            //新注册的用户是否存在
            SqlCommand checkCmd = mycon.CreateCommand();       //创建SQL命令执行对象
            string s = "select ad_name from admins where ad_name='" + name + "'";
            checkCmd.CommandText = s;
            SqlDataAdapter check = new SqlDataAdapter();       //实例化数据适配器
            check.SelectCommand = checkCmd;                    //让适配器执行SELECT命令
            DataSet checkData = new DataSet();                 //实例化结果数据集
            int n = check.Fill(checkData);         //将结果放入数据适配器，返回元祖个数
            if (n != 0)
            {
                warning4.Text = "用户名存在";
                warning4.Visible = true;
            }
            else if (name.Length > 50)
            {
                warning4.Text = "名字长度>50";
                warning4.Visible = true;
            }
            else
            {
                //插入数据
                string s1 = "insert into admins(ad_name,ad_email,ad_psw) values ('" + name + "','" + mail + "','" + psw + "')";          //编写SQL命令

                SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                mycom.ExecuteNonQuery();   //执行语句
                mycon.Close();             //关闭连接
                mycom = null;
                mycon.Dispose();           //释放对象
                系统主页 main = new 系统主页();
                main.Show();
                this.Hide();
                this.Close();
            }

        }
    }
}
