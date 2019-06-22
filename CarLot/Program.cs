using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class CarLot
    {
        public string name { get; set; }

        public CarLot(string CarLotName)
        {
            name = CarLotName;

        }
        public List<Vehicle> VehicleType = new List<Vehicle>();

    }
    abstract class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int price { get; set; }

        public Vehicle(string licenseNumber, string Make, string Model, int Price)
        {
            LicenseNumber = licenseNumber;
            make = Make;
            model = Model;
            price = Price;
        }

        public virtual string VehicleDescript()
        {
            string VehicleDescript = make + model + price + LicenseNumber;
            return VehicleDescript;
        }
    }
}
