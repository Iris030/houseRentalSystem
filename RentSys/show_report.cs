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
using System.Xml;

namespace RentSys
{
    public partial class show_report : Form
    {
        public show_report(ListViewItem item)
        {
            InitializeComponent();
            reid.Text = item.SubItems[0].Text;
        }

        private void show_report_Load(object sender, EventArgs e)
        {
            //连接数据库
            //设置连接字符串
            string constr = "server=.,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();

            SqlCommand Cmd = mycon.CreateCommand();       //创建SQL命令执行对象
            string s = "select * from reports where re_id = " + int.Parse(reid.Text) + "";
            Cmd.CommandText = s;
            SqlDataAdapter report = new SqlDataAdapter();       //实例化数据适配器
            report.SelectCommand = Cmd;                   //让适配器执行SELECT命令
            DataTable re_dt = new DataTable();
            report.Fill(re_dt);

            dd.Text = re_dt.Rows[0]["re_date"].ToString();
            admin.Text = re_dt.Rows[0]["re_admin"].ToString();
            avr_empty.Text = re_dt.Rows[0]["re_ave_empty"].ToString();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(re_dt.Rows[0]["re_buildings"].ToString());

            foreach (XmlNode node in doc.SelectSingleNode("Buildings").SelectNodes("building"))
            {
                ListViewItem item = new ListViewItem();
                item.Text = node.SelectSingleNode("b_name").InnerText;
                item.SubItems.Add(node.SelectSingleNode("b_owner").InnerText);
                item.SubItems.Add(node.SelectSingleNode("b_area").InnerText);
                item.SubItems.Add(node.SelectSingleNode("b_addr").InnerText);
                item.SubItems.Add(node.SelectSingleNode("b_empty").InnerText);
                listView1.Items.Add(item);
            }
        }
    }
}
