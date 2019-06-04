using System;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class DriverLicense
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string LicenseNumber { get; set; }

        public DriverLicense(string FirstName, string LastName, string Gender, string LicenseNumber)
        {
            FirstName = FName;
            LastName = LName;
            Gender = Gndr;
            LicenseNumber = LNumber;
        }

        public string FullName()
        {
            return (FirstName + " " + LastName);
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Authors { get; set; }
        public int PageNumbers { get; set; }
        public Int32 SKU { get; set; }
        public string Publisher { get; set; }
        public Decimal Price { get; set; }

        public Book(string ttle, string authrs, string pgenumbrs, Int32 sku, string publsher,  Decimal price)
        {
            Title = ttle;
            Authors = authrs;
            PageNumbers = pgenumbrs;
            SKU = sku;
            Publisher = publsher;
            Price = price;

        }
    }
    class Airplane
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public Int32 Capacity { get; set; }
        public Int32 Engines { get; set; }

        public Airplane(string manufact, string mdl, string varint, Int32 capacty, Int32 engine)
        {
            Manufacturer = manufact;
            Model = mdl;
            Variant = varint;
            Capacity = capacty;
            Engines = engine;
        }
    }

}
