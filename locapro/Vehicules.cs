using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locapro
{
    internal class Vehicule
    {
        private string license_plate;
        private decimal mileage_km;
        private string fuel_type;

        public class Item : Vehicule
        {
            public Item(string license_plate, decimal mileage_km, string fuel_type) : base(license_plate, mileage_km, fuel_type) { }
        }

        public Vehicule(string license_plate, decimal mileage_km, string fuel_type)
        {
            this.License_plate = license_plate;
            this.Mileage_km = mileage_km;
            this.Fuel_type = fuel_type;
        }

        public string License_plate { get => license_plate; set => license_plate = value; }
        public decimal Mileage_km { get => mileage_km; set => mileage_km = value; }
        public string Fuel_type { get => fuel_type; set => fuel_type = value; }
    }
}
