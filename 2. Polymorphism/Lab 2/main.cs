using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Test
    {
        static void Main()
        {
            Shape x = new Line(1, 2, 3, 4, "Blue");
            Shape y = new Circle(1, 2, 3, 4, 10, "Yellow");

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine("Translated...");
            x.Translate(1, 1, 1, 1);
            y.Translate(1, 1, 1, 1);
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.ReadLine();

        }



    }
    }