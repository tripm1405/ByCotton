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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            (new Home()).Show(); 
            this.Hide();
        }

        private void prodileButton_Click(object sender, EventArgs e)
        {
            (new Profile()).Show();
            this.Hide();
        }
    }
}
