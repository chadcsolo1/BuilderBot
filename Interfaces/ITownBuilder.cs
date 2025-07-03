using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Interfaces
{
    public interface ITownBuilder
    {
        void Buildheader();
        void BuildBody();
        void BuildFooter();

        TownReport GetReport();
    }
}
