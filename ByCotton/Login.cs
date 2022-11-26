﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ByCotton
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!");
                return;
            }

            if (username.Equals("admin"))
            {
                if (password.Equals("123456"))
                {
                    Account admin = new Account();
                    admin.username = "admin";

                    Global.account = admin;

                    (new Warehouse()).Show();
                    this.Hide();
                }
                return;
            }

            if (username.Equals("direct"))
            {
                if (password.Equals("123456"))
                {
                    Account admin = new Account();
                    admin.username = "direct";

                    Global.account = admin;

                    (new Warehouse()).Show();
                    this.Hide();
                }
                return;
            }

            string query = 
                "SELECT * " +
                "FROM Account " +
                "WHERE username = @username";

            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-5HLVG267;Initial Catalog=BY_COTTON;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cn.Open();
            SqlDataReader r = cmd.ExecuteReader();

            if ( !r.Read() )
            {
                MessageBox.Show("TÀI KHOẢN hoặc MẬT KHẨU KHÔNG CHÍNH XÁC");
                return;
            }

            if (!password.Equals(r.GetString(1)))
            {
                MessageBox.Show("TÀI KHOẢN hoặc MẬT KHẨU KHÔNG CHÍNH XÁC");
                return;
            }

            Account account = new Account();
            account.username = r.GetString(0);
            account.name = r.GetString(2);
            account.email = r.GetString(3);
            account.gender = r.GetBoolean(4);
            account.address = r.GetString(5);

            Global.account = account;

            r.Close();
            cn.Close();

            (new Home()).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Register()).Show();
            this.Hide();
        }
    }
}