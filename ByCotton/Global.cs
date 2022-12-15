using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByCotton
{
    class Account
    {
        public string username;
        public string name;
        public string email;
        public Nullable<bool> gender;
        public string address;
        public string phone;

        public Account()
        {
            this.username = null;
            this.name = null;
            this.email = null;
            this.gender = null;
            this.address = null;
            this.phone = null;
        }
    }

    class Product
    {
        public string name;
        public int amount;
        public string image;
        public int price;
    }

    static class Global
    {
        public static string IMAGE_PATH = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\public\\images\\";
        public static string DATABASE = "Data Source=LAPTOP-5HLVG267;Initial Catalog=BY_COTTON;Integrated Security=True";

        public static Account account = null;
        public static Dictionary<string, Product> cart = new Dictionary<string, Product>();

        public static int invoiceID;
    }
}
