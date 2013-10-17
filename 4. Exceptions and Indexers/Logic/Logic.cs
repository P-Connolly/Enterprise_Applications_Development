using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Calculator
    {
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("The second inputed number cannot be zero");
            }
            else
            {
                return x / y;
            }
        }
    }

    class ModuleCAResults
    {

        private string StudentName { get; set; }
        private int Credits { get; set; }
        private string ModuleName { get; set; }
        Dictionary<string, string> CA = new Dictionary<string, string>();

        public ModuleCAResults(string studentName, int credits, string moduleName, Dictionary<string, string> ca)
        {
            StudentName = studentName;
            Credits = credits;
            ModuleName = moduleName;
            CA = ca;
        }
        public override string ToString()
        {
            Console.WriteLine(StudentName);
            Console.WriteLine(ModuleName);

            foreach (KeyValuePair<string, string> kvp in CA)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value);

            }
            return "";
        }






    }
}
