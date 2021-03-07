namespace RentSys
{
    partial class add_rent
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
            this.label1 = new System.Windows.Forms.Label();
            this.r_addr = new System.Windows.Forms.TextBox();
            this.r_area = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.r_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.r_rent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.r_pledge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.r_owing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.r_fee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.r_more = new System.Windows.Forms.RichTextBox();
            this.r_end = new System.Windows.Forms.DateTimePicker();
            this.r_start = new System.Windows.Forms.DateTimePicker();
            this.addRent = new System.Windows.Forms.Button();
            this.startno = new System.Windows.Forms.CheckBox();
            this.endno = new System.Windows.Forms.CheckBox();
            this.must1 = new System.Windows.Forms.Label();
            this.must2 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.r_bid = new System.Windows.Forms.Label();
            this.b_addr = new System.Windows.Forms.Label();
            this.warning4 = new System.Windows.Forms.Label();
            this.noWarning = new System.Windows.Forms.Label();
            this.r_no = new System.Windows.Forms.TextBox();
            this.房产证 = new System.Windows.Forms.Label();
            this.must3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(170, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "*地址";
            // 
            // r_addr
            // 
            this.r_addr.Location = new System.Drawing.Point(328, 84);
            this.r_addr.Name = "r_addr";
            this.r_addr.Size = new System.Drawing.Size(314, 31);
            this.r_addr.TabIndex = 1;
            // 
            // r_area
            // 
            this.r_area.Location = new System.Drawing.Point(328, 134);
            this.r_area.Name = "r_area";
            this.r_area.Size = new System.Drawing.Size(314, 31);
            this.r_area.TabIndex = 3;
            this.r_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(170, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "*面积";
            // 
            // r_price
            // 
            this.r_price.Location = new System.Drawing.Point(328, 282);
            this.r_price.Name = "r_price";
            this.r_price.Size = new System.Drawing.Size(314, 31);
            this.r_price.TabIndex = 7;
            this.r_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "租金单价";
            // 
            // r_rent
            // 
            this.r_rent.Location = new System.Drawing.Point(328, 232);
            this.r_rent.Name = "r_rent";
            this.r_rent.Size = new System.Drawing.Size(314, 31);
            this.r_rent.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "承租人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "合同开始日期";
            // 
            // r_pledge
            // 
            this.r_pledge.Location = new System.Drawing.Point(328, 433);
            this.r_pledge.Name = "r_pledge";
            this.r_pledge.Size = new System.Drawing.Size(314, 31);
            this.r_pledge.TabIndex = 13;
            this.r_pledge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "押金";
            // 
            // r_owing
            // 
            this.r_owing.Location = new System.Drawing.Point(328, 383);
            this.r_owing.Name = "r_owing";
            this.r_owing.Size = new System.Drawing.Size(314, 31);
            this.r_owing.TabIndex = 11;
            this.r_owing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "欠租";
            // 
            // r_fee
            // 
            this.r_fee.Location = new System.Drawing.Point(328, 333);
            this.r_fee.Name = "r_fee";
            this.r_fee.Size = new System.Drawing.Size(314, 31);
            this.r_fee.TabIndex = 9;
            this.r_fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "管理费";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "合同结束日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 592);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "备注";
            // 
            // r_more
            // 
            this.r_more.Location = new System.Drawing.Point(328, 592);
            this.r_more.Name = "r_more";
            this.r_more.Size = new System.Drawing.Size(482, 236);
            this.r_more.TabIndex = 19;
            this.r_more.Text = "";
            // 
            // r_end
            // 
            this.r_end.Location = new System.Drawing.Point(328, 533);
            this.r_end.Name = "r_end";
            this.r_end.Size = new System.Drawing.Size(391, 31);
            this.r_end.TabIndex = 20;
            // 
            // r_start
            // 
            this.r_start.Location = new System.Drawing.Point(328, 485);
            this.r_start.Name = "r_start";
            this.r_start.Size = new System.Drawing.Size(391, 31);
            this.r_start.TabIndex = 21;
            // 
            // addRent
            // 
            this.addRent.Location = new System.Drawing.Point(61, 771);
            this.addRent.Name = "addRent";
            this.addRent.Size = new System.Drawing.Size(94, 57);
            this.addRent.TabIndex = 22;
            this.addRent.Text = "添加";
            this.addRent.UseVisualStyleBackColor = true;
            this.addRent.Click += new System.EventHandler(this.addRent_Click);
            // 
            // startno
            // 
            this.startno.AutoSize = true;
            this.startno.Location = new System.Drawing.Point(735, 489);
            this.startno.Name = "startno";
            this.startno.Size = new System.Drawing.Size(65, 29);
            this.startno.TabIndex = 23;
            this.startno.Text = "无";
            this.startno.UseVisualStyleBackColor = true;
            // 
            // endno
            // 
            this.endno.AutoSize = true;
            this.endno.Location = new System.Drawing.Point(735, 535);
            this.endno.Name = "endno";
            this.endno.Size = new System.Drawing.Size(65, 29);
            this.endno.TabIndex = 24;
            this.endno.Text = "无";
            this.endno.UseVisualStyleBackColor = true;
            // 
            // must1
            // 
            this.must1.AutoSize = true;
            this.must1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.must1.Location = new System.Drawing.Point(101, 43);
            this.must1.Name = "must1";
            this.must1.Size = new System.Drawing.Size(54, 25);
            this.must1.TabIndex = 25;
            this.must1.Text = "必填";
            // 
            // must2
            // 
            this.must2.AutoSize = true;
            this.must2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.must2.Location = new System.Drawing.Point(101, 137);
            this.must2.Name = "must2";
            this.must2.Size = new System.Drawing.Size(54, 25);
            this.must2.TabIndex = 26;
            this.must2.Text = "必填";
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(671, 88);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(108, 25);
            this.warning1.TabIndex = 27;
            this.warning1.Text = "长度>100";
            this.warning1.Visible = false;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(671, 238);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(95, 25);
            this.warning2.TabIndex = 29;
            this.warning2.Text = "长度>50";
            this.warning2.Visible = false;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(323, 840);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(108, 25);
            this.warning3.TabIndex = 34;
            this.warning3.Text = "长度>300";
            this.warning3.Visible = false;
            // 
            // r_bid
            // 
            this.r_bid.AutoSize = true;
            this.r_bid.Location = new System.Drawing.Point(56, 730);
            this.r_bid.Name = "r_bid";
            this.r_bid.Size = new System.Drawing.Size(60, 25);
            this.r_bid.TabIndex = 35;
            this.r_bid.Text = "r_bid";
            this.r_bid.Visible = false;
            // 
            // b_addr
            // 
            this.b_addr.AutoSize = true;
            this.b_addr.Location = new System.Drawing.Point(328, 42);
            this.b_addr.Name = "b_addr";
            this.b_addr.Size = new System.Drawing.Size(79, 25);
            this.b_addr.TabIndex = 36;
            this.b_addr.Text = "b_addr";
            // 
            // warning4
            // 
            this.warning4.AutoSize = true;
            this.warning4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning4.ForeColor = System.Drawing.Color.Red;
            this.warning4.Location = new System.Drawing.Point(56, 840);
            this.warning4.Name = "warning4";
            this.warning4.Size = new System.Drawing.Size(144, 25);
            this.warning4.TabIndex = 37;
            this.warning4.Text = "新出租已存在";
            this.warning4.Visible = false;
            // 
            // noWarning
            // 
            this.noWarning.AutoSize = true;
            this.noWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noWarning.ForeColor = System.Drawing.Color.Red;
            this.noWarning.Location = new System.Drawing.Point(671, 186);
            this.noWarning.Name = "noWarning";
            this.noWarning.Size = new System.Drawing.Size(139, 25);
            this.noWarning.TabIndex = 40;
            this.noWarning.Text = "证号长度>50";
            this.noWarning.Visible = false;
            // 
            // r_no
            // 
            this.r_no.Location = new System.Drawing.Point(328, 183);
            this.r_no.Name = "r_no";
            this.r_no.Size = new System.Drawing.Size(314, 31);
            this.r_no.TabIndex = 39;
            // 
            // 房产证
            // 
            this.房产证.AutoSize = true;
            this.房产证.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.房产证.Location = new System.Drawing.Point(170, 186);
            this.房产证.Name = "房产证";
            this.房产证.Size = new System.Drawing.Size(109, 25);
            this.房产证.TabIndex = 38;
            this.房产证.Text = "*房产证号";
            // 
            // must3
            // 
            this.must3.AutoSize = true;
            this.must3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.must3.Location = new System.Drawing.Point(101, 186);
            this.must3.Name = "must3";
            this.must3.Size = new System.Drawing.Size(54, 25);
            this.must3.TabIndex = 41;
            this.must3.Text = "必填";
            // 
            // add_rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 921);
            this.Controls.Add(this.must3);
            this.Controls.Add(this.noWarning);
            this.Controls.Add(this.r_no);
            this.Controls.Add(this.房产证);
            this.Controls.Add(this.warning4);
            this.Controls.Add(this.b_addr);
            this.Controls.Add(this.r_bid);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.warning1);
            this.Controls.Add(this.must2);
            this.Controls.Add(this.must1);
            this.Controls.Add(this.endno);
            this.Controls.Add(this.startno);
            this.Controls.Add(this.addRent);
            this.Controls.Add(this.r_start);
            this.Controls.Add(this.r_end);
            this.Controls.Add(this.r_more);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.r_pledge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.r_owing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.r_fee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.r_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.r_rent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.r_area);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.r_addr);
            this.Controls.Add(this.label1);
            this.Name = "add_rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加租赁";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r_addr;
        private System.Windows.Forms.TextBox r_area;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox r_rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox r_pledge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox r_owing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox r_fee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox r_more;
        private System.Windows.Forms.DateTimePicker r_end;
        private System.Windows.Forms.DateTimePicker r_start;
        private System.Windows.Forms.Button addRent;
        private System.Windows.Forms.CheckBox startno;
        private System.Windows.Forms.CheckBox endno;
        private System.Windows.Forms.Label must1;
        private System.Windows.Forms.Label must2;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label r_bid;
        private System.Windows.Forms.Label b_addr;
        private System.Windows.Forms.Label warning4;
        private System.Windows.Forms.Label noWarning;
        private System.Windows.Forms.TextBox r_no;
        private System.Windows.Forms.Label 房产证;
        private System.Windows.Forms.Label must3;
    }
}