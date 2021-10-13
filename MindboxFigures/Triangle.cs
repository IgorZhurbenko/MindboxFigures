using System;
using System.Collections.Generic;
using System.Linq;

namespace MindboxFigures
{
    /// <summary>
    /// 2-d triangle defined by 3 sides given at constructing. Immutable.
    /// </summary>
    public class Triangle : GeometricFigure, IMeasurableAreaFigure
    {
        public Triangle(float side1, float side2, float side3)
        {
            AcceptSides(new[] { side1, side2, side3 });
        }
        public Triangle(IEnumerable<float> sides)
        {
            AcceptSides(sides);
        }

        private void AcceptSides(IEnumerable<float> sides)
        {
            // Done to create a copy of input parameter, so that the inner sides of the figure array could not be changed from outer code.
            Sides = sides.ToArray();

            if (Sides.Any(s1 => Sides.Except(new[] { s1 }).Sum() <= s1))
            {
                throw new ArgumentException("Cannot create a triangle with one side grater than sum of two others.");
            }

            this.Sides = Sides;
            Hypotenuse = Sides.Where(s1 => Sides.Except(new[] { s1 }).Select(s2 => s2 * s2).Sum() == s1 * s1).FirstOrDefault();

            IsSquareTriangle = Hypotenuse != default(float);

            if (IsSquareTriangle)
            {
                Area = Sides.Where(s=>s != Hypotenuse).Aggregate((float)1, (inp, side) => inp * side) / 2;
            }
            else
            {
                float halfPerimeter = Sides.Sum() / 2;
                float hp = halfPerimeter;
                Area = (float)Math.Sqrt(hp * (hp - Sides[0]) * (hp - Sides[1]) * (hp - Sides[2]));
            }
        }
        public float[] Sides { get; private set; }
        public bool IsSquareTriangle { get; private set; }

        /// <summary>
        /// Area of the figure calculated on construction. Will never change.
        /// </summary>
        public float Area { get; private set; }
        public float Hypotenuse { get; private set; }
    }
}
