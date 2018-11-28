using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesOOP
{
    public class Car : Vehicle
    {
        private string type;

        public Car(string brand, string model, int year, string type = "sedan") : base(brand, model, year)
        {
            this.type = type;
        }
    }
}
