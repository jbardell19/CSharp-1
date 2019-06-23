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
            CarLot TruckLot = new CarLot("Trucks");
            Vehicle vehicle1 = new Truck("ABCD123", "Ford", "F150", 45000, 6);
            Vehicle vehicle2 = new Truck("DCBA321", "Toyota", "Tacoma", 35000, 4);
            TruckLot.AddCars(vehicle1);
            TruckLot.AddCars(vehicle2);
            TruckLot.PrintInventory();


            CarLot CarLot = new CarLot("Cars");
            Vehicle vehicle3 = new Car("FGHJ123", "Nissan", "Rogue", 28000, 4);
            Vehicle vehicle4 = new Car("FGHJ321", "Honda", "Odyssey", "Van", 36000, 4);
            CarLot.AddCars(vehicle3);
            CarLot.AddCars(vehicle4);
            CarLot.PrintInventory();
            Console.Read();
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
        public virtual void AddCars(Vehicle vehicle1)
        {
            VehicleType.Add(vehicle1);
        }

        public virtual void PrintInventory()
        {
            Console.WriteLine("{0} parking lot includes these vehicles: ", name);
            foreach (Vehicle vehicles in VehicleType)
            {
                Console.WriteLine(vehicles.VehicleDescript());
            }
        }

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
    class Truck : Vehicle
    {
        public int bedSize { get; set; }

        public Truck(string licenseNumber, string Make, string Model, int Price, int BedSize) : base(licenseNumber, Make, Model, Price)
        {
            bedSize = BedSize;
            LicenseNumber = licenseNumber;
            make = Make;
            model = Model;
            price = Price;
        }


        public override string VehicleDescript()
        {
        string VehicleDescript = "Truck Info: " + " Make: " + make + " Model: " + model + " Price: " + price.ToString("c0") + " Bedsize: " + bedSize + " License #: " + LicenseNumber + "\n";
        return VehicleDescript;
    }
}
        class Car : Vehicle
    {
        private int v;

        public string type { get; set; }
        public int numDoors { get; set; }

    public Car(string LicenseNumber, string Make, string Model, string Type, int Price, int NumDoors) : base(LicenseNumber, Make, Model, Price)
    {
        LicenseNumber = LicenseNumber;
        make = Make;
        model = Model;
        price = Price;
        type = Type;
        numDoors = NumDoors;
    }

        public Car(string licenseNumber, string Make, string Model, int Price, int v) : base(licenseNumber, Make, Model, Price)
        {
            this.v = v;
        }

        public override string VehicleDescript()
    {
        string VehicleDescript = "Car Info: " + " Make: " + make + " Model: " + model + " Price: " + price.ToString("c0") + " Type: " + type + " Number of Doors: " + numDoors + " License #: " + LicenseNumber + "\n";
        return VehicleDescript;
    }
    }
}
