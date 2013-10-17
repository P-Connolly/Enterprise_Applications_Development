using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
   
        public class Test
        {
            static void Main()
            {
                Sphere x = new Sphere(10, "x");
                Sphere y = new Sphere(20, "y");
                Sphere z = new Sphere(30, "z");

                Console.WriteLine(x.ToString());
                Console.WriteLine(y.ToString());
                Console.WriteLine(z.ToString());
                Console.ReadLine();
            }


        }
    
}