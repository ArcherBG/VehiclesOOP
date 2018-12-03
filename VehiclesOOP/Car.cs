using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesOOP
{
    public class Car : Vehicle
    {
        private string type { get; set; }

        public Car(string brand, string model, int year, string type = "sedan") : base(brand, model, year)
        {
            this.type = type;
        }

        public Car(string chassisId, string brand, string model, int year, string type = "sedan") : base(chassisId, brand, model, year)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return base.ToString() + "," + type;
        }
    }
}
