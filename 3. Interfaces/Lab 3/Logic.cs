
namespace LogicSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface HasVolume
    {
        double Volume();
    }

    public class Sphere : HasVolume
    {
        private uint Radius { get; set; }
        private string Shape { get; set; }

        public Sphere(uint radius, string shape)
        {
            Shape = shape;
            Radius = radius;
        }

        double HasVolume.Volume()
        {
            return (3.14 * Radius * Radius * Radius);
        }
        public override string ToString()
        {
            string info = "The shape of this object is a " + Shape + " and its radius is " + Radius;
            return info;
        }

    }


}

