
using System;

namespace VehiclesOOP
{
    public abstract class Vehicle
    {
        protected string chassisId;
        protected string brand;
        protected string model;
        protected int year;

        public Vehicle(string  brand, string model, int year)
        {
            this.chassisId = Guid.NewGuid().ToString();
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
    }
}
