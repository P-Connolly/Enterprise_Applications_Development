using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Calculator
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

    public class ModuleCAResults
    {

        private string StudentName { get; set; }
        private int Credits { get; set; }
        private string ModuleName { get; set; }
        private Dictionary<string, string> CA = new Dictionary<string, string>();

        public string this[string caNum]
        {
            get { return CA[caNum];  }
            set{CA[caNum] = value;}
        }


        public ModuleCAResults(string studentName, int credits, string moduleName)
        {
            StudentName = studentName;
            Credits = credits;
            ModuleName = moduleName;
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
