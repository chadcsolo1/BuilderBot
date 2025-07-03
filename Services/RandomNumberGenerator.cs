using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Functionalities
{
    public class RandomNumberGenerator
    {
        private readonly Random _random = new Random();

        public int Generate()
        {
            var min = 5000;
            var max = 1000000;

            var num = _random.Next(min, max + 1);
            Console.WriteLine($"Random number : {num}");
            return num;
        }
    }
}
