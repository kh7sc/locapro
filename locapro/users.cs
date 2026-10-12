using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Users
    {
        private int user_id;
        private string last_name;
        private string first_name;
        private string email;
        private string phone;
        private string address;
        private string zip_code;

        public Users(int user_id, string last_name, string first_name, string email, string phone, string address, string zip_code)
        {
            this.User_id = user_id;
            this.Last_name = last_name;
            this.First_name = first_name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Zip_code = zip_code;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Zip_code { get => zip_code; set => zip_code = value; }
    }
}
