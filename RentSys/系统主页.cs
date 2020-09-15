using System;
using System.IO;
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
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;



namespace RentSys
{
    public partial class 系统主页 : Form
    {
        public 系统主页()
        {
            InitializeComponent();
            name.Text = login.loginUser;
        }

        private void leave_Click(object sender, EventArgs e)
        {
            login log_page = new login();
            log_page.Show();
            this.Hide();
            this.Close();
        }

        private void c_password_Click(object sender, EventArgs e)
        {
            change_psw cpsw = new change_psw();
            cpsw.Show();
        }

        private void c_email_Click(object sender, EventArgs e)
        {
            change_email cem = new change_email();
            cem.Show();
        }

        private void c_name_Click(object sender, EventArgs e)
        {
            change_name cn = new change_name();
            cn.Show();
        }

        private void 系统主页_Load(object sender, EventArgs e)
        {
            name.Text = login.loginUser;
            //连接数据库
            //设置连接字符串
            //server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();
            
            //**********************************************************************************************************
            // add elements to buildings listView, tab1
            SqlCommand listBCmd = mycon.CreateCommand();       //创建SQL命令执行对象
            string s = "select b_id, b_name, b_no, b_owner, b_area, b_addr from buildings";
            listBCmd.CommandText = s;
            SqlDataAdapter listB = new SqlDataAdapter();       //实例化数据适配器
            listB.SelectCommand = listBCmd;                   //让适配器执行SELECT命令
            DataTable dt = new DataTable();
            listB.Fill(dt);

            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                s = "select r_area from rents where r_bid = " + row["b_id"] + " and r_rent != ''";
                listBCmd.CommandText = s;
                listB = new SqlDataAdapter();                       //实例化数据适配器
                listB.SelectCommand = listBCmd;                     //让适配器执行SELECT命令
                DataTable r_dt = new DataTable();
                listB.Fill(r_dt);                                   //所有出租了的面积
                //计算面积和算空置率
                float total = 0;
                foreach (DataRow r in r_dt.Rows)
                {
                    total = total + float.Parse(r["r_area"].ToString());
                }
                float empty = (1 - (total/float.Parse(row["b_area"].ToString())))*100;

                //Add Item to ListView.
                ListViewItem item = new ListViewItem();
                item.Text = row["b_name"].ToString();
                item.SubItems.Add(row["b_no"].ToString());
                item.SubItems.Add(row["b_owner"].ToString());
                item.SubItems.Add(row["b_area"].ToString());
                item.SubItems.Add(row["b_addr"].ToString());
                item.SubItems.Add(empty.ToString());
                listView1.Items.Add(item);
            }

            //************************************************************************************************************
            // add elements to rents listView, tab2
            s = "select r_addr, r_rent, r_area, r_price, r_fee, r_owing, r_pledge, r_start, r_end, r_more, r_bid from rents";
            listBCmd.CommandText = s;
            listB = new SqlDataAdapter();                       //实例化数据适配器
            listB.SelectCommand = listBCmd;                     //让适配器执行SELECT命令
            DataTable r_dt2 = new DataTable();
            listB.Fill(r_dt2);
            listView2.Items.Clear();
            foreach (DataRow row in r_dt2.Rows)
            {
                s = "select b_name, b_addr from buildings where b_id = " + row["r_bid"].ToString() + "";
                listBCmd.CommandText = s;
                listB = new SqlDataAdapter();                       //实例化数据适配器
                listB.SelectCommand = listBCmd;                     //让适配器执行SELECT命令
                DataTable b_dt = new DataTable();
                listB.Fill(b_dt);

                string i = null;
                if (row["r_area"].ToString() != "" && row["r_price"].ToString() != "")
                {
                    float tmp = float.Parse(row["r_area"].ToString()) * float.Parse(row["r_price"].ToString());
                    i = tmp.ToString();
                }

                //Add Item to ListView.
                ListViewItem item = new ListViewItem();
                item.Text = b_dt.Rows[0]["b_name"].ToString();
                item.SubItems.Add(b_dt.Rows[0]["b_addr"].ToString()+ "," + row["r_addr"].ToString());
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
                
                if (row["r_end"].ToString() != "" && DateTime.Compare(Convert.ToDateTime(row["r_end"].ToString()), DateTime.Now) < 0)
                {
                    item.BackColor = Color.PapayaWhip;
                }
                
                listView2.Items.Add(item);
            }

