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
    public partial class InvoiceDetailCus : Form
    {
        public InvoiceDetailCus()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            (new Home()).Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            (new Cart()).Show(); 
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            (new Profile()).Show();
            this.Hide();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new invoiceHistoryCus()).Show();
            this.Hide();
        }

        private void InvoiceDetailCus_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query =
                "SELECT invoice, amount, price, (amount * price) AS total " +
                "FROM InvoiceDetail " +
                "WHERE invoice = @invoice ";

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@invoice", Global.invoiceID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "InvoiceDetail");
            dataGridView.DataSource = ds.Tables["InvoiceDetail"].DefaultView;

            cn.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }
    }
}
