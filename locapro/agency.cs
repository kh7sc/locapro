using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Agency
    {
        private int agency_id;
        private string name;
        private string address;
        private string zip_code;
        private string phone;
        private string email;

        public Agency (int agency_id, string name, string address, string zip_code, string phone, string email)
        {
            this.Agency_id = agency_id;
            this.Name = name;
            this.Address = address;
            this.Zip_code = zip_code;
            this.Phone = phone;
            this.Email = email;
        }

        public int Agency_id { get => agency_id; set => agency_id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Zip_code { get => zip_code; set => zip_code = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
