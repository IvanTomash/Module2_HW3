using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    /// <summary>
    /// Circle.
    /// </summary>
    internal class Circle : IShapeable
    {
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle()
        {
            this.radius = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">e.</param>
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Calculate an area of the circle.
        /// </summary>
        /// <returns>Area in square centimeters.</returns>
        public double Area()
        {
            double res = Math.Pow(this.radius, 2) * Math.PI;
            return res;
        }

        /// <summary>
        /// Calculate a perimeter of the circle.
        /// </summary>
        /// <returns>Perimeter in centimeters.</returns>
        public double Perimeter()
        {
            double res = 2 * this.radius * Math.PI;
            return res;
        }

        /// <summary>
        /// Show info about the shape.
        /// </summary>
        public void ShowInfo()
        {
            string output = "Radius: " + this.radius;
            Console.WriteLine(output);
        }
    }
}
