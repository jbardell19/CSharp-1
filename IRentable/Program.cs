using System;
using System.Collections.Generic;

namespace IRentable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> Rental = new List<string>();
            Rental.Add(new Boat());
            Rental.Add(new House());
            Rental.Add(new Car());
        }
    }
    public interface IRentable
    {
        decimal GetDailyRate();
        string GetDescription();
    }
    class Boat : IRentable
    {
        private decimal _hourlyRate = 15.00m;

        public decimal GetDailyRate()
        {
            return decimal.Round(_hourlyRate * 24, 2);
        }
        public string GetDescription()
        {
            return Console.WriteLine("I am a boat. Toot Toot!");
        }
        
    }
    class House : IRentable
    {
        private decimal DailyRate = 250m;

        public decimal GetDailyRate()
        {
            private decimal WeeklyRate = DailyRate * 7m;
        }
    }
        public void GetDescription()
        {
            return Console.WriteLine("I am a house. I do not talk!");
        }
        
    }
    class Car : IRentable
    {
        decimal HourlyRate = 100m;
        
        public void GetDailyRate()
        {
            decimal DailyRate = HourlyRate * 24;
        }
        public void GetDescription()
        {
            Console.WriteLine("I am a car. V to the ROOM!!");
        }
        
    }

