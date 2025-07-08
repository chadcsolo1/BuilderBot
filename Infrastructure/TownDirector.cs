using BuilderBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Infrastructure
{
    public class TownDirector
    {
        private readonly ITownBuilder _townBuilder;
        public TownDirector(ITownBuilder townBuilder)
        {
            _townBuilder = townBuilder;
        }
        public void BuildTown()
        {
            _townBuilder.BuildName();
            _townBuilder.BuildDescription();
            _townBuilder.BuildImageUrl();
            _townBuilder.BuildDateCreated();
            _townBuilder.BuildAverageIncome();
            _townBuilder.BuildBiggestAttraction();
            _townBuilder.BuildPopulation();
        }
    }
}
