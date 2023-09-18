using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    [TestFixture]
    internal class Circle
    {
        [Test]
        public void AreaTest()
        {
            //Calculate the area of a circle.
            Calc c = new Calc();
            double radius = 4.0;
            double expectedValue = 50.26548245743669;
            double actualValue = radius * radius * Math.PI;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PerimeterTest()
        {
            //Calculate perimeter
            Calc c = new Calc();
            double radius = 4.0;
            double expectedValue = 25.132741228718345;
            double actualValue = 2 * radius * Math.PI;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
