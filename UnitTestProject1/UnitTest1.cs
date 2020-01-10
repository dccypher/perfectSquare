using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void digitalSumTest()
        {
            //edge test
            int value = squared.digitalSum(1);
            //Recusion test
            int value2 = squared.digitalSum(753424);
            //random test
            int value3 = squared.digitalSum(14);

            Assert.AreEqual(1, value, "Digital root doesn't add up correctly");
            Assert.AreEqual(7, value2, "Digital root doesn't add up correctly");
            Assert.AreEqual(5, value3, "Digital root doesn't add up correctly");
        }
        [TestMethod]
        public void LastDigitTest()
        {
            //loop test
            int value = squared.lastDigit(14);
            //edge low number test
            int value2 = squared.lastDigit(1);
            //high number test
            int value3 = squared.lastDigit(95424);

            Assert.AreEqual(4, value, "Last digit doesn't match");
            Assert.AreEqual(1, value2, "Last digit doesn't match");
            Assert.AreEqual(4, value3, "Last digit doesn't match");
        }
        [TestMethod]
        public void PerfectSquareTest()
        {
            //low test
            bool value = squared.isPerfectSquare(4);
            //edge test
            bool value2 = squared.isPerfectSquare(1);
            //not perfect square test
            bool value3 = squared.isPerfectSquare(12);
            //high number perfect square test
            bool value4 = squared.isPerfectSquare(753424);
            //high number not perfect square test
            bool value5 = squared.isPerfectSquare(753424);


            Assert.AreEqual(true, value, "Is perfect square");
            Assert.AreEqual(true, value2, "Is Perfect Square");
            Assert.AreEqual(false, value3, "Is Not Perfect Square");
            Assert.AreEqual(true, value4,"Is Not Perfect Square");
            Assert.AreEqual(true, value5, "Is Perfect Square");

        }
    }
}
