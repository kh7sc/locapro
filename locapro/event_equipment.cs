using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Event_equipment
    {
        private bool is_electric;
        private int quantity;

        public class Item : Event_equipment
        {
            public Item(bool is_electric, int quantity) : base(is_electric, quantity) { }
        }

        public Event_equipment(bool is_electric, int quantity)
        {
            this.Is_electric = is_electric;
            this.Quantity = quantity;
        }

        public bool Is_electric { get => is_electric; set => is_electric = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
