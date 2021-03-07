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
    public partial class change_psw : Form
    {
        public change_psw()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            warning.Visible = false;
            string psw = newpsw.Text.Trim();
            if (psw == "")
            {
                warning.Text = "请输入新密码";
                warning.Visible = true;
                return;
            }
            string constr = "server=.,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();
            //新注册的用户是否存在
            SqlCommand checkCmd = mycon.CreateCommand();       //创建SQL命令执行对象
            string s = "select ad_psw from admins where ad_psw='" + psw + "'";
            checkCmd.CommandText = s;
            SqlDataAdapter check = new SqlDataAdapter();       //实例化数据适配器
            check.SelectCommand = checkCmd;                    //让适配器执行SELECT命令
            DataSet checkData = new DataSet();                 //实例化结果数据集
            int n = check.Fill(checkData, "register");         //将结果放入数据适配器，返回元祖个数
            if (n != 0)
            {
                warning.Text = "新密码不可与旧密码重复";
                warning.Visible = true;
            }
            else if (psw.Length > 50)
            {
                warning.Text = "密码长度>50";
                warning.Visible = true;
            }
            else
            {
                //插入数据
                string s1 = "update admins set ad_psw = '" + psw + "' where ad_name = '" + login.loginUser + "'";          //编写SQL命令
                SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                mycom.ExecuteNonQuery();   //执行语句
                mycon.Close();             //关闭连接
                mycom = null;
                mycon.Dispose();           //释放对象
                MessageBox.Show("密码修改成功");
            }
        }
    }
}
