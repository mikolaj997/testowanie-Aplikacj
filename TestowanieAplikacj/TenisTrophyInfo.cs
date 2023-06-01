using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestowanieAplikacj
{
    public class TenisTrophyInfo
    {
        public string TrophyCountInfo(double trophy) => trophy switch
        {
            < 1 => "adverage player",
            < 5 => "good player",
            < 10 => "experience player",
            <= 20 => "Extremly good player",
            _ => throw new ArgumentException("Invalid trophy count")
        };
    }
}
