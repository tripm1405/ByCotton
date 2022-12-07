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
    public partial class RefundManager : Form
    {
        public RefundManager()
        {
            InitializeComponent();
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            (new Warehouse()).Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new Customer()).Show();
            this.Hide();
        }

        private void turnoverButton_Click(object sender, EventArgs e)
        {
            (new Turnover()).Show(); 
            this.Hide();
        }
    }
}
