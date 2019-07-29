using System;
using System.Collections.Generic;
using static System.Console;

namespace ForTests
{
    public class Person : Object
    {
        // fields
        public string Name;
        public int Number;
        public DateTime DateOfBirth;


        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        // only read fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // initializing default values for fields,
            // including read only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        // old syntax C# 4 and type .NET 4.0 System.Tuple
        public Tuple<string, int> GetFruitCS4()
        {
            return Tuple.Create("Apples", 5);
        }

        // new syntax C# 7 and new type System.ValueTuple
        public (string, int) GetFruitCS7()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number = 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello, {name}!";
        }

        public string OptionalParameters(string command = "Run!",
            double number = 0.0, bool active = true)
        {
            return $"command is {command}, number is {number}, " +
                $"active is {active}";
        }
    }
}
