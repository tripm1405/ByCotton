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

namespace ByCotton
{
    public partial class InvoiceHistory : Form
    {
        public InvoiceHistory()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string INVOICE_DETAIL =
                "SELECT invoice, SUM(amount*price) AS price " +
                "FROM InvoiceDetail " + 
                "GROUP BY invoice";

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            string query =
                "SELECT I.*, ID.price " +
                "FROM Invoice I " +
                "JOIN ( " +
                    INVOICE_DETAIL +
                ") ID ON ID.invoice = I.code";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Account");
            dataGridView.DataSource = ds.Tables["Account"].DefaultView;

            cn.Close();
        }

        private void InvoiceHistory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new Invoice()).Show();
            this.Hide();
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            (new Refund()).Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new Customer()).Show();
            this.Hide();
        }
    }
}