namespace RentSys
{
    partial class 添加建筑
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
            this.名称 = new System.Windows.Forms.Label();
            this.b_name = new System.Windows.Forms.TextBox();
            this.b_owner = new System.Windows.Forms.TextBox();
            this.权属人 = new System.Windows.Forms.Label();
            this.b_area = new System.Windows.Forms.TextBox();
            this.面积 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.b_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.warning4 = new System.Windows.Forms.Label();
            this.warning5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 名称
            // 
            this.名称.AutoSize = true;
            this.名称.Location = new System.Drawing.Point(233, 79);
            this.名称.Name = "名称";
            this.名称.Size = new System.Drawing.Size(96, 25);
            this.名称.TabIndex = 0;
            this.名称.Text = "建筑名称";
            // 
            // b_name
            // 
            this.b_name.Location = new System.Drawing.Point(370, 76);
            this.b_name.Name = "b_name";
            this.b_name.Size = new System.Drawing.Size(188, 31);
            this.b_name.TabIndex = 1;
            // 
            // b_owner
            // 
            this.b_owner.Location = new System.Drawing.Point(370, 140);
            this.b_owner.Name = "b_owner";
            this.b_owner.Size = new System.Drawing.Size(188, 31);
            this.b_owner.TabIndex = 5;
            // 
            // 权属人
            // 
            this.权属人.AutoSize = true;
            this.权属人.Location = new System.Drawing.Point(233, 143);
            this.权属人.Name = "权属人";
            this.权属人.Size = new System.Drawing.Size(117, 25);
            this.权属人.TabIndex = 4;
            this.权属人.Text = "房产权属人";
            // 
            // b_area
            // 
            this.b_area.Location = new System.Drawing.Point(370, 203);
            this.b_area.Name = "b_area";
            this.b_area.Size = new System.Drawing.Size(188, 31);
            this.b_area.TabIndex = 7;
            this.b_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.b_area_KeyPress);
            // 
            // 面积
            // 
            this.面积.AutoSize = true;
            this.面积.Location = new System.Drawing.Point(233, 206);
            this.面积.Name = "面积";
            this.面积.Size = new System.Drawing.Size(96, 25);
            this.面积.TabIndex = 6;
            this.面积.Text = "建筑面积";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(350, 371);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(88, 41);
            this.add.TabIndex = 8;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // b_addr
            // 
            this.b_addr.Location = new System.Drawing.Point(370, 263);
            this.b_addr.Name = "b_addr";
            this.b_addr.Size = new System.Drawing.Size(188, 31);
            this.b_addr.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "地址";
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(575, 79);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(152, 25);
            this.warning1.TabIndex = 12;
            this.warning1.Text = "名称长度>100";
            this.warning1.Visible = false;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(575, 143);
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
            this.warning4.Location = new System.Drawing.Point(575, 266);
            this.warning4.Name = "warning4";
            this.warning4.Size = new System.Drawing.Size(152, 25);
            this.warning4.TabIndex = 15;
            this.warning4.Text = "地址长度>100";
            this.warning4.Visible = false;
            // 
            // warning5
            // 
            this.warning5.AutoSize = true;
            this.warning5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning5.ForeColor = System.Drawing.Color.Red;
            this.warning5.Location = new System.Drawing.Point(575, 379);
            this.warning5.Name = "warning5";
            this.warning5.Size = new System.Drawing.Size(122, 25);
            this.warning5.TabIndex = 16;
            this.warning5.Text = "请填写完整";
            this.warning5.Visible = false;
            // 
            // 添加建筑
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning5);
            this.Controls.Add(this.warning4);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.warning1);
            this.Controls.Add(this.b_addr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.b_area);
            this.Controls.Add(this.面积);
            this.Controls.Add(this.b_owner);
            this.Controls.Add(this.权属人);
            this.Controls.Add(this.b_name);
            this.Controls.Add(this.名称);
            this.Name = "添加建筑";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加建筑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 名称;
        private System.Windows.Forms.TextBox b_name;
        private System.Windows.Forms.TextBox b_owner;
        private System.Windows.Forms.Label 权属人;
        private System.Windows.Forms.TextBox b_area;
        private System.Windows.Forms.Label 面积;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox b_addr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label warning4;
        private System.Windows.Forms.Label warning5;
    }
}