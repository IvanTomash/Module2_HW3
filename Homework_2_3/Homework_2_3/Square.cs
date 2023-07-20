using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    /// <summary>
    /// Square.
    /// </summary>
    internal class Square : Rhombus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        public Square()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side">All sides of the square are equal.</param>
        public Square(double side)
            : base(side, new double[] { 90, 90, 90, 90 })
        {
        }

        /// <summary>
        /// Perimeter calculation is the same for all quadrangulars.
        /// </summary>
        /// <returns>Perimeter in centimeters.</returns>
        public override double Perimeter()
        {
            double res = base.Perimeter();
            return res;
        }

        /// <summary>
        /// Calculate an area of the Rhombus.
        /// </summary>
        /// <returns>Area in square centimeters.</returns>
        public override double Area()
        {
            double res = 0;
            res = Math.Pow(this.Sides[0], 2);
            return res;
        }
    }
}
