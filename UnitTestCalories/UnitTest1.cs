using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using POE_PART_1_ST10082757_GROUP_3_PROG6221;

namespace UnitTestCalories
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]      

        public void TestMethod1()
        {       
            COOKBOOK cook = new COOKBOOK();

            double cal = 350 ;
            cook.TOTCAL(cal);

            //Assert.true

        }
    }
}
