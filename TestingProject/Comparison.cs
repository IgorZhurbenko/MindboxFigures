using System;

namespace TestingProject
{
    public static class Comparison
    {
        const float _equalityCriterion = 0.001f;
        public static bool ApproximatelyEqual(this float first, float second)
        {
            return Math.Abs(first - second) < _equalityCriterion;
        }
    }
}