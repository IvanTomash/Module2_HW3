using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    /// <summary>
    /// Triangle.
    /// </summary>
    internal class Triangle : IShapeable
    {
        private double[] sides = new double[3];
        private double[] angles = new double[3];

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        public Triangle()
        {
            for (int i = 0; i < this.sides.Length; i++)
            {
                this.sides[i] = 1;
                this.angles[i] = 60;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sides">4 sides of the Parallelogram.</param>
        /// <param name="angles">4 angles of the Parallelogram.</param>
        public Triangle(double[] sides, double[] angles)
        {
            double totalAngle = 0;
            if (angles != null && angles.Length == 3)
            {
                for (int i = 0; i < angles.Length; i++)
                {
                    totalAngle += angles[i];
                }
            }

            if (sides != null && sides.Length == 3 &&
                totalAngle == 180)
            {
                this.sides = sides;
                this.angles = angles;
            }
            else
            {
                for (int i = 0; i < this.sides.Length; i++)
                {
                    this.sides[i] = 1;
                    this.angles[i] = 90;
                }
            }
        }

        /// <summary>
        /// Gets sides.
        /// </summary>
        protected double[] Sides
        {
            get { return this.sides; }
        }

        /// <summary>
        /// Gets angles.
        /// </summary>
        protected double[] Angles
        {
            get { return this.angles; }
        }

        /// <summary>
        /// Calculate a area of the triangle.
        /// </summary>
        /// <returns>Area in square centimeters.</returns>
        public double Area()
        {
            double res = 0;
            res = 0.5 * this.sides[0] * this.sides[1] * Math.Sin(this.angles[0]);
            return res;
        }

        /// <summary>
        /// Calculate a perimeter of the triangle.
        /// </summary>
        /// <returns>Perimeter in centimeters.</returns>
        public double Perimeter()
        {
            double res = 0;
            for (int i = 0; i < this.sides.Length; i++)
            {
                res += this.sides[i];
            }

            return res;
        }

        /// <summary>
        /// Show info about the shape.
        /// </summary>
        public void ShowInfo()
        {
            string output = "Sides: ";
            for (int i = 0; i < this.sides.Length; i++)
            {
                output += this.sides[i] + " , ";
            }

            output += "\n" + "Angles: ";
            for (int i = 0; i < this.angles.Length; i++)
            {
                output += this.angles[i] + " , ";
            }

            Console.WriteLine(output);
        }
    }
}
