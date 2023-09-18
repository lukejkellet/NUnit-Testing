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
    internal class CalcTest
    {
        [TestCase(4.0, 5.0, 9.0)]
        public void AddTest(double x, double y, double expectedValue)
        {
            Calc c = new Calc();
            double actualValue = c.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestCase(4.0, 5.0, -1.0)]
        public void SubtractTest(double x, double y, double expectedValue)
        {
            Calc c = new Calc();
            double actualValue = c.Subtract(x, y);
            Assert.AreEqual(expectedValue, actualValue); //will return an error in testing.
        }
    }
}
