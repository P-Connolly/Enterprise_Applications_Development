using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicSpace;
namespace Lab_5
{
    
    public class test
    {
        public static void Main()
        {
        Money x = new Money(10, "USD");
        Money y = new Money(10, "GBP");
         Dictionary<string, double> rates = new Dictionary<string, double>()
        {
            //USD Rates
           {"USDUSD", 1},
           {"EURUSD", 0.74158},
           {"GBPUSD", 0.62587},
           //EURO RATES
           {"USDEUR", 1.34894},
           {"EUREUR", 1},
           {"GBPEUR", 0.84351},
           //GBP RATES
           {"USDGBP", 1.59918},
           {"EURGBP", 1.18573},
           {"GBPGBP", 1}
        };
        Money z = new Money();
        z = z.combine(x, y,rates);
        Console.WriteLine("Currency:" + z.retCurrency() + " Amount:" + z.retAmount());
        Console.ReadLine();
        }
    }
  
}
