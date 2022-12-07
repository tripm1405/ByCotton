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
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void warehouseButton_Click(object sender, EventArgs e)
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
    }
}
