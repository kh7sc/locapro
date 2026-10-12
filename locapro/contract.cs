using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Contract
    {
        private int contract_id;
        private string status;
        private DateTime start_date;
        private DateTime end_date;
        private string cloud_link;

        public Contract(int contract_id, string status, DateTime start_date, DateTime end_date, string cloud_link)
        {
            this.Contract_id = contract_id;
            this.Status = status;
            this.Start_date = start_date;
            this.End_date = end_date;
            this.Cloud_link = cloud_link;
        }

        public int Contract_id { get => contract_id; set => contract_id = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
        public string Cloud_link { get => cloud_link; set => cloud_link = value; }
    }
}
