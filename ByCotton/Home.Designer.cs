﻿namespace ByCotton
{
    partial class Home
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
            this.listView = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 114);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1011, 547);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 46);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.homeButton);
            this.flowLayoutPanel2.Controls.Add(this.cartButton);
            this.flowLayoutPanel2.Controls.Add(this.profileButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(919, 46);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(103, 40);
            this.homeButton.TabIndex = 17;
            this.homeButton.Text = "SẢN PHẨM";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.Gray;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Location = new System.Drawing.Point(112, 3);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(126, 40);
            this.cartButton.TabIndex = 18;
            this.cartButton.Text = "GIỎ HÀNG";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Gray;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Location = new System.Drawing.Point(244, 3);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(126, 40);
            this.profileButton.TabIndex = 19;
            this.profileButton.Text = "TÀI KHOẢN";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.logoutButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(919, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(113, 46);
            this.flowLayoutPanel3.TabIndex = 21;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Gray;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(3, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(109, 40);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "ĐĂNG XUẤT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 682);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listView);
            this.Name = "Home";
            this.Text = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button profileButton;
    }
}