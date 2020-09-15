namespace RentSys
{
    partial class register
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pswdCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.warning4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(354, 57);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(190, 31);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(354, 179);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(190, 31);
            this.password.TabIndex = 1;
            // 
            // pswdCheck
            // 
            this.pswdCheck.Location = new System.Drawing.Point(354, 239);
            this.pswdCheck.Name = "pswdCheck";
            this.pswdCheck.PasswordChar = '*';
            this.pswdCheck.Size = new System.Drawing.Size(190, 31);
            this.pswdCheck.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(286, 343);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(83, 70);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(421, 343);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 70);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "邮箱";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(354, 115);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 31);
            this.email.TabIndex = 8;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(567, 243);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(122, 25);
            this.warning2.TabIndex = 10;
            this.warning2.Text = "密码不一致";
            this.warning2.Visible = false;
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(567, 121);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(144, 25);
            this.warning1.TabIndex = 11;
            this.warning1.Text = "邮箱格式错误";
            this.warning1.Visible = false;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(335, 298);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(122, 25);
            this.warning3.TabIndex = 12;
            this.warning3.Text = "填写不完整";
            this.warning3.Visible = false;
            // 
            // warning4
            // 
            this.warning4.AutoSize = true;
            this.warning4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning4.ForeColor = System.Drawing.Color.Red;
            this.warning4.Location = new System.Drawing.Point(567, 62);
            this.warning4.Name = "warning4";
            this.warning4.Size = new System.Drawing.Size(122, 25);
            this.warning4.TabIndex = 13;
            this.warning4.Text = "用户名存在";
            this.warning4.Visible = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning4);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.warning1);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pswdCheck);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox pswdCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label warning4;
    }
}