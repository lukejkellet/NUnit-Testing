using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    [TestFixture]
    internal class Triangle
    {
        [TestCase(4.0, 5.0, 10.0)]
        public void AreaTest(double length, double width, double expectedValue)
        {
            //Calculate the area of a Triangle.
            Calc c = new Calc();
            double actualValue = (length * width) / 2;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestCase(4.0, 5.0, 3.0, 12.0)]
        public void PerimeterTest(double length, double width, double height, double expectedValue)
        {
            //Calculate perimeter
            Calc c = new Calc();
            double actualValue = length + width + height;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
