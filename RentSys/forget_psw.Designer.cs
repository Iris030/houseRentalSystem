namespace RentSys
{
    partial class forget_psw
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
            this.lable2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(152, 87);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(75, 25);
            this.lable2.TabIndex = 0;
            this.lable2.Text = "用户名";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(243, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(246, 31);
            this.name.TabIndex = 1;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(293, 244);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(98, 51);
            this.check.TabIndex = 2;
            this.check.Text = "登录";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(256, 203);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(188, 25);
            this.warning.TabIndex = 3;
            this.warning.Text = "用户名或邮箱错误";
            this.warning.Visible = false;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(243, 140);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(246, 31);
            this.email.TabIndex = 5;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(152, 143);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(54, 25);
            this.lable1.TabIndex = 4;
            this.lable1.Text = "邮箱";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Location = new System.Drawing.Point(274, 309);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(138, 25);
            this.back.TabIndex = 6;
            this.back.TabStop = true;
            this.back.Text = "返回密码登录";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // forget_psw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 382);
            this.Controls.Add(this.back);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.check);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lable2);
            this.Name = "forget_psw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "忘记密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.LinkLabel back;
    }
}