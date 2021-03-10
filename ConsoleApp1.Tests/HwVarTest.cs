using NUnit.Framework;

namespace ConsoleApp1.Tests
{
    public class HwVarTests
    {
        [TestCase(0, 1, 1)]
        [TestCase(1, 10, 11.6)]
        [TestCase(10, 0, -5)]
        public void Task1Test(double a, double b, double expected)
        {

            double actual = HwVar.Task1(a, b);
            Assert.AreEqual(expected, actual, 0.1);
        }


        [TestCase(1, 2, new int[] { 2, 1 })]
        [TestCase(0, 1, new int[] { 1, 0 })]
        [TestCase(100, 200, new int[] { 200, 100 })]
        public void Task2Test(int a, int b, int[] expected)
        {
            int[] actual = HwVar.Task2(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(10, 2, new int[] { 5, 0 })]
        [TestCase(12, 5, new int[] { 2, 2 })]
        [TestCase(51, 10, new int[] { 5, 1 })]
        public void Task3Test(int a, int b, int[] expected)
        {
            int[] actual = HwVar.Task3(a, b);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(1, 2, 3,1)]
        [TestCase(3, 2, 1, -0.33)]
        [TestCase(10, 200, 300,10)]
        public void Task4Test(int a, int b, int c,double  expected)
        {
            double actual = HwVar.Task4(a, b, c);
            Assert.AreEqual(expected, actual, 0.01);
        }



        [TestCase(0,0,1,1, "y=1x+0" )]
        [TestCase(1,1,0,0,"y=1x+0" )]
        [TestCase(51,10,20,40, "y=-0,97x+59,35") ]
        public void Task5Test(int x1,  int y1, int x2, int y2, string expected)
        {
            string actual = HwVar.Task5(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }


    }
}