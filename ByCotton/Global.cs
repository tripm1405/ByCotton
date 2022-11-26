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

        public Account()
        {
            this.username = null;
            this.name = null;
            this.email = null;
            this.gender = null;
            this.address = null;
        }
    }

    static class Global
    {
        public static string IMAGE_PATH = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\public\\images\\";

        public static Account account = null;
    }
}
