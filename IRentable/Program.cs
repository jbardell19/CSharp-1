using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class MainClass
    {
        

        public static void Main(string[] args)
        {
        List<iRental> Rental = new List<iRental>();
            Rental.Add(new Boat("touche"));
            Rental.Add(new House("I am a house"));
            Rental.Add(new Car("I am a car. VROOM"));

        foreach (iRental rentable in Rental)
        {
            Console.WriteLine($"{rentable.GetType()}: {rentable.GetDescription()}");
            Console.ReadLine();
        }
    }
    }
    public interface iRental
    {
        decimal GetDailyRate();
        string GetDescription();
    }
    class Boat : iRental
    {
        
        string Boat_Description { get; set; }
        decimal hourlyRate = 15.00m;
        string Type { get; set; }
        public Boat(string type)
        {
            Type = type;
        }
        public decimal GetDailyRate()
        {
            return decimal.Round(hourlyRate * 24, 2);
        }
        public string GetDescription()
        {
            Boat_Description = String.Format("Boat rental daily rate is : " + this.GetDailyRate());
            return Boat_Description;
        }

    }
    class House : iRental
    {
        decimal WeeklyRate = 250m;
        string House_Description { get; set; }

        
        string Type { get; set; }
        public House(string type)
        {
            Type = type;
        }
        public decimal GetDailyRate()
        {
            return Math.Round(WeeklyRate / 7, 2);
        }

        public string GetDescription()
        {

            House_Description = String.Format("House rental weekly is : " + WeeklyRate);
            return House_Description;
        }

    }
    class Car : iRental
    {
        string Car_Description { get; set; }
        decimal HourlyRate = 100m;
        decimal DailyRate;
        string Type { get; set; }
        public Car(string type)
        {
            Type = type;
        }
        public decimal GetDailyRate()
        {
        return HourlyRate;
    }
        public string GetDescription()
        {
            Car_Description = String.Format("Car rental hourly is : " + HourlyRate);
            return Car_Description;
        }

    }


