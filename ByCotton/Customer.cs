using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByCotton
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
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
    }
}
