using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Interfaces
{
    public interface ITownBuilder
    {
        void BuildName();
        void BuildDescription();
        void BuildBiggestAttraction();
        void BuildImageUrl();
        void BuildPopulation();
        void BuildAverageIncome();
        void BuildDateCreated();
        void BuildupdateDate();

        TownReport GetTown();
    }
}
