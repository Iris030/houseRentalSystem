namespace RentSys
{
    partial class show_report
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
            this.b_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b_empty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avr_empty = new System.Windows.Forms.Label();
            this.reid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.b_name,
            this.b_owner,
            this.b_area,
            this.b_addr,
            this.b_empty});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1699, 1002);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // b_name
            // 
            this.b_name.Text = "名称";
            this.b_name.Width = 200;
            // 
            // b_owner
            // 
            this.b_owner.Text = "房产权属人";
            this.b_owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_owner.Width = 300;
            // 
            // b_area
            // 
            this.b_area.Text = "面积";
            this.b_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_area.Width = 200;
            // 
            // b_addr
            // 
            this.b_addr.Text = "地址";
            this.b_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_addr.Width = 200;
            // 
            // b_empty
            // 
            this.b_empty.Text = "空置率";
            this.b_empty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.b_empty.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期：";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dd.Location = new System.Drawing.Point(133, 27);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(260, 44);
            this.dd.TabIndex = 2;
            this.dd.Text = "YYYY-MM-DD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(598, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "登记人：";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.admin.Location = new System.Drawing.Point(765, 27);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(125, 44);
            this.admin.TabIndex = 4;
            this.admin.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1122, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "平均空置率：";
            // 
            // avr_empty
            // 
            this.avr_empty.AutoSize = true;
            this.avr_empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.avr_empty.Location = new System.Drawing.Point(1348, 27);
            this.avr_empty.Name = "avr_empty";
            this.avr_empty.Size = new System.Drawing.Size(208, 44);
            this.avr_empty.TabIndex = 6;
            this.avr_empty.Text = "avr_empty";
            // 
            // reid
            // 
            this.reid.AutoSize = true;
            this.reid.Location = new System.Drawing.Point(21, 70);
            this.reid.Name = "reid";
            this.reid.Size = new System.Drawing.Size(29, 25);
            this.reid.TabIndex = 7;
            this.reid.Text = "id";
            this.reid.Visible = false;
            // 
            // show_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 1115);
            this.Controls.Add(this.reid);
            this.Controls.Add(this.avr_empty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "show_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报告";
            this.Load += new System.EventHandler(this.show_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avr_empty;
        private System.Windows.Forms.ColumnHeader b_name;
        private System.Windows.Forms.ColumnHeader b_owner;
        private System.Windows.Forms.ColumnHeader b_area;
        private System.Windows.Forms.ColumnHeader b_addr;
        private System.Windows.Forms.ColumnHeader b_empty;
        private System.Windows.Forms.Label reid;
    }
}