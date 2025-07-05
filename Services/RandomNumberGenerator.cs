using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Services
{
    public class RandomNumberGenerator
    {
        private readonly Random _random = new Random();

        public int GeneratePopulation()
        {
            var min = 5000;
            var max = 1000000;

            var num = _random.Next(min, max + 1);
            Console.WriteLine($"Random number : {num}");
            return num;
        }

        public int GenerateAverageIncome()
        {
            var min = 35000;
            var max = 100000;

            var num = _random.Next(min, max + 1);
            Console.WriteLine($"Random number : {num}");
            return num;
        }
    }
}
