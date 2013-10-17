using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
   public class Vertex
    {

       private int Xco { get; set; }//endpoint of a line.
       private int Yco { get; set; }//origin of a circle.

       

       public Vertex(int xco, int yco)
       {
           Xco = xco;
           Yco = yco;
       }

    }

   public class Shape
   {
       public string Colour { get; set; }

       public Shape(string colour)
       {
           Colour = colour;
       }

       public override string ToString()
       {
           return Colour;
       }
       public virtual void Translate(int xOne, int xTwo, int yOne, int yTwo)
       {
          
       }
   }

    public class Line:Shape
    {
        int XOne { get; set; }
        int XTwo { get; set; }
        int YOne { get; set; }
        int YTwo { get; set; }

        public Line(int xOne, int xTwo, int yOne, int yTwo, string colour) : base(colour)
        {
            XOne = xOne;
            XTwo = xTwo;
            YOne = yOne;
            YTwo = yTwo;
        }

        public override string ToString()
        {
            Console.WriteLine("x & y coordinates for endpoint 1: " + XOne + " " + YOne);
            Console.WriteLine("x & y coordinates for endpoint 2: " + XTwo + " " + YTwo);
            Console.WriteLine("Colour of the line: " + Colour);
            return "";
        }

        public override void Translate(int xOne, int xTwo, int yOne, int yTwo)
        {
            XOne = xOne + XOne;
            XTwo = xTwo + XTwo;
            YOne = yOne + YOne;
            YTwo = yTwo + YTwo;
        }
    }

    public class Circle : Shape
    {
        int XOne { get; set; }
        int XTwo { get; set; }
        int YOne { get; set; }
        int YTwo { get; set; }
        private int Radius { get; set; }

        public Circle(int xOne, int xTwo, int yOne, int yTwo, int radius, string colour) : base(colour)
        {
            XOne = xOne;
            XTwo = xTwo;
            YOne = yOne;
            YTwo = yTwo;
            Radius = radius;
        }

        public override string ToString()
        {
            string info = "Colour: " + Colour + " Radius: " + Radius + " Endpoint 1 x Coordinate: " + XOne + " Endpoint 1 Y Coordinate: " + YOne + " Endpoint 2 x Coordinate: " + XTwo + " Endpoint 2 Y Coordinate: " + YTwo; 
            return info;
        }

        public override void Translate(int xOne, int xTwo, int yOne, int yTwo)
        {
            XOne = xOne + XOne;
            XTwo = xTwo + XTwo;
            YOne = yOne + YOne;
            YTwo = yTwo + YTwo;
        }
        public double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }

    
}