            //*********************************************************************************************************
            // add elememts to reports listView, tab3
            s = "select re_id, re_date from reports";
            listBCmd.CommandText = s;
            listB = new SqlDataAdapter();                       //实例化数据适配器
            listB.SelectCommand = listBCmd;                     //让适配器执行SELECT命令
            DataTable re_dt = new DataTable();
            listB.Fill(re_dt);

            count.Text = re_dt.Rows.Count.ToString();
            listView3.Items.Clear();
            foreach (DataRow row in re_dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["re_id"].ToString();
                item.SubItems.Add(row["re_date"].ToString());
                listView3.Items.Add(item);
            }

        }

        private void addBuilding_Click(object sender, EventArgs e)
        {
            添加建筑 b_add = new 添加建筑();
            b_add.Show();
        }

        private void refreshBuilding_Click(object sender, EventArgs e)
        {
            系统主页_Load(sender,e);
        }

        private void cb_all_CheckedChanged1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                item.Checked = cb_all.Checked;
        }

        private void cb_all_CheckedChanged2(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
                item.Checked = cb2.Checked;
        }

        private void cb_all_CheckedChanged3(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView3.Items)
                item.Checked = cb3.Checked;
        }

        private void deleteBuilding_Click(object sender, EventArgs e)
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
                    //保存建筑id
                    SqlCommand cmd = mycon.CreateCommand();
                    string s1 = "select b_id from buildings where b_no = '" + item.SubItems[1].Text + "'";
                    cmd.CommandText = s1;
                    SqlDataAdapter l = new SqlDataAdapter();        //实例化数据适配器
                    l.SelectCommand = cmd;                          //让适配器执行SELECT命令
                    DataTable dt = new DataTable();              //实例化结果数据集
                    l.Fill(dt);                              //将结果放入数据适配器，返回元祖个数
                    int id = int.Parse(dt.Rows[0]["b_id"].ToString());
                    //删除租房
                    string s3 = "delete from rents where r_bid = '" + id + "'";
                    SqlCommand listRCmd = new SqlCommand(s3, mycon);      //初始化命令
                    listRCmd.ExecuteNonQuery();                              //执行语句
                    //删除建筑
                    string s2 = "delete from buildings where b_no = '" + item.SubItems[1].Text + "'";
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

        private void changeBuilding_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    修改建筑 change = new 修改建筑(item);
                    change.Show();
                }
            }
        }

        private void more_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    rent r_show = new rent(item);
                    r_show.Show();
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

            foreach (ListViewItem item in listView2.Items)
            {
                if (item.Checked)
                {
                    string s2 = "delete from rents where r_id = '" + int.Parse(item.SubItems[12].Text) + "'";
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

        private void search_Click(object sender, EventArgs e)
        {
            系统主页_Load(sender, e);
            int sel = -1;
            if (comboBox1.Text == "建筑名称")
            {
                sel = 0;
            }
            else if (comboBox1.Text == "地址")
            {
                sel = 1;
            }
            else if (comboBox1.Text == "承租人")
            {
                sel = 2;
            }
            else if (comboBox1.Text == "面积")
            {
                sel = 3;
            }
            else if (comboBox1.Text == "租金单价")
            {
                sel = 4;
            }
            else if (comboBox1.Text == "租金")
            {
                sel = 5;
            }
            else if (comboBox1.Text == "管理费")
            {
                sel = 6;
            }
            else if (comboBox1.Text == "欠租")
            {
                sel = 7;
            }
            else if (comboBox1.Text == "押金")
            {
                sel = 8;
            }
            else if (comboBox1.Text == "合同开始日期")
            {
                sel = 9;
            }
            else if (comboBox1.Text == "合同结束日期")
            {
                sel = 10;
            }

            if (sel > -1)
            {
                foreach (ListViewItem item in listView2.Items)
                {
                    if (!item.SubItems[sel].Text.Contains(textBox1.Text))
                    {
                        listView2.Items.Remove(item);
                    }
                }
            }
            else
            {
                系统主页_Load(sender, e);
            }
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

        private void delete_report_Click(object sender, EventArgs e)
        {
            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();
            foreach (ListViewItem item in listView3.Items)
            {
                if (item.Checked)
                {
                    string s = "delete from reports where re_id = '" + int.Parse(item.SubItems[0].Text) + "'";
                    SqlCommand listBCmd = new SqlCommand(s, mycon);      //初始化命令
                    listBCmd.ExecuteNonQuery();                              //执行语句
                }
            }
            MessageBox.Show("删除成功，刷新表格后显示新数据");
            mycon.Close();             //关闭连接
            mycon.Dispose();           //释放对象
        }

        private void report_detail_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView3.Items)
            {
                if (item.Checked)
                {
                    show_report r_show = new show_report(item);
                    r_show.Show();
                }
            }
        }

        private void type_changed(object sender, EventArgs e)
        {
            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();

            string s = "select re_date from reports";
            SqlCommand cmd = mycon.CreateCommand();
            cmd.CommandText = s;
            SqlDataAdapter adt = new SqlDataAdapter();        //实例化数据适配器
            adt.SelectCommand = cmd;                          //让适配器执行SELECT命令
            DataTable re_dt = new DataTable();              //实例化结果数据集
            adt.Fill(re_dt);                              //将结果放入数据适配器，返回元祖个数

            if (type.SelectedItem.ToString() == "日")
            {
                date_choose.Items.Clear();
                foreach (DataRow row in re_dt.Rows)
                {
                    date_choose.Items.Add(row["re_date"]);
                }
            }
            else if (type.SelectedItem.ToString() == "月")
            {
                date_choose.Items.Clear();
                foreach (DataRow row in re_dt.Rows)
                {
                    string tmp = Convert.ToDateTime(row["re_date"].ToString()).ToString("yyyy-MM");
                    if (!date_choose.Items.Contains(tmp))
                    {
                        date_choose.Items.Add(tmp);
                    }
                }
            }
            else if (type.SelectedItem.ToString() == "年")
            {
                date_choose.Items.Clear();
                foreach (DataRow row in re_dt.Rows)
                {
                    string tmp = Convert.ToDateTime(row["re_date"].ToString()).ToString("yyyy");
                    if (!date_choose.Items.Contains(tmp))
                    {
                        date_choose.Items.Add(tmp);
                    }
                }
            }
            mycon.Close();             //关闭连接
            mycon.Dispose();           //释放对象
        }

        private void create_Click(object sender, EventArgs e)
        {
            //连接数据库
            //设置连接字符串
            string constr = "server=10.0.0.25,1433;database=RentSysData;User id=sa;password=passwordmima";
            SqlConnection mycon = new SqlConnection(constr);                  //实例化连接对象
            mycon.Open();

            string filePath = ShowSaveFileDialog();
            if (filePath == "")
            {
                return;
            }

            if (type.SelectedItem.ToString() == "日")
            {
                Console.WriteLine(date_choose.SelectedItem.ToString());
                string s = "select re_id, re_date, re_admin_id, re_admin, re_buildings, re_ave_empty from reports where re_date = '" + date_choose.SelectedItem.ToString() + "'";
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = s;
                SqlDataAdapter adt = new SqlDataAdapter();        //实例化数据适配器
                adt.SelectCommand = cmd;                          //让适配器执行SELECT命令
                DataTable re_dt = new DataTable();              //实例化结果数据集
                adt.Fill(re_dt);                              //将结果放入数据适配器，返回元祖个数

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets.Add("日报告");
                    sheet.Cells.Style.ShrinkToFit = true;

                    sheet.Cells[1, 1].Value = "建筑名称";
                    sheet.Cells[1, 2].Value = "房产证号";
                    sheet.Cells[1, 3].Value = "房产权属人";
                    sheet.Cells[1, 4].Value = "建筑面积/m^2";
                    sheet.Cells[1, 5].Value = "地址";
                    sheet.Cells[1, 6].Value = "空置率";
                    sheet.Cells[1, 7].Value = "租赁地址";
                    sheet.Cells[1, 8].Value = "承租人";
                    sheet.Cells[1, 9].Value = "出租面积/m^2";
                    sheet.Cells[1, 10].Value = "价格";
                    sheet.Cells[1, 11].Value = "欠租";
                    sheet.Cells[1, 12].Value = "押金";
                    sheet.Cells[1, 13].Value = "合同开始日期";
                    sheet.Cells[1, 14].Value = "合同结束日期";
                    sheet.Cells[1, 15].Value = "备注";

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(re_dt.Rows[0]["re_buildings"].ToString());
                    int i = 2;
                    int j = 0;
                    float t = 0;
                    foreach (XmlNode node in doc.SelectSingleNode("Buildings").SelectNodes("building"))
                    {
                        sheet.Cells[i, 1].Value = node.SelectSingleNode("b_name").InnerText;
                        sheet.Cells[i, 2].Value = node.SelectSingleNode("b_no").InnerText;
                        sheet.Cells[i, 3].Value = node.SelectSingleNode("b_owner").InnerText;
                        sheet.Cells[i, 4].Value = node.SelectSingleNode("b_area").InnerText;
                        sheet.Cells[i, 5].Value = node.SelectSingleNode("b_addr").InnerText;
                        sheet.Cells[i, 6].Value = node.SelectSingleNode("b_empty").InnerText;
                        j++;
                        t += float.Parse(node.SelectSingleNode("b_empty").InnerText);
                        foreach (XmlNode rent in node.SelectSingleNode("rents").SelectNodes("rent"))
                        {
                            sheet.Cells[i, 7].Value = rent.SelectSingleNode("r_addr").InnerText;
                            sheet.Cells[i, 8].Value = rent.SelectSingleNode("r_rent").InnerText;
                            sheet.Cells[i, 9].Value = rent.SelectSingleNode("r_area").InnerText;
                            sheet.Cells[i, 10].Value = rent.SelectSingleNode("r_price").InnerText;
                            sheet.Cells[i, 11].Value = rent.SelectSingleNode("r_owing").InnerText;
                            sheet.Cells[i, 12].Value = rent.SelectSingleNode("r_pledge").InnerText;
                            sheet.Cells[i, 13].Value = rent.SelectSingleNode("r_start").InnerText;
                            sheet.Cells[i, 14].Value = rent.SelectSingleNode("r_end").InnerText;
                            sheet.Cells[i, 15].Value = rent.SelectSingleNode("r_more").InnerText;
                            i++;
                        }
                    }
                    sheet.Cells[i, 6].Value = "平均空置率";
                    sheet.Cells[i, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));
                    sheet.Cells[i + 1, 6].Value = t/j;
                    sheet.Cells[i + 1, 6].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i + 1, 6].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));

                    sheet.Cells["A1:O1"].AutoFilter = true;

                    FileInfo fi = new FileInfo(filePath);
                    if (fi.Exists)
                    {
                        fi.Delete();
                        fi = new FileInfo(filePath);
                    }
                    package.SaveAs(fi);
                }
            }

            if (type.SelectedItem.ToString() == "月")
            {
                string s = "select re_id, re_date, re_admin_id, re_admin, re_buildings, re_ave_empty from reports where substring(re_date,1,7) = '" + date_choose.SelectedItem.ToString() + "'";
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = s;
                SqlDataAdapter adt = new SqlDataAdapter();        //实例化数据适配器
                adt.SelectCommand = cmd;                          //让适配器执行SELECT命令
                DataTable re_dt = new DataTable();              //实例化结果数据集
                adt.Fill(re_dt);                              //将结果放入数据适配器，返回元祖个数

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets.Add("月报告");
                    sheet.Cells.Style.ShrinkToFit = true;

                    sheet.Cells[1, 1].Value = "日期";
                    sheet.Cells[1, 2].Value = "建筑名称";
                    sheet.Cells[1, 3].Value = "房产证号";
                    sheet.Cells[1, 4].Value = "房产权属人";
                    sheet.Cells[1, 5].Value = "建筑面积/m^2";
                    sheet.Cells[1, 6].Value = "地址";
                    sheet.Cells[1, 7].Value = "空置率";
                    sheet.Cells[1, 8].Value = "平均空置率";

                    int i = 2;
                    foreach (DataRow row in re_dt.Rows)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(row["re_buildings"].ToString());
                        foreach (XmlNode node in doc.SelectSingleNode("Buildings").SelectNodes("building"))
                        {
                            sheet.Cells[i, 1].Value = row["re_date"].ToString();
                            sheet.Cells[i, 2].Value = node.SelectSingleNode("b_name").InnerText;
                            sheet.Cells[i, 3].Value = node.SelectSingleNode("b_no").InnerText;
                            sheet.Cells[i, 4].Value = node.SelectSingleNode("b_owner").InnerText;
                            sheet.Cells[i, 5].Value = node.SelectSingleNode("b_area").InnerText;
                            sheet.Cells[i, 6].Value = node.SelectSingleNode("b_addr").InnerText;
                            sheet.Cells[i, 7].Value = float.Parse(node.SelectSingleNode("b_empty").InnerText);
                            i++;
                        }
                    }
                    sheet.Cells[2, 1, i-1, 7].Sort(1);

                    string name = sheet.Cells["B2"].Value.ToString();
                    float empty = 0;
                    int j = 0;
                    for (int x=2; x < i; x+=1)
                    {
                        if (sheet.Cells[x, 2].Value.ToString() == name)
                        {
                            empty += float.Parse(sheet.Cells[x, 7].Value.ToString());
                            j++;
                        }
                        else
                        {
                            sheet.Cells[x-1, 8].Formula = "AVERAGE(G" + (x-j) + ":G" + (x-1) + ")";
                            name = sheet.Cells[x, 2].Value.ToString();
                            empty = float.Parse(sheet.Cells[x, 7].Value.ToString());
                            j = 1;
                        }
                    }

                    sheet.Cells[i, 7].Value = "总平均空置率";
                    sheet.Cells[i, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));
                    sheet.Cells[i+1, 7].Formula = "AVERAGE(G2:G" + (i - 1) + ")";
                    sheet.Cells[i+1, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i+1, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));

                    sheet.Cells["A1:H1"].AutoFilter = true;

                    FileInfo fi = new FileInfo(filePath);
                    if (fi.Exists)
                    {
                        fi.Delete();
                        fi = new FileInfo(filePath);
                    }
                    package.SaveAs(fi);
                }
            }

            if (type.SelectedItem.ToString() == "年")
            {
                Console.WriteLine(date_choose.SelectedItem.ToString());
                string s = "select re_id, re_date, re_admin_id, re_admin, re_buildings, re_ave_empty from reports where substring(re_date,1,4) = '" + date_choose.SelectedItem.ToString() + "'";
                SqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = s;
                SqlDataAdapter adt = new SqlDataAdapter();        //实例化数据适配器
                adt.SelectCommand = cmd;                          //让适配器执行SELECT命令
                DataTable re_dt = new DataTable();              //实例化结果数据集
                adt.Fill(re_dt);                              //将结果放入数据适配器，返回元祖个数

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets.Add("年报告");
                    sheet.Cells.Style.ShrinkToFit = true;

                    sheet.Cells[1, 1].Value = "日期";
                    sheet.Cells[1, 2].Value = "建筑名称";
                    sheet.Cells[1, 3].Value = "房产证号";
                    sheet.Cells[1, 4].Value = "房产权属人";
                    sheet.Cells[1, 5].Value = "建筑面积/m^2";
                    sheet.Cells[1, 6].Value = "地址";
                    sheet.Cells[1, 7].Value = "空置率";
                    sheet.Cells[1, 8].Value = "平均空置率";

                    int i = 2;
                    foreach (DataRow row in re_dt.Rows)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(row["re_buildings"].ToString());
                        foreach (XmlNode node in doc.SelectSingleNode("Buildings").SelectNodes("building"))
                        {
                            sheet.Cells[i, 1].Value = row["re_date"].ToString();
                            sheet.Cells[i, 2].Value = node.SelectSingleNode("b_name").InnerText;
                            sheet.Cells[i, 3].Value = node.SelectSingleNode("b_no").InnerText;
                            sheet.Cells[i, 4].Value = node.SelectSingleNode("b_owner").InnerText;
                            sheet.Cells[i, 5].Value = node.SelectSingleNode("b_area").InnerText;
                            sheet.Cells[i, 6].Value = node.SelectSingleNode("b_addr").InnerText;
                            sheet.Cells[i, 7].Value = float.Parse(node.SelectSingleNode("b_empty").InnerText);
                            i++;
                        }
                    }
                    sheet.Cells[2, 1, i - 1, 7].Sort(1);

                    string name = sheet.Cells["B2"].Value.ToString();
                    float empty = 0;
                    int j = 0;
                    for (int x = 2; x < i; x += 1)
                    {
                        if (sheet.Cells[x, 2].Value.ToString() == name)
                        {
                            empty += float.Parse(sheet.Cells[x, 7].Value.ToString());
                            j++;
                        }
                        else
                        {
                            sheet.Cells[x - 1, 8].Formula = "AVERAGE(G" + (x - j) + ":G" + (x - 1) + ")";
                            name = sheet.Cells[x, 2].Value.ToString();
                            empty = float.Parse(sheet.Cells[x, 7].Value.ToString());
                            j = 1;
                        }
                    }

                    sheet.Cells[i, 7].Value = "总平均空置率";
                    sheet.Cells[i, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));
                    sheet.Cells[i + 1, 7].Formula = "AVERAGE(G2:G" + (i - 1) + ")";
                    sheet.Cells[i + 1, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i + 1, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));

                    sheet.Cells["A1:H1"].AutoFilter = true;

                    sheet.Cells[i, 7].Value = "总平均空置率";
                    sheet.Cells[i, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));
                    sheet.Cells[i + 1, 7].Formula = "AVERAGE(G2:G" + (i - 1) + ")";
                    sheet.Cells[i + 1, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    sheet.Cells[i + 1, 7].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(200, 239, 167));

                    FileInfo fi = new FileInfo(filePath);
                    if (fi.Exists)
                    {
                        fi.Delete();
                        fi = new FileInfo(filePath);
                    }
                    package.SaveAs(fi);
                }
            }
        }

        private string ShowSaveFileDialog()
        {
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "Excel表格 （*.xlsx）|*.xlsx|Excel表格（*.xls）|*.xls";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                //给文件名前加上时间 
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                //在文件名里加字符 
                //saveFileDialog1.FileName.Insert(1,"dameng"); 

                //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 

                ////fs输出带文字或图片的文件，就看需求了 
            }

            return localFilePath;
        }
    }
}
