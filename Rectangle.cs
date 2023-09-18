using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    [TestFixture]
    internal class Rectangle
    {
        [TestCase(4.0, 5.0, 20.0)]
        public void AreaTest(double length, double width, double expectedValue)
        {
            //Calculate the area of a rectangle.
            Calc c = new Calc();
            double actualValue = length * width;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestCase(4.0, 5.0, 18.0)]
        public void PerimeterTest(double length, double width, double expectedValue)
        {
            //Calculate perimeter
            Calc c = new Calc();
            double actualValue = 2 * (length + width);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
