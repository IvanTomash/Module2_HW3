using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    /// <summary>
    /// m.
    /// </summary>
    internal interface IShapeable
    {
        /// <summary>
        /// Calculate a perimeter of the shape.
        /// </summary>
        /// <returns>Perimeter in centimeters.</returns>
        public double Perimeter();

        /// <summary>
        /// Calculate an area of the shape.
        /// </summary>
        /// <returns>Area in square centimeters.</returns>
        public double Area();

        /// <summary>
        /// Show info about the shape.
        /// </summary>
        public void ShowInfo();
    }
}
