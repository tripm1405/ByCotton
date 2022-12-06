using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByCotton
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void regíterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string rePassword = rePasswordTextBox.Text;
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            Nullable<bool> gender = null;
            foreach (RadioButton rdo in genderGroupBox.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    gender = rdo.Text.Equals("NAM");
                    break;
                }
            }
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;

            if (username.Equals("") || 
                password.Equals("") || 
                rePassword.Equals("") || 
                name.Equals("") || 
                email.Equals("") || 
                gender == null || 
                address.Equals("") ||
                phone.Equals(""))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }

            if (!rePassword.Equals(password))
            {
                MessageBox.Show("NHẬP LẠI MẬT KHẨU không chính xác!");
                return;
            }

            if (username.Equals("manager") || username.Equals("employee"))
            {
                MessageBox.Show("Hãy sử dụng TÀI KHOẢN khác!");
                return;
            }

            string query;

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            query =
                "SELECT * " +
                "FROM Account " +
                "WHERE username = @username";

            SqlCommand cmd = null;
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Hãy sử dụng TÀI KHOẢN khác!");
                return;
            }
            r.Close();

            query =
                "INSERT INTO Account(username, password, name, email, gender, address, create_at) VALUES " +
                "(@username, @password, @name, @email, @gender, @address, @date)";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
            cmd.ExecuteReader().Close();

            query =
                "INSERT INTO Customer(account, phone) VALUES " +
                "(@username, @phone)";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.ExecuteReader().Close();

            cn.Close();

            MessageBox.Show("ĐĂNG KÍ thành công!");

            (new Login()).Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            (new Login()).Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            rePasswordTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            genderGroupBox.Controls.OfType<RadioButton>().ToList().ForEach(r => r.Checked = false);
            addressTextBox.Text = "";
            phoneTextBox.Text = "";
        }
    }
}
