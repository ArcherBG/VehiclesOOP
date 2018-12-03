using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Database database = new Database();
                while (true)
                {
                    Console.WriteLine("Select one of the following:");
                    Console.WriteLine("1. Load data from 'input' file");
                    Console.WriteLine("2. Write current data into 'output' file");
                    Console.WriteLine("3. Find vehicle");
                    Console.WriteLine("4. Add vehicle");
                    Console.WriteLine("5. Delete vehicle");
                    Console.WriteLine("6. List all vehicles data");
                    Console.WriteLine("7. Sort vehicles by type");
                    Console.Write("Your Input: ");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            {
                                FileManager fileManager = new FileManager();
                                List<string> vehicles = fileManager.ReadFile("input.txt");
                                foreach (string vehicleString in vehicles)
                                {
                                    String[] vehicleProps = vehicleString.Split(',');                                   
                                    if (vehicleProps[4].ToLower() != "true" && vehicleProps[4].ToLower() != "false")
                                    {
                                        Car car = new Car(
                                            vehicleProps[0],
                                            vehicleProps[1],
                                            vehicleProps[2],
                                            Int32.Parse(vehicleProps[3]),
                                            vehicleProps[4]
                                            );
                                        database.addVehicle(car);
                                    }
                                    else
                                    {
                                        Truck truck = new Truck(
                                          vehicleProps[0],
                                          vehicleProps[1],
                                          vehicleProps[2],
                                          Int32.Parse(vehicleProps[3]),
                                          Boolean.Parse(vehicleProps[4])
                                          );
                                        database.addVehicle(truck);
                                    }
                                }
                                Console.WriteLine("Done!\n");                  
                                break;
                            }
                        case "2":
                            {
                                FileManager fileManager = new FileManager();
                                StringBuilder builder = new StringBuilder();
                                foreach(Vehicle vehicle in database.getAllVehicles())
                                {                   
                                    builder.AppendLine(vehicle.ToString());
                                }
                               
                                fileManager.WriteToFile("output.txt", builder.ToString());
                                Console.WriteLine("Done!\n");                        
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("Enter chassis id of the seached vehicle");
                                string chassisId = Console.ReadLine();
                                Vehicle vehicle = database.getVehicle(chassisId);
                                if (vehicle != null)
                                {
                                    Console.WriteLine("March found: " + vehicle.ToString() + "\n");
                                }else
                                {
                                    Console.WriteLine("Vehicle was not found.\n");
                                }
                                    break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Is it a car ot truck [car/truck]:");
                                string answer = Console.ReadLine();
                                if (answer.ToLower() != "car" && answer.ToLower() != "truck")
                                {
                                    Console.WriteLine("Invalid input");
                                    break;
                                }

                                Console.WriteLine("Enter brand:");
                                string brand = Console.ReadLine();
                                Console.WriteLine("Enter model:");
                                string model = Console.ReadLine();
                                Console.WriteLine("Enter year:");
                                string year = Console.ReadLine();
                                if (answer.ToLower() == "car")
                                {
                                    Console.WriteLine("Type (sedan, estate, etc):");
                                    string type = Console.ReadLine();
                                    Car car = new Car(brand, model, Int32.Parse(year), type);
                                    database.addVehicle(car);
                                }
                                else
                                {
                                    Console.WriteLine("Is semi truck:");
                                    string semiTruck = Console.ReadLine();
                                    if (semiTruck.ToLower() == "yes")
                                    {
                                        Truck truck = new Truck(brand, model, Int32.Parse(year), true);
                                        database.addVehicle(truck);
                                    }
                                    else
                                    {
                                        Truck truck = new Truck(brand, model, Int32.Parse(year), false);
                                        database.addVehicle(truck);
                                    }
                                }
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Enter chassis id of the vehicle you want to delete");
                                string chassisId = Console.ReadLine();
                                database.DeleteVehicle(chassisId);
                                break;
                            }
                        case "6":
                            {
                                Array vehicles = database.getAllVehicles();
                                foreach (Vehicle vehicle in vehicles)
                                {
                                    Console.WriteLine(vehicle.ToString());
                                }
                                break;
                            }
                        default: { continue; }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something when wrong: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
