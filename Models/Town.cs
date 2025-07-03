using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot.Models
{
    public class Town
    {
        public string Name
        {
            get;
            set;
        }   = string.Empty;

        public string Description
        {
            get;
            set;
        } = string.Empty;

        public string BiggestAttraction
        {
            get;
            set;
        }  = string.Empty;

        public string ImageUrl
        {
            get;
            set;
        }   = string.Empty;

        public int Population
        {
            get;
            set;
        } = 0;

        public int AverageIncome
        {
            get;
            set;
        } = 0;

        public DateTime DateCreated
        {
            get;
            set;
        }

        public DateTime UpdateDate
        {
            get;
            set;
        }

        public override string ToString() =>
            $"{Name}\n\n{Description}\n\n{BiggestAttraction}\n\n{Population}\n\n{AverageIncome}";
    }
}
