using System;
using System.Security.AccessControl;
using EddyNewHome.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EddyNewHome.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expectedIp = "210.119.12.77";

            string actualIp = Commons.GetIpAddress();
            Assert.AreEqual(expectedIp, actualIp);
        }
    }
}
