using BuilderBot.Services;
using BuilderBot.Interfaces;
using BuilderBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using RandomNumberGenerator = BuilderBot.Services.RandomNumberGenerator;
using System.Data;

namespace BuilderBot.Infrastructure
{
    public class TownBuilder : ITownBuilder
    {
        private Town _townBuild;
        //private readonly  IEnumerable<Town> _towns;
        RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        RandomDescriptionGenerator randomDescriptionGenerator = new RandomDescriptionGenerator();

        public TownBuilder()
        {
            _townBuild = new Town();
            //_towns = towns;
        }

        public void BuildAverageIncome()
        {
            
            _townBuild.AverageIncome = randomNumberGenerator.GenerateAverageIncome();
        }

        public void BuildBiggestAttraction()
        {
            //RandomDescriptionGenerator randomDescriptionGenerator = new RandomDescriptionGenerator();
            _townBuild.BiggestAttraction = randomDescriptionGenerator.GenerateBiggestAttraction();
        }

        public void BuildDateCreated()
        {
            _townBuild.DateCreated = DateTime.Now;
        }

        public void BuildDescription()
        {
            
            _townBuild.Description = randomDescriptionGenerator.GenerateDescription();
        }

        public void BuildImageUrl()
        {
            _townBuild.ImageUrl = "";
        }

        public void BuildName()
        {
            //RandomDescriptionGenerator randomDescriptionGenerator = new RandomDescriptionGenerator();
            _townBuild.Name = randomDescriptionGenerator.GenerateName();
        }

        public void BuildPopulation()
        {
            //RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            _townBuild.Population = randomNumberGenerator.GeneratePopulation();
        }

        public void BuildupdateDate()
        {
            throw new NotImplementedException();
        }

        public Town GetTown()
        {
            var town = _townBuild;

            Clear();

            return town;
        }

        private void Clear() => _townBuild = new Town();

    }
}
