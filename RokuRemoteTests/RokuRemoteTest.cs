using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RokuRemoteTests
{
    [TestClass]
    public class RokuRemoteTest
    {
        RokuAPI.RokuControl _r = new RokuAPI.RokuControl("192.168.1.13", "8060");
        [TestMethod]
        public void Test_GetApps()
        {
            Assert.IsTrue(_r.Apps.Count > 0);
        }
    }
}
