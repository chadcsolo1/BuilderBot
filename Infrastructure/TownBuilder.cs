using BuilderBot.Interfaces;
using BuilderBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Infrastructure
{
    public class TownBuilder : ITownBuilder
    {
        private TownReport _report;
        private  IEnumerable<Town> _towns;

        public TownBuilder(IEnumerable<Town> towns)
        {
            _report = new TownReport();
            _towns = towns;
        }
        public void BuildBody()
        {
            throw new NotImplementedException();
        }

        public void BuildFooter()
        {
            throw new NotImplementedException();
        }

        public void Buildheader()
        {
            throw new NotImplementedException();
        }

        public TownReport GetReport()
        {
            throw new NotImplementedException();
        }
    }
}
