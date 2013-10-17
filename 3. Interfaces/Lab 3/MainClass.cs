using System;
using LogicSpace;
namespace MainSpace
{

    public class Test
    {
        static void Main()
        {
            Sphere x = new Sphere(10, "x");
            Sphere y = new Sphere(20, "y");
            HasVolume z = new Sphere(30, "z");
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(z.ToString());
            Console.WriteLine(z.Volume());
            Console.ReadLine();
        }


    }
}
