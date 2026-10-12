using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Item
    {
        private int item_id;
        private string item_name;
        private decimal daily_rate;
        private bool is_available;
        private decimal deposit;

        public Item(int item_id, string item_name, decimal daily_rate, bool is_available, decimal deposit)
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.daily_rate = daily_rate;
            this.is_available = is_available;
            this.deposit = deposit;
        }

        public int Item_id { get => item_id; set => item_id = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public decimal Daily_rate { get => daily_rate; set => daily_rate = value; }
        public bool Is_available { get => is_available; set => is_available = value; }
        public decimal Deposit { get => deposit; set => deposit = value; }
    }
}
