using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Customer
    {
        private int contract_count;

        public Customer(int contract_count)
        {
            this.Contract_count = contract_count;
        }

        public int Contract_count { get => contract_count; set => contract_count = value; }
    }
}
