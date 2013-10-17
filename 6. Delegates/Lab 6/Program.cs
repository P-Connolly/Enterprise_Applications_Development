using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LogicSpace
{
  
   public class test
   {
       static int invokerPeriod { get; set; }
       public delegate void EventCount();
       public static event EventCount show;

       public delegate void EventCountLambda();
       public static event EventCountLambda showLambda;

       static void Finished()
       {
           Console.WriteLine("Finished " + invokerPeriod);
           Console.Beep();
       }
       public static void Main()
       {

           show += new EventCount(Finished);
           test.showLambda += () => Console.WriteLine("Second Handler");
           

           invokerPeriod = 1000;
           CountDown CountObj = new CountDown(invokerPeriod);

           for (int y = 1; y < 6; y++)
           {
               Console.WriteLine(y);
               Thread.Sleep(CountObj.getPeriod());
           }
           show.Invoke();
           showLambda.Invoke();

       }
       
   }
}
