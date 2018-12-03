using System;

namespace VehiclesOOP
{
    class Truck : Vehicle
    {
        private bool isSemiTruck { get; set; }
        private bool isTrailerAttached { get; set; }

        public Truck(string brand, string model, int year, bool isSemiTruck = false) : base(brand, model, year)
        {
            this.isSemiTruck = isSemiTruck;
        }

        public Truck(string chassisId, string brand, string model, int year, bool isSemiTruck = false) : base(chassisId, brand, model, year)
        {
            this.isSemiTruck = isSemiTruck;
        }

        public void AttachTrailer()
        {
            if(isTrailerAttached)
            {
                throw new Exception("Another trailer is already attached.");
            }

            isTrailerAttached = true;
        }

        public void DetachTrailer()
        {
            isTrailerAttached = false;
        }

        public override string ToString()
        {
            return base.ToString() + "," + isSemiTruck + "," + isTrailerAttached;
        } 
    }
}
