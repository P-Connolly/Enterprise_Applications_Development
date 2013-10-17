using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSpace
{
    public class CountDown
    {
        public CountDown CountObj;
        int Period;

        public int getPeriod()
        {
            return Period;
        }

        public CountDown(int period)
        {
            Period = period;
        }
    }
}
