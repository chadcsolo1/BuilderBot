using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBot
{
    public class TownReport
    {
        public string? HeaderPart
        {
            get;
            set;
        }

        public string? BodyPart
        {
            get;
            set;
        }

        public string? FooterPart
        {
            get;
            set;
        }

        public override string ToString() =>
            $"{HeaderPart}\n\n{BodyPart}\n\n{FooterPart}";
    }
}
