using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EKZ;

namespace TestEKZ
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum2_2()
        {
            EKZ.matmodel prog = new EKZ.matmodel();
            prog.minus(10, 2);
        }
    }
}
