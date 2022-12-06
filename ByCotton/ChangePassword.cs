﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ByCotton
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string rePassword = rePasswordTextBox.Text;

            if (oldPassword.Equals("") || newPassword.Equals(""))
            {
                MessageBox.Show("HÃY NHẬP ĐẦY ĐỦ THÔNG TIN!");
                return;
            }

            if ( !newPassword.Equals(rePassword) )
            {
                MessageBox.Show("MẬT KHẨU NHẬP LẠI KHÔNG KHỚP!");
                MessageBox.Show(newPassword + "\n" + rePassword);
                return;
            }

            string query;
            SqlCommand cmd;

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            query =
                "SELECT * " +
                "FROM Account " +
                "WHERE username = @username " +
                "AND password = @oldPassword";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", Global.account.username);
            cmd.Parameters.AddWithValue("@oldPassword", oldPassword);
            SqlDataReader r = cmd.ExecuteReader();

            if (!r.Read())
            {
                MessageBox.Show("MẬT KHẨU CŨ KHÔNG CHÍNH XÁC");
                return;
            }
            r.Close();

            query =
                "UPDATE Account " +
                "SET password = @newPassword " +
                "WHERE username = @username";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@newPassword", newPassword);
            cmd.Parameters.AddWithValue("@username", Global.account.username);
            cmd.ExecuteReader().Close(); ;

            cn.Close();

            MessageBox.Show("ĐỔI MẬT KHẨU THÀNH CÔNG!");

            this.Hide();
        }
    }
}
