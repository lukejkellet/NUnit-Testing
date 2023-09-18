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
        [Test]
        public void AreaTest()
        {
            //Calculate the area of a rectangle.
            Calc c = new Calc();
            double length = 4.0;
            double width = 5.0;
            double expectedValue = 20.0;
            double actualValue = length * width;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void PerimeterTest()
        {
            //Calculate perimeter
            Calc c = new Calc();
            double length = 4.0;
            double width = 5.0;
            double expectedValue = 18.0;
            double actualValue = 2 * (length + width);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
