using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World This is Linq Stuff!");

            //Restriction/Filtering Operations

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;

            foreach (string fruit in LFruits)
            {
                Console.WriteLine($"LFruit '{fruit}'");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 6 == 0 || number % 4 == 0);
            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine($"'{number}' divided by 4 or 6 evenly");
            }

            //Ordering Operations
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };
            List<string> descend = new List<string>(names.OrderByDescending(n => n));
            foreach (string name in descend)
            {
                Console.WriteLine($"'{name}' z to a");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> orderingNumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            List<int> ascend = new List<int>(orderingNumbers.OrderBy(n => n));
            foreach (int number in ascend)
            {
                Console.WriteLine($"'{number}' 1 to 9");
            }

            // Aggregate Operations
            // Output how many numbers are in this list
            List<int> aggNumbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            int AggNumbersCount = aggNumbers.Count;
            Console.WriteLine($"AggNumbersCount {AggNumbersCount}");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            double totalSpent = purchases.Sum();
            Console.WriteLine($"totalSpent {totalSpent}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            double mostExpensive = prices.Max();
            Console.WriteLine($"mostExpensive {mostExpensive}");

        }

    }
}