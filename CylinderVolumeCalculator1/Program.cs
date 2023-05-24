using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CylinderVolumeCalculator1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double radius = 3;
            double height = 4;
            double volume = CalculateCylinderVolume(radius, height);
            Console.WriteLine($"Volume: {volume}");
        }

        public static double CalculateCylinderVolume(double radius, double height, bool throwExceptions = true)
        {
            if (radius <= 0 || height <= 0)
            {
                if (throwExceptions)
                {
                    throw new ArgumentException("Радиус и высота должны быть больше 0.");
                }
                else
                {
                    return -1;
                }
            }

            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}

