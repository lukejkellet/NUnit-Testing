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
        [Test]
        public void AreaTest()
        {
            //Calculate the area of a Triangle.
            Calc c = new Calc();
            double length = 4.0;
            double width = 5.0;
            double expectedValue = 10.0;
            double actualValue = (length * width) / 2;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void PerimeterTest()
        {
            //Calculate perimeter
            Calc c = new Calc();
            double length = 4.0;
            double width = 5.0;
            double height = 3.0;
            double expectedValue = 12.0;
            double actualValue = length + width + height;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
