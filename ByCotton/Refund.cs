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
    public partial class Refund : Form
    {
        public Refund()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            string query =
                "SELECT I.invoice, P.name, R.* " +
                "FROM Refund R " +
                "JOIN InvoiceDetail I ON I.refund = R.code " +
                "JOIN Product P ON P.code = I.product";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Refund");
            dataGridView.DataSource = ds.Tables["Refund"].DefaultView;

            cn.Close();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new Invoice()).Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new Customer()).Show();
            this.Hide();
        }

        private void invoiceHistoryButton_Click(object sender, EventArgs e)
        {
            (new InvoiceHistory()).Show();
            this.Hide();
        }

        private void Refund_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
