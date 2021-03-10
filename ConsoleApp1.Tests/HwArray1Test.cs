using NUnit.Framework;
namespace ConsoleApp1.Tests
{
    class HwArray1Test
    {
        [TestCase(new int[] { 1, 3, 5, 6 }, 1)]
        [TestCase(new int[] { 4, 7, 3, 1 }, 1)]
        [TestCase(new int[] { -4, 5, 1, 0 }, -4)]
        public void Task1Test(int[] array, int expected)
        {
            int actual = HwArray1.Task1(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 6 }, 6)]
        [TestCase(new int[] { 4, 7, 3, 1 }, 7)]
        [TestCase(new int[] { -4, 5, 1, 0 }, 5)]
        public void Task2Test(int[] array, int expected)
        {
            int actual = HwArray1.Task2(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 6 }, 0)]
        [TestCase(new int[] { 4, 7, 3, 1 }, 3)]
        [TestCase(new int[] { -4, 5, 1, 0 }, 0)]
        public void Task3Test(int[] array, int expected)
        {
            int actual = HwArray1.Task3(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 3, 5, 6 }, 3)]
        [TestCase(new int[] { 4, 7, 3, 1 }, 1)]
        [TestCase(new int[] { -4, 5, 1, 0 }, 1)]
        public void Task4Test(int[] array, int expected)
        {
            int actual = HwArray1.Task4(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 6 }, 9)]
        [TestCase(new int[] { 4, 7, 3, 1 }, 8)]
        [TestCase(new int[] { -4, 5, 1, 0 }, 5)]
        public void Task5Test(int[] array, int expected)
        {
            int actual = HwArray1.Task5(array);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 3, 5, 6, 7 }, new int[] { 7, 6, 5, 3, 1 })]
        [TestCase(new int[] { 4, 7, 3, 1 }, new int[] { 1, 3, 7, 4 })]
        [TestCase(new int[] { -4, 5, 0 }, new int[] { 0, 5, -4 })]
        public void Task6Test(int[] array, int[] expected)
        {
            int[] actual = HwArray1.Task6(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 6 }, 3)]
        [TestCase(new int[] { 4, 7, 3, 1 }, 3)]
        [TestCase(new int[] { -4, 5, 1, 0 }, 2)]
        public void Task7Test(int[] array, int expected)
        {
            int actual = HwArray1.Task7(array);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 3, 5, 6, 7 }, new int[] { 6, 7, 5, 1, 3 })]
        [TestCase(new int[] { 4, 7, 3, 1 }, new int[] { 3, 1, 4, 7 })]
        [TestCase(new int[] { -4, 5, 0 }, new int[] { 0, 5, -4 })]
        public void Task8Test(int[] array, int[] expected)
        {
            int[] actual = HwArray1.Task8(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 6, 5, 3, 1 }, new int[] { 1, 3, 5, 6, 7 })]
        [TestCase(new int[] { 4, 7, 3, 1 }, new int[] { 1, 3, 4, 7 })]
        [TestCase(new int[] { -4, 5, 0 }, new int[] { -4, 0, 5 })]
        public void Task9Test(int[] array, int[] expected)
        {
            int[] actual = HwArray1.Task9(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 3, 5, 6, 7 }, new int[] { 7, 6, 5, 3, 1 })]
        [TestCase(new int[] { 4, 7, 3, 1 }, new int[] { 7, 4, 3, 1 })]
        [TestCase(new int[] { -4, 5, 0 }, new int[] { 5, 0, -4 })]
        public void Task10Test(int[] array, int[] expected)
        {
            int[] actual = HwArray1.Task10(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
