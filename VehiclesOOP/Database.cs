﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesOOP
{
    public class Database
    {
        private Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

        public void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle.getChassisId(), vehicle);
        }

        public Vehicle getVehicle(string chassisId)
        {
            Vehicle vehicle = null;
            bool isFound = vehicles.TryGetValue(chassisId, out vehicle);
            return vehicle;
        }

        public List<Vehicle> getAllVehicles()
        {
            return vehicles.Values.ToList();
        }

        public void DeleteVehicle(string chassisId)
        {
            vehicles.Remove(chassisId);
        }
    }
}
