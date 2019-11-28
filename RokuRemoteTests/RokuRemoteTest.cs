using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RokuRemoteTests
{
    [TestClass]
    public class RokuRemoteTest
    {
        [TestMethod]
        public void Test_GetApps()
        {
            var _r = new RokuAPI.RokuControl("192.168.1.13", "8060");
            Assert.IsTrue(_r.Apps.Count > 0);
        }
    }
}
