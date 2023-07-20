using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{
    /// <summary>
    /// Entry point in program.
    /// </summary>
    internal class Starter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Starter"/> class.
        /// </summary>
        public Starter()
        {
        }

        /// <summary>
        /// Contain main logic.
        /// </summary>
        public void Run()
        {
            IShapeable[] shapes = new IShapeable[]
            {
                new Triangle(new double[] { 3, 4, 5 }, new double[] { 90, 30, 60 }),
                new Circle(5),
                new Square(4),
                new Rhombus(2, new double[] { 60, 120, 60, 120 }),
                new Square(5),
            };

            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    shape.ShowInfo();
                    Console.WriteLine("Circle perimeter: " + shape.Perimeter());
                    Console.WriteLine("Circle area: " + shape.Area());
                }
                else if (shape is Triangle)
                {
                    shape.ShowInfo();
                    Console.WriteLine("Triangle perimeter: " + shape.Perimeter());
                    Console.WriteLine("Triangle area: " + shape.Area());
                }
                else if (shape is Square)
                {
                    shape.ShowInfo();
                    Console.WriteLine("Square perimeter: " + shape.Perimeter());
                    Console.WriteLine("Square area: " + shape.Area());
                }
                else if (shape is Rhombus)
                {
                    shape.ShowInfo();
                    Console.WriteLine("Rhombus perimeter: " + shape.Perimeter());
                    Console.WriteLine("Rhombus area: " + shape.Area());
                }
            }
        }
    }
}
