using System;

namespace MindboxFigures
{
    /// <summary>
    /// Simple 2-d circle only differing from other by its radius. Immutable.
    /// </summary>
    public class Circle : GeometricFigure, IMeasurableAreaFigure
    {
        public Circle(float radius)
        {
            Radius = radius;
            Area = (float)Math.PI * radius * radius;
        }
        public float Radius { get; }

        /// <summary>
        /// Area of the figure calculated on construction. Will never change.
        /// </summary>
        public float Area { get; }
    }
    
}
