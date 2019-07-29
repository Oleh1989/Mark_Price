using System;
using System.Collections.Generic;
using System.Text;

namespace ForTests
{
    public partial class Person
    {
        // property determined in C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties determined with lamda syntax from C# and higher
        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => (int)(System.DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25);

        public string FavoriteIceCream { get; set; }

        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a " +
                            $"primary color. Choose from: red, green, blue");
                }
            }
        }

        // indexators
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }
    }
}
