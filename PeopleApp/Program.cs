using ForTests;
using System;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person
            {
                Name = "Bob Smith",
                DateOfBirth = new System.DateTime(1965, 12, 22),
                BucketList = WondersOfTheAncientWorld.StatueOfZeusAtOlympia
            };

            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");
            WriteLine($"{p1.Name}'s favurite wonder is {p1.BucketList}");

            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            //p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");


            p1.Children.Add(new Person { Name = "Alfred" });
            p1.Children.Add(new Person { Name = "Zoe" });
            WriteLine($"{p1.Name} has {p1.Children.Count} children:");
            for (int child = 0; child < p1.Children.Count; child++)
            {
                WriteLine($"{p1.Children[child].Name}");
            }
            WriteLine($"{p1.Name} is {Person.Species}");
            WriteLine($"{p1.Name} was born on {p1.HomePlanet}");

            var p2 = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 17)
            };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:d MMM yy}");
            WriteLine(new string('-', 50));

            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at {p3.Instantiated:hh:mm:ss} on " +
                $"{p3.Instantiated:dddd, d MMMM yyyy}");
            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instantiated at {p4.Instantiated:hh:mm:ss} on " +
                $"{p4.Instantiated:dddd, d MMMM yyyy}");
            WriteLine(new string('-', 50));

            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            WriteLine(new string('-', 50));

            BankAccount.InterestRate = 0.012M;

            var ba1 = new BankAccount
            {
                AccountName = "Mrs. Jones",
                Balance = 2400
            };
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest");

            var ba2 = new BankAccount
            {
                AccountName = "Ms.Gerrier",
                Balance = 98
            };
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest");
            WriteLine(new string('-', 50));
            // Tuples
            Tuple<string, int> fruit4 = p1.GetFruitCS4();
            WriteLine($"There are {fruit4.Item2} {fruit4.Item1}");

            (string, int) fruit7 = p1.GetFruitCS7();
            WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are");

            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}?");
            WriteLine(new string('-', 50));

            var thing1 = ("Neville", 4);
            WriteLine(
                $"{thing1.Item1} has {thing1.Item2} children");
            var thing2 = (p1.Name, p1.Children.Count);
            WriteLine(
                $"{thing2.Name} has {thing2.Count} children");

            WriteLine(new string('-', 50));
            WriteLine(p1.SayHello());
            WriteLine(p1.SayHello("Emily"));

            WriteLine(new string('-', 50));
            WriteLine(p1.OptionalParameters());
            WriteLine(p1.OptionalParameters("Jump!", 98.5));
            WriteLine(p1.OptionalParameters(number: 52.7, command: "Hide!"));
        }
    }
}
