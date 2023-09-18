using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Testing
{
    [TestFixture]
    internal class Circle
    {
        [TestCase(4.0, 50.26548245743669)]
        public void AreaTest(double radius, double expectedValue)
        {
            //Calculate the area of a circle.
            Calc c = new Calc();
            double actualValue = radius * radius * Math.PI;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(4.0, 25.132741228718345)]
        public void PerimeterTest(double radius, double expectedValue)
        {
            //Calculate perimeter
            Calc c = new Calc();
            double actualValue = 2 * radius * Math.PI;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
