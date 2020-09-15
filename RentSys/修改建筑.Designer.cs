namespace RentSys
{
    partial class 修改建筑
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
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_name = new System.Windows.Forms.TextBox();
            this.add_no = new System.Windows.Forms.TextBox();
            this.add_owner = new System.Windows.Forms.TextBox();
            this.add_area = new System.Windows.Forms.TextBox();
            this.add_addr = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.warning4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.b_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(28, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(184, 46);
            this.name.TabIndex = 0;
            this.name.Text = "建筑名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "新名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "新房产证号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "新房产权属人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "新面积";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "新地址";
            // 
            // add_name
            // 
            this.add_name.Location = new System.Drawing.Point(231, 139);
            this.add_name.Name = "add_name";
            this.add_name.Size = new System.Drawing.Size(312, 31);
            this.add_name.TabIndex = 6;
            // 
            // add_no
            // 
            this.add_no.Location = new System.Drawing.Point(231, 194);
            this.add_no.Name = "add_no";
            this.add_no.Size = new System.Drawing.Size(312, 31);
            this.add_no.TabIndex = 7;
            // 
            // add_owner
            // 
            this.add_owner.Location = new System.Drawing.Point(231, 249);
            this.add_owner.Name = "add_owner";
            this.add_owner.Size = new System.Drawing.Size(312, 31);
            this.add_owner.TabIndex = 8;
            // 
            // add_area
            // 
            this.add_area.Location = new System.Drawing.Point(231, 306);
            this.add_area.Name = "add_area";
            this.add_area.Size = new System.Drawing.Size(312, 31);
            this.add_area.TabIndex = 9;
            this.add_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_area_KeyPress);
            // 
            // add_addr
            // 
            this.add_addr.Location = new System.Drawing.Point(231, 363);
            this.add_addr.Name = "add_addr";
            this.add_addr.Size = new System.Drawing.Size(312, 31);
            this.add_addr.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(340, 428);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 50);
            this.submit.TabIndex = 11;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(558, 141);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(152, 25);
            this.warning1.TabIndex = 12;
            this.warning1.Text = "名称长度>100";
            this.warning1.Visible = false;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(558, 200);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(139, 25);
            this.warning2.TabIndex = 13;
            this.warning2.Text = "证号长度>50";
            this.warning2.Visible = false;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(558, 254);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(205, 25);
            this.warning3.TabIndex = 14;
            this.warning3.Text = "房产权属人长度>50";
            this.warning3.Visible = false;
            // 
            // warning4
            // 
            this.warning4.AutoSize = true;
            this.warning4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning4.ForeColor = System.Drawing.Color.Red;
            this.warning4.Location = new System.Drawing.Point(558, 366);
            this.warning4.Name = "warning4";
            this.warning4.Size = new System.Drawing.Size(152, 25);
            this.warning4.TabIndex = 15;
            this.warning4.Text = "地址长度>100";
            this.warning4.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(557, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 16;
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(31, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(348, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "填写需要修改项目，无需修改则留空";
            // 
            // b_no
            // 
            this.b_no.AutoSize = true;
            this.b_no.Location = new System.Drawing.Point(14, 458);
            this.b_no.Name = "b_no";
            this.b_no.Size = new System.Drawing.Size(60, 25);
            this.b_no.TabIndex = 18;
            this.b_no.Text = "b_no";
            this.b_no.Visible = false;
            // 
            // 修改建筑
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.b_no);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.warning4);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.warning1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.add_addr);
            this.Controls.Add(this.add_area);
            this.Controls.Add(this.add_owner);
            this.Controls.Add(this.add_no);
            this.Controls.Add(this.add_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "修改建筑";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改建筑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_name;
        private System.Windows.Forms.TextBox add_no;
        private System.Windows.Forms.TextBox add_owner;
        private System.Windows.Forms.TextBox add_area;
        private System.Windows.Forms.TextBox add_addr;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label warning4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label b_no;
    }
}