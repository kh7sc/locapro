using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Heavy_machinery
    {
        private string caces_reqired;
        private decimal weight_kg;

        public class Item : Heavy_machinery
        {
            public Item(string caces_reqired, decimal weight_kg) : base(caces_reqired, weight_kg) { }
        } 

        public Heavy_machinery(string caces_reqired, decimal weight_kg)
        {
            this.Caces_reqired = caces_reqired;
            this.Weight_kg = weight_kg;
        }

        public string Caces_reqired { get => caces_reqired; set => caces_reqired = value; }
        public decimal Weight_kg { get => weight_kg; set => weight_kg = value; }
    }
}
