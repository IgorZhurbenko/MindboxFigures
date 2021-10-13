using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxFigures;

namespace Testing
{
    [TestClass]
    public class CheckCalculations
    {
        [TestMethod]
        public void CheckForTriangleCreationError()
        {
            var triangle = new Triangle(1,2,3);

        }
    }
}
