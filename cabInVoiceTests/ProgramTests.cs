using Microsoft.VisualStudio.TestTools.UnitTesting;
using cabInVoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabInVoice.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void totalFairTest()
        {
            double distance = 2.0;
            int time = 5;
            double expexted = 20;
            double actual=Program.totalFair(distance,time);
            Assert.AreEqual(expexted,actual);
        }
        [TestMethod()]
        public void MultipleRidesTest()
        {
            double[] dist = { 3, 5 };
            int[] time = { 60, 120 };
            double expected = 260.00;
            int rides = 2;
            double actual = Multirides.MultipleRides(rides, dist, time);
            Assert.AreEqual(expected, actual);

        }
    }
}