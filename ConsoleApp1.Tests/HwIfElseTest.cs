using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    class HwIfElseTest
    {

        [TestCase(2, 2, 4)]
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, -1)]
        public void Task1Test(int a, int b, int exeptected)
        {
            int actual = HwIfElse.Task1(a, b);
            Assert.AreEqual(exeptected, actual);
        }


        [TestCase(1, 1, "I")]
        [TestCase(1, -1, "IV")]
        [TestCase(-1, 1, "II")]
        [TestCase(-1, -1, "III")]
        public void Task2Test(int x, int y, string exeptected)
        {
            string actual = HwIfElse.Task2(x, y);
            Assert.AreEqual(exeptected, actual);
        }


        [TestCase(1,2,3, "1 2 3")]
        [TestCase(10,9,8, "8 9 10")]
        [TestCase(0,1,-1, "-1 0 1")]
        public void Task3Test(int a, int b,int c, string exeptected)
        {
            string actual = HwIfElse.Task3(a,b,c);
            Assert.AreEqual(exeptected, actual);
        }



        [TestCase(4, 12, 5, new double[] { -2.5, -0.5 })]
        [TestCase(1, 6, 9, new double[] { -3 })]       //?????????????
        [TestCase(1, -10, 21, new double[] {3,7})]
        public void Task4Test(double a, double b, double c, double[] exeptected)
        {
            double[] actual = HwIfElse.Task4(a, b, c);
            Assert.AreEqual(exeptected, actual);
        }



        [TestCase(11,  "одинадцать")]
        [TestCase(50,  "пятьдесят")]
        [TestCase(66,  "шестьдесят шесть")]
        public void Task5Test(int a, string exeptected)
        {
            string actual = HwIfElse.Task5(a);
            Assert.AreEqual(exeptected, actual);
        }
    }
}