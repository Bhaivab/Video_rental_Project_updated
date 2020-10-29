using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_Project2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_Project2.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj = new Form1();
            int y = obj.chkSampleVideo(1);
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