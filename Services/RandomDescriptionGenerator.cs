using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Services
{
    public class RandomDescriptionGenerator
    {
        public string GenerateDescription()
        {
            var faker = new Faker();
            var description = faker.Lorem.Sentence(8);
            Console.WriteLine($"Generated description: {description}");
            return faker.Lorem.Sentence(8);
        }
    }
}
