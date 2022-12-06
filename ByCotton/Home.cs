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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ByCotton
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            loadData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void loadData()
        {
            string query = "SELECT code, name, image FROM Product";

            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-5HLVG267;Initial Catalog=BY_COTTON;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader r = cmd.ExecuteReader();

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(200, 200);
            listView.LargeImageList = imageList;
            while (r.Read())
            {
                //MessageBox.Show(
                //    r.GetInt32(0).ToString() + "\n" +
                //    r.GetString(1) + "\n" +
                //    r.GetString(2));
                imageList.Images.Add(r.GetInt32(0).ToString(), Image.FromFile(Global.IMAGE_PATH + r.GetString(2)));

                ListViewItem listViewItem0 = listView.Items.Add(new ListViewItem(r.GetString(1)));
                listViewItem0.ImageKey = r.GetInt32(0).ToString();
            }

            r.Close();
            cn.Close();
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
    }
}
