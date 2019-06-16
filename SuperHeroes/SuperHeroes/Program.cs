using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.ReadLine();
        }
        public class Person
        {
            public virtual string Name { get; set; }
            public string NickName { get; set; }

            public Person(string PersonName, string PersonNickName)
            {
                Name = PersonName;
                NickName = PersonNickName;
            }
            public override string ToString()
            {
                return Name;
            }
            public virtual void PrintGreeting()
            {
                Console.WriteLine("Hi, my name is {0}, you can call me {1}.", Name, NickName);
            }
        }

        public class SuperHero: Person
        {
            public override string Name { get => base.Name; set => base.Name = value; }
            public string RealName { get; set; }
            public string SuperPower { get; set; }

            public SuperHero(string Name, string RealName, string SuperPower) : base(Name, null)
            {
                Console.WriteLine("I am {0}.  My SuperHero name is {1}. One of my powers is {2}", RealName, Name, SuperPower);
            }
        }

        public class Villain: Person
        {
            public override string Name { get => base.Name; set => base.Name = value; }
            public string ArchNemesis { get; set; }

            //Your Villain class should have a constructor that takes in the name and nemesis of the villain.And should pass null to the base constructor for the nickname.
            public string Villain(string name, string anemesis) : base(Name, null)
            {
                ArchNemesis = anemesis;
            }


            
            public override void PrintGreeting()
            {
                Console.WriteLine("I am {0}. Have you seen {1}?", Name, ArchNemesis);
            }
        }
    }
}
