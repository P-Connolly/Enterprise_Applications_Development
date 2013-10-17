using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
namespace Lab_4
{
   

    class test
    {
        public static void Main()
        {

            double first;
            double second;
            Console.WriteLine("Please enter the first number");
            try
            {
                first = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                second = Double.Parse(Console.ReadLine());
                Console.WriteLine("Divided Result:" + Calculator.Divide(first, second));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    Console.WriteLine("The value must be a viable floating point number.");
                    Console.ReadLine();
                }
            }
            int z = 0;
            
            try
            {
                ModuleCAResults y = new ModuleCAResults("Paul", 5, "Computing");
                y["CA1"] = "A";
                y["CA2"] = "B";
                y["CA3"] = "C";
                y.ToString();

               /* foreach (KeyValuePair<string, string> kvp in y)
                {
                    
                    z++;
                    string testString = "CA";
                    testString = testString + z;
                    if(kvp.Key != testString)
                    { throw new FormatException(); }

                }*/

            }
            catch(FormatException)
            { Console.WriteLine("The CA details have been improperly entered."); }
            Console.ReadLine();


        }
    }
}
