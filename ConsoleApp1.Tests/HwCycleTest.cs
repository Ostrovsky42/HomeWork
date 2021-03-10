using NUnit.Framework;


namespace ConsoleApp1.Tests
{
    class HwCycleTest
    {



        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 9)]
        [TestCase(10, 4, 10000)]
        public void Task1Test(int a, int b, int expected)
        {

            int actual = HwCycle.Task1(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(300, new int[] { 300, 600, 900 })]
        public void Task2Test(int a, int[] expected)
        {
            int[] actual = HwCycle.Task2(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(10, 4)]
        [TestCase(1, 1)]
        [TestCase(30, 6)]
        public void Task3Test(int a, int expected)
        {
            int actual = HwCycle.Task3(a);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(10, 5)]
        [TestCase(50, 25)]
        [TestCase(13, 1)]
        public void Task4Test(int a, int expected)
        {
            int actual = HwCycle.Task4(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 8, 7)]
        [TestCase(71, 13, 378)]
        [TestCase(27, 3, 42)]
        public void Task5Test(int a, int b, int expected)
        {
            int actual = HwCycle.Task5(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 3)]
        public void Task6Test(int n, int expected)
        {
            int actual = HwCycle.Task6(n);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(5, 10, 5)]
        [TestCase(4, 161, 1)]
        [TestCase(33, 99, 33)]
        public void Task7Test(int a, int b, int expected)
        {
            int actual = HwCycle.Task7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 2)]
        [TestCase(1000, 10)]
        [TestCase(27, 3)]
        public void Task8Test(int a, int expected)
        {
            int actual = HwCycle.Task8(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(232, 1)]
        [TestCase(666, 0)]
        [TestCase(158, 2)]
        public void Task9Test(int a, int expected)
        {
            int actual = HwCycle.Task9(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 21)]
        [TestCase(1488, 8841)]
        [TestCase(1997, 7991)]
        public void Task10Test(int a, int expected)
        {
            int actual = HwCycle.Task10(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, new int[] {2,4,6})]
        [TestCase(3, new int[] {2})]
        [TestCase(14, new int[] { 2,4,6,8,12})]
        public void Task11Test(int a, int[] expected)
        {
            int[] actual = HwCycle.Task11(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 356, "ДА")]
        [TestCase(50, 99, "НЕТ")]
        [TestCase(10, 203, "ДА")]
        public void Task12Test(int a, int b, string exeptected)
        {
            string actual = HwCycle.Task12(a, b);
            Assert.AreEqual(exeptected, actual);
        }
    }
}