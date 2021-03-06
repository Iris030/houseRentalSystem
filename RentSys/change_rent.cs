﻿using System;
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
    public partial class change_rent : Form
    {
        public change_rent(ListViewItem item, string bid)
        {
            InitializeComponent();
            old_addr.Text = item.SubItems[0].Text;
            r_bid.Text = bid;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //初始化
            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;
            noWarning.Visible = false;
            //获取输入值
            string rent = r_rent.Text.Trim();
            string area = r_area.Text.Trim();
            string no = r_no.Text.Trim();
            string addr = r_addr.Text.Trim();
            string fee = r_fee.Text.Trim();
            string more = r_more.Text.Trim();
            string owing = r_owing.Text.Trim();
            string pledge = r_pledge.Text.Trim();
            string price = r_price.Text.Trim();
            string start = r_start.Value.ToString("yyyy-MM-dd");
            string end = r_end.Value.ToString("yyyy-MM-dd");
            //检查是否空
            if (addr.Length > 100)
            {
                warning1.Text = "长度>100";
                warning1.Visible = true;
            }
            if (rent.Length > 50)
            {
                warning2.Visible = true;
            }
            if (more.Length > 300)
            {
                warning3.Visible = true;
            }
            if (no.Length > 50)
            {
                noWarning.Visible = true;
            }
            else
            {
                //连接数据库
                //设置连接字符串
                string constr = "server=.,1433;database=RentSysData;User id=sa;password=passwordmima";
                SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
                mycon.Open();
                //addr是否存在
                SqlCommand checkCmd = mycon.CreateCommand();       //创建SQL命令执行对象
                string s = "select r_addr from rents where r_addr='" + addr + "' and r_bid = ' " + r_bid.Text + " '";
                checkCmd.CommandText = s;
                SqlDataAdapter check = new SqlDataAdapter();       //实例化数据适配器
                check.SelectCommand = checkCmd;                    //让适配器执行SELECT命令
                DataSet checkData = new DataSet();                 //实例化结果数据集
                int n = check.Fill(checkData);         //将结果放入数据适配器，返回元祖个数
                if (n != 0)
                {
                    warning1.Text = "已存在";
                    warning1.Visible = true;
                    return;
                }
                if (rent != "" && !rentno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_rent = '" + rent + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                } 
                else if (rentno.Checked)
                {
                    string s1 = "update rents set r_rent = '" + null + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (area != "")
                {
                    //修改建筑面积
                    string s1 = "update rents set r_area = '" + area + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (no != "")
                {
                    //修改房产证号
                    string s1 = "update rents set r_no = '" + no + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (fee != "" && !feeno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_fee = '" + fee + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (feeno.Checked)
                {
                    string s1 = "update rents set r_fee = '" + null + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (more != "" && !moreno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_more = '" + more + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (moreno.Checked)
                {
                    string s1 = "update rents set r_more = '" + null + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (owing != "" && !owingno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_owing = '" + owing + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (owingno.Checked)
                {
                    string s1 = "update rents set r_owing = '" + null + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (pledge != "" && !pledgeno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_pledge = '" + pledge + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (pledgeno.Checked)
                {
                    string s1 = "update rents set r_pledge = '" + null + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (price != "" && !priceno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_price = '" + price + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (priceno.Checked)
                {
                    string s1 = "update rents set r_price = '" + null + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (start != "" && !startno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_start = '" + start + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (startno.Checked)
                {
                    string s1 = "update rents set r_start = null where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (end != "" && !endno.Checked)
                {
                    //修改建筑名称
                    string s1 = "update rents set r_end = '" + end + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                else if (endno.Checked)
                {
                    string s1 = "update rents set r_end = null where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }
                if (addr != "")
                {
                    //修改建筑名称
                    string s1 = "update rents set r_addr = '" + addr + "' where r_addr = '" + old_addr.Text + "'and r_bid = ' " + r_bid.Text + " '";
                    SqlCommand mycom = new SqlCommand(s1, mycon);      //初始化命令
                    mycom.ExecuteNonQuery();   //执行语句
                }

                // delete old reports before creating a new one if report has same date
                string s2 = "delete from reports where re_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                SqlCommand mycom1 = new SqlCommand(s2, mycon);      //初始化命令
                mycom1.ExecuteNonQuery();   //执行语句
                newReport();

                mycon.Close();             //关闭连接
                mycon.Dispose();           //释放对象
                MessageBox.Show("修改成功，页面刷新后显示新修改");
            }
        }

        private void kp(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || (int)e.KeyChar == 8 || (int)e.KeyChar == 25 || (int)e.KeyChar == 26 || (int)e.KeyChar == 27 || (int)e.KeyChar == 28 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
        }

        private void newReport()
        {
            /*
            <?xml version="1.0" encoding="utf-8"?>
            <Buildings>
              <building>
                <b_id></b_id>
                <b_name></b_name>
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
                        <r_no></r_no>
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
            string constr = "server=.,1433;database=RentSysData;User id=sa;password=passwordmima";
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

                XmlElement b_id = buildings.CreateElement("b_id");
                b_id.InnerText = row["b_id"].ToString();
                XmlElement b_name = buildings.CreateElement("b_name");
                b_name.InnerText = row["b_name"].ToString();
                XmlElement b_owner = buildings.CreateElement("b_owner");
                b_owner.InnerText = row["b_owner"].ToString();
                XmlElement b_area = buildings.CreateElement("b_area");
                b_area.InnerText = row["b_area"].ToString();
                XmlElement b_addr = buildings.CreateElement("b_addr");
                b_addr.InnerText = row["b_addr"].ToString();
                building.AppendChild(b_id);
                building.AppendChild(b_name);
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
                    XmlElement r_no = buildings.CreateElement("r_no");
                    r_no.InnerText = r_row["r_no"].ToString();

                    rent.AppendChild(r_rent);
                    rent.AppendChild(r_addr);
                    rent.AppendChild(r_area);
                    rent.AppendChild(r_price);
                    rent.AppendChild(r_owing);
                    rent.AppendChild(r_pledge);
                    rent.AppendChild(r_start);
                    rent.AppendChild(r_end);
                    rent.AppendChild(r_more);
                    rent.AppendChild(r_no);

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
