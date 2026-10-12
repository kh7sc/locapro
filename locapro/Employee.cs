using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Employee
    {
        private int ad_id;
        public class Users : Employee
        {
            public Users(int ad_id) : base(ad_id) { }
        }

        public Employee(int ad_id)
        {
            this.ad_id = ad_id;
        }

        public int Ad_id { get => ad_id; set => ad_id = value; }
    }
}
