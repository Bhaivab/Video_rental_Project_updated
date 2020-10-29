using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_Project2;

namespace Video_rental_Project2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 obj = new Form1();
            int y = obj.chkMemberBooking(1);
            if (y == 1)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
    }
}
