namespace RentSys
{
    partial class rent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.r_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_rent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_totalprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_owing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_pledge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_more = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.r_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_name = new System.Windows.Forms.Label();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.refresh = new System.Windows.Forms.Button();
            this.changeRent = new System.Windows.Forms.Button();
            this.deleteRent = new System.Windows.Forms.Button();
            this.addRent = new System.Windows.Forms.Button();
            this.b_id = new System.Windows.Forms.Label();
            this.r_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.r_addr,
            this.r_no,
            this.r_rent,
            this.r_area,
            this.r_price,
            this.r_totalprice,
            this.r_fee,
            this.r_owing,
            this.r_pledge,
            this.r_start,
            this.r_end,
            this.r_more,
            this.r_id});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1291, 728);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // r_addr
            // 
            this.r_addr.Text = "地址";
            this.r_addr.Width = 200;
            // 
            // r_rent
            // 
            this.r_rent.Text = "承租人";
            this.r_rent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_rent.Width = 200;
            // 
            // r_area
            // 
            this.r_area.Text = "面积/m^2";
            this.r_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_area.Width = 200;
            // 
            // r_price
            // 
            this.r_price.Text = "租金单价";
            this.r_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_price.Width = 200;
            // 
            // r_totalprice
            // 
            this.r_totalprice.Text = "租金";
            this.r_totalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_totalprice.Width = 200;
            // 
            // r_fee
            // 
            this.r_fee.Text = "管理费/元";
            this.r_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_fee.Width = 200;
            // 
            // r_owing
            // 
            this.r_owing.Text = "欠租/元";
            this.r_owing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_owing.Width = 200;
            // 
            // r_pledge
            // 
            this.r_pledge.Text = "押金/元";
            this.r_pledge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_pledge.Width = 200;
            // 
            // r_start
            // 
            this.r_start.Text = "合同开始日期";
            this.r_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_start.Width = 200;
            // 
            // r_end
            // 
            this.r_end.Text = "合同结束日期";
            this.r_end.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_end.Width = 200;
            // 
            // r_more
            // 
            this.r_more.Text = "备注";
            this.r_more.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_more.Width = 200;
            // 
            // r_id
            // 
            this.r_id.Text = "r_id";
            this.r_id.Width = 0;
            // 
            // b_name
            // 
            this.b_name.AutoSize = true;
            this.b_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_name.Location = new System.Drawing.Point(24, 46);
            this.b_name.Name = "b_name";
            this.b_name.Size = new System.Drawing.Size(169, 46);
            this.b_name.TabIndex = 1;
            this.b_name.Text = "b_name";
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Location = new System.Drawing.Point(39, 896);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(86, 29);
            this.cb_all.TabIndex = 14;
            this.cb_all.Text = "全选";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Orange;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refresh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.refresh.Location = new System.Drawing.Point(1200, 882);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(104, 55);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // changeRent
            // 
            this.changeRent.Location = new System.Drawing.Point(293, 882);
            this.changeRent.Name = "changeRent";
            this.changeRent.Size = new System.Drawing.Size(104, 55);
            this.changeRent.TabIndex = 12;
            this.changeRent.Text = "修改";
            this.changeRent.UseVisualStyleBackColor = true;
            this.changeRent.Click += new System.EventHandler(this.changeRent_Click);
            // 
            // deleteRent
            // 
            this.deleteRent.Location = new System.Drawing.Point(420, 882);
            this.deleteRent.Name = "deleteRent";
            this.deleteRent.Size = new System.Drawing.Size(104, 55);
            this.deleteRent.TabIndex = 11;
            this.deleteRent.Text = "删除";
            this.deleteRent.UseVisualStyleBackColor = true;
            this.deleteRent.Click += new System.EventHandler(this.deleteRent_Click);
            // 
            // addRent
            // 
            this.addRent.Location = new System.Drawing.Point(166, 882);
            this.addRent.Name = "addRent";
            this.addRent.Size = new System.Drawing.Size(104, 55);
            this.addRent.TabIndex = 10;
            this.addRent.Text = "添加";
            this.addRent.UseVisualStyleBackColor = true;
            this.addRent.Click += new System.EventHandler(this.addRent_Click);
            // 
            // b_id
            // 
            this.b_id.AutoSize = true;
            this.b_id.Location = new System.Drawing.Point(34, 92);
            this.b_id.Name = "b_id";
            this.b_id.Size = new System.Drawing.Size(53, 25);
            this.b_id.TabIndex = 16;
            this.b_id.Text = "b_id";
            this.b_id.Visible = false;
            // 
            // r_no
            // 
            this.r_no.Text = "房产证号";
            this.r_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.r_no.Width = 200;
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 1038);
            this.Controls.Add(this.b_id);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.changeRent);
            this.Controls.Add(this.deleteRent);
            this.Controls.Add(this.addRent);
            this.Controls.Add(this.b_name);
            this.Controls.Add(this.listView1);
            this.Name = "rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "租赁";
            this.Load += new System.EventHandler(this.rent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label b_name;
        private System.Windows.Forms.CheckBox cb_all;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button changeRent;
        private System.Windows.Forms.Button deleteRent;
        private System.Windows.Forms.Button addRent;
        private System.Windows.Forms.ColumnHeader r_addr;
        private System.Windows.Forms.ColumnHeader r_rent;
        private System.Windows.Forms.ColumnHeader r_area;
        private System.Windows.Forms.ColumnHeader r_price;
        private System.Windows.Forms.ColumnHeader r_totalprice;
        private System.Windows.Forms.ColumnHeader r_fee;
        private System.Windows.Forms.ColumnHeader r_owing;
        private System.Windows.Forms.ColumnHeader r_pledge;
        private System.Windows.Forms.ColumnHeader r_start;
        private System.Windows.Forms.ColumnHeader r_end;
        private System.Windows.Forms.ColumnHeader r_more;
        private System.Windows.Forms.Label b_id;
        private System.Windows.Forms.ColumnHeader r_id;
        private System.Windows.Forms.ColumnHeader r_no;
    }
}