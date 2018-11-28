using System;

namespace VehiclesOOP
{
    class Truck : Vehicle
    {
        private bool isSemiTruck { get; set; }

        public Truck(string brand, string model, int year, bool isSemiTruck = false) : base(brand, model, year)
        {
            this.isSemiTruck = isSemiTruck;
        }
    }
}
