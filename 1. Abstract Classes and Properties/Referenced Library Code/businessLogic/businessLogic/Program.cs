using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class ThreeDShape
    {
        string Shape;

        public ThreeDShape(string Shape)
        {
            this.Shape = Shape;
        }
        public String getShape()
        {
            return Shape;
        }
        public abstract double Volume();
        public override string ToString()
        {
            return Shape;
        }
    }

    public class Sphere : ThreeDShape
    {
        public uint radius;

        public Sphere(uint radius, string Shape)
            : base(Shape)
        {
            this.radius = radius;
        }

        public override double Volume()
        {
            return (3.14 * radius * radius * radius);
        }
        public override string ToString()
        {
            string info = "The shape of this object is a " + getShape() + " and its radius is " + radius;
            return info;
        }
        
    }
}