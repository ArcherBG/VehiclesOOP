using System;

namespace VehiclesOOP
{
    public abstract class Vehicle
    {
        private string chassisId;
        protected string brand { get; set; }
        protected string model { get; set; }
        protected int year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            this.chassisId = Guid.NewGuid().ToString();
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public Vehicle(string chassisId, string brand, string model, int year)
        {
            this.chassisId = chassisId;
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public string getChassisId() { return chassisId; }
                
        public override string ToString()
        {
            return chassisId + "," + brand + "," + model + "," + year;
        } 
    }
}
