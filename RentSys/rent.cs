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
    public partial class rent : Form
    {
        public rent(ListViewItem item)
        {
            InitializeComponent();
            b_name.Text = item.SubItems[0].Text;
            b_no.Text = item.SubItems[1].Text;
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();
            SqlCommand select = mycon.CreateCommand();       //创建SQL命令执行对象
            string s = "select b_id from buildings where b_no='" + b_no.Text + "'";
            select.CommandText = s;
            SqlDataAdapter sel = new SqlDataAdapter();       //实例化数据适配器
            sel.SelectCommand = select;                    //让适配器执行SELECT命令
            DataTable dt = new DataTable();
            sel.Fill(dt);
            b_id.Text = dt.Rows[0]["b_id"].ToString().Trim();
        }

        private void rent_Load(object sender, EventArgs e)
        {
            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();
            SqlCommand listBCmd = mycon.CreateCommand();       //创建SQL命令执行对象
            string s = "select r_id,r_addr,r_rent,r_area,r_price,r_fee,r_owing,r_pledge,r_start,r_end,r_more from rents where r_bid =' " + b_id.Text + " '";
            listBCmd.CommandText = s;
            SqlDataAdapter listB = new SqlDataAdapter();       //实例化数据适配器
            listB.SelectCommand = listBCmd;                   //让适配器执行SELECT命令
            DataTable dt = new DataTable();
            listB.Fill(dt);

            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string i=null;
                if (row["r_area"].ToString() != "" && row["r_price"].ToString() != "")
                {
                    float tmp = float.Parse(row["r_area"].ToString()) * float.Parse(row["r_price"].ToString());
                    i = tmp.ToString();
                }
                
                //Add Item to ListView.
                ListViewItem item = new ListViewItem();
                item.Text = row["r_addr"].ToString();
                item.SubItems.Add(row["r_rent"].ToString());
                item.SubItems.Add(row["r_area"].ToString());
                item.SubItems.Add(row["r_price"].ToString());
                item.SubItems.Add(i);
                item.SubItems.Add(row["r_fee"].ToString());
                item.SubItems.Add(row["r_owing"].ToString());
                item.SubItems.Add(row["r_pledge"].ToString());
                item.SubItems.Add(row["r_start"].ToString());
                item.SubItems.Add(row["r_end"].ToString());
                item.SubItems.Add(row["r_more"].ToString());
                item.SubItems.Add(row["r_id"].ToString());

                if (row["r_end"].ToString() != "" && DateTime.Compare(Convert.ToDateTime(row["r_end"].ToString()), DateTime.Now) < 0)
                {
                    item.BackColor = Color.PapayaWhip;
                }

                listView1.Items.Add(item);
            }

        }

        private void addRent_Click(object sender, EventArgs e)
        {
            add_rent add = new add_rent(b_no);
            add.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            rent_Load(sender, e);
        }

        private void changeRent_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    change_rent change = new change_rent(item, b_id.Text);
                    change.Show();
                }
            }
        }

        private void deleteRent_Click(object sender, EventArgs e)
        {
            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    string s2 = "delete from rents where r_id = '" + item.SubItems[11].Text + "'";
                    SqlCommand listBCmd = new SqlCommand(s2, mycon);      //初始化命令
                    listBCmd.ExecuteNonQuery();                              //执行语句
                }
            }

            // delete old reports before creating a new one if report has same date
            string s = "delete from reports where re_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            SqlCommand mycom = new SqlCommand(s, mycon);      //初始化命令
            mycom.ExecuteNonQuery();   //执行语句
            newReport();

            mycon.Close();             //关闭连接
            mycon.Dispose();           //释放对象
            MessageBox.Show("删除成功，刷新表格后显示新数据");
        }

        private void cb_all_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                item.Checked = cb_all.Checked;
        }

        private void newReport()
        {
            /*
            <?xml version="1.0" encoding="utf-8"?>
            <Buildings>
              <building b_id="1">
                <b_name></b_name>
                <b_no></b_no>
                <b_owner></b_owner>
                <b_area></b_area>
                <b_addr></b_addr>
                <rents>
                    <rent r_id="1">
                        <r_rent></r_rent>
                        <r_addr></r_addr>
                        <r_area></r_area>
                        <r_price></r_price>
                        <r_fee></r_fee>
                        <r_owing></r_owing>
                        <r_pledge></r_pledge>
                        <r_start></r_start>
                        <r_end></r_end>
                        <r_more></r_more>
                    </rent>
                </rents>
                <b_empty></b_empty>
              </building>
            </Buildings>
            */

            XmlDocument buildings = new XmlDocument();

            XmlElement Buildings = buildings.CreateElement("Buildings");
            buildings.AppendChild(Buildings);

            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();

            SqlCommand cmd = mycon.CreateCommand();
            string s1 = "select * from buildings";
            cmd.CommandText = s1;
            SqlDataAdapter adt1 = new SqlDataAdapter();        //实例化数据适配器
            adt1.SelectCommand = cmd;                          //让适配器执行SELECT命令
            DataTable b_dt = new DataTable();              //实例化结果数据集
            adt1.Fill(b_dt);                              //将结果放入数据适配器，返回元祖个数

            string re_date, re_admin_id, re_admin;
            float re_ave_empty;

            re_date = DateTime.Now.ToString("yyyy-MM-dd");
            re_admin = login.loginUser;

            string s3 = "select ad_id from admins where ad_name = '" + re_admin + "'";
            cmd.CommandText = s3;
            adt1 = new SqlDataAdapter();                    //实例化数据适配器
            adt1.SelectCommand = cmd;                       //让适配器执行SELECT命令
            DataTable ad = new DataTable();                 //实例化结果数据集
            adt1.Fill(ad);                                  //将结果放入数据适配器，返回元祖个数

            re_admin_id = ad.Rows[0]["ad_id"].ToString();

            foreach (DataRow row in b_dt.Rows)
            {
                string s2 = "select * from rents where r_rent != '' and r_bid = '" + row["b_id"].ToString() + "'";
                cmd.CommandText = s2;
                SqlDataAdapter adt2 = new SqlDataAdapter();        //实例化数据适配器
                adt2.SelectCommand = cmd;                          //让适配器执行SELECT命令
                DataTable r_dt = new DataTable();              //实例化结果数据集
                adt2.Fill(r_dt);                              //将结果放入数据适配器，返回元祖个数

                XmlElement building = buildings.CreateElement("building");
                building.SetAttribute("b_id", row["b_id"].ToString());
                Buildings.AppendChild(building);

                XmlElement b_name = buildings.CreateElement("b_name");
                b_name.InnerText = row["b_name"].ToString();
                XmlElement b_no = buildings.CreateElement("b_no");
                b_no.InnerText = row["b_no"].ToString();
                XmlElement b_owner = buildings.CreateElement("b_owner");
                b_owner.InnerText = row["b_owner"].ToString();
                XmlElement b_area = buildings.CreateElement("b_area");
                b_area.InnerText = row["b_area"].ToString();
                XmlElement b_addr = buildings.CreateElement("b_addr");
                b_addr.InnerText = row["b_addr"].ToString();
                building.AppendChild(b_name);
                building.AppendChild(b_no);
                building.AppendChild(b_owner);
                building.AppendChild(b_area);
                building.AppendChild(b_addr);

                XmlElement rents = buildings.CreateElement("rents");
                building.AppendChild(rents);

                float area_total = 0;
                foreach (DataRow r_row in r_dt.Rows)
                {
                    XmlElement rent = buildings.CreateElement("rent");
                    rent.SetAttribute("r_id", r_row["r_id"].ToString());
                    rents.AppendChild(rent);

                    XmlElement r_rent = buildings.CreateElement("r_rent");
                    r_rent.InnerText = r_row["r_rent"].ToString();
                    XmlElement r_addr = buildings.CreateElement("r_addr");
                    r_addr.InnerText = r_row["r_addr"].ToString();
                    XmlElement r_area = buildings.CreateElement("r_area");
                    r_area.InnerText = r_row["r_area"].ToString();
                    XmlElement r_price = buildings.CreateElement("r_price");
                    r_price.InnerText = r_row["r_price"].ToString();
                    XmlElement r_fee = buildings.CreateElement("r_fee");
                    r_fee.InnerText = r_row["r_fee"].ToString();
                    XmlElement r_owing = buildings.CreateElement("r_owing");
                    r_owing.InnerText = r_row["r_owing"].ToString();
                    XmlElement r_pledge = buildings.CreateElement("r_pledge");
                    r_pledge.InnerText = r_row["r_pledge"].ToString();
                    XmlElement r_start = buildings.CreateElement("r_start");
                    r_start.InnerText = r_row["r_start"].ToString();
                    XmlElement r_end = buildings.CreateElement("r_end");
                    r_end.InnerText = r_row["r_end"].ToString();
                    XmlElement r_more = buildings.CreateElement("r_more");
                    r_more.InnerText = r_row["r_more"].ToString();

                    rent.AppendChild(r_rent);
                    rent.AppendChild(r_addr);
                    rent.AppendChild(r_area);
                    rent.AppendChild(r_price);
                    rent.AppendChild(r_owing);
                    rent.AppendChild(r_pledge);
                    rent.AppendChild(r_start);
                    rent.AppendChild(r_end);
                    rent.AppendChild(r_more);

                    area_total = area_total + float.Parse(r_row["r_area"].ToString());
                }

                XmlElement b_empty = buildings.CreateElement("b_empty");
                b_empty.InnerText = ((1 - (area_total / float.Parse(row["b_area"].ToString()))) * 100).ToString();
                building.AppendChild(b_empty);
            }

            float empty_total = 0;
            int i = 0;
            foreach (XmlNode b in buildings.SelectSingleNode("Buildings").SelectNodes("building"))
            {
                empty_total += float.Parse(b.SelectSingleNode("b_empty").InnerText);
                i++;
            }
            re_ave_empty = empty_total / i;

            s1 = "insert into reports(re_date,re_admin_id,re_admin,re_buildings,re_ave_empty) values ('" + re_date + "','" + re_admin_id + "','" + re_admin + "','" + buildings.OuterXml + "','" + re_ave_empty + "')";
            SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
            mycom.ExecuteNonQuery();   //执行语句
            mycon.Close();             //关闭连接
            mycon.Dispose();           //释放对象
        }
    }
}
