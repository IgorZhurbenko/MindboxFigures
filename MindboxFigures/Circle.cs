using System;

namespace MindboxFigures
{
    public class Circle : GeometricFigure, IMeasurableAreaFigure
    {
        public Circle(float radius)
        {
            Radius = radius;
            Area = (float)Math.PI * radius * radius;
        }
        public float Radius { get; }

        public float Area { get; }
    }
    
}
