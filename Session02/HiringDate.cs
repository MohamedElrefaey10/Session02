using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    internal class HiringDate
    {

        public int Day { get; set; }
        public int Month { get; set; }
        public int Years { get; set; }
        
        public HiringDate(int day, int month, int years)
        {
            Day = day;
            Month = month;
            Years = years;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Years}";
        }



    }
}
