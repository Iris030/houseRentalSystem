﻿namespace RentSys
{
    partial class change_email
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
            this.newemail = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "新邮箱";
            // 
            // newemail
            // 
            this.newemail.Location = new System.Drawing.Point(289, 141);
            this.newemail.Name = "newemail";
            this.newemail.Size = new System.Drawing.Size(272, 31);
            this.newemail.TabIndex = 1;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(333, 259);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(107, 59);
            this.change.TabIndex = 2;
            this.change.Text = "提交";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(329, 195);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(122, 25);
            this.warning.TabIndex = 3;
            this.warning.Text = "请填写邮箱";
            this.warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warning.Visible = false;
            // 
            // change_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.change);
            this.Controls.Add(this.newemail);
            this.Controls.Add(this.label1);
            this.Name = "change_email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改邮箱";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newemail;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Label warning;
    }
}