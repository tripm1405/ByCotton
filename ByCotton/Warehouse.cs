using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace ByCotton
{
    public partial class Warehouse : Form
    {
        public static int editCode;

        public Warehouse ()
        {
            InitializeComponent();
            editCode = -1;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void Warehouse_Shown(object sender, EventArgs e)
        {
            if (Global.account == null)
            {
                (new Login()).Show();
                this.Hide();
            }
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void doneProductButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            decimal amount = amountNumericUpDown.Value;
            decimal price = priceNumericUpDown.Value;

            if (name.Equals(""))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!");
                return;
            }


            SqlConnection cn = new SqlConnection(Global.DATABASE);
            SqlCommand cmd;
            if (editCode != -1)
            {
                string query =
                    "UPDATE Product " +
                    "SET name = @name, amount = @amount, price = @price " +
                    "WHERE code = @code";
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@code", editCode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteReader().Close();
                cn.Close();

                editCode = -1;
                clearProductButton.Text = "ĐẶT LẠI";
                doneProductButton.Text = "THÊM";
            }
            else
            {
                string query =
                    "INSERT INTO Product VALUES " +
                    "(@name, @amount, @price)";
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteReader().Close();
                cn.Close();
            }

            loadData();

            nameTextBox.Text = "";
            amountNumericUpDown.Value = 0;
            priceNumericUpDown.Value = 0;
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            int code = int.Parse(productsDataGridView.CurrentRow.Cells[0].Value.ToString());

            if (code == editCode)
            {
                MessageBox.Show("Hãy hủy chỉnh sửa trước khi xóa!");
                return;
            }

            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            string query1 =
                "SELECT * FROM InvoiceDetail " +
                "WHERE product = @product";
            cmd = new SqlCommand(query1, cn);
            cmd.Parameters.AddWithValue("@product", code);
            SqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Sản phẩm đã được sử dụng trong hóa đơn!");
                return;
            }
            r.Close();

            string query2 =
                "DELETE FROM Product " +
                "WHERE code = @code";
            cmd = new SqlCommand(query2, cn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.ExecuteReader().Close();

            cn.Close();

            loadData();
        }

        private void loadData()
        {
            string query = "SELECT code, name, amount, price FROM Product";
            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            productsDataGridView.DataSource = ds.Tables["Product"].DefaultView;
            cn.Close();
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            if (editCode != -1)
            {
                clearProductButton.Text = "ĐẶT LẠI";
                doneProductButton.Text = "THÊM";
            }
            nameTextBox.Text = "";
            amountNumericUpDown.Value = 0;
            priceNumericUpDown.Value = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editCode = int.Parse(productsDataGridView.CurrentRow.Cells[0].Value.ToString());
            nameTextBox.Text = productsDataGridView.CurrentRow.Cells[1].Value.ToString();
            amountNumericUpDown.Value = int.Parse(productsDataGridView.CurrentRow.Cells[2].Value.ToString());
            priceNumericUpDown.Value = int.Parse(productsDataGridView.CurrentRow.Cells[3].Value.ToString());

            clearProductButton.Text = "HỦY";
            doneProductButton.Text = "SỬA";
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new CustomerManager()).Show();
            this.Hide();
        }

        private void turnoverButton_Click(object sender, EventArgs e)
        {
            (new Turnover()).Show();
            this.Hide();
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            (new RefundManager()).Show();
            this.Hide();
        }

        private void invoiceHítoryButton_Click(object sender, EventArgs e)
        {
            (new InvoiceHistoryManger()).Show();
            this.Hide();
        }
    }
}
