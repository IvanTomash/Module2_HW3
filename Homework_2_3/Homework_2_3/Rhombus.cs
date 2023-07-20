using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    /// <summary>
    /// Rhombus.
    /// </summary>
    internal class Rhombus : Parallelogram
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rhombus"/> class.
        /// </summary>
        public Rhombus()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rhombus"/> class.
        /// </summary>
        /// <param name="side">All sides of the rhombus are equal.</param>
        /// <param name="rhombusAngles">h.</param>
        public Rhombus(double side, double[] rhombusAngles)
            : base(new double[] { side, side, side, side }, rhombusAngles)
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
            res = Math.Pow(this.Sides[0], 2) * Math.Sin(this.Angles[0]);
            return res;
        }
    }
}
