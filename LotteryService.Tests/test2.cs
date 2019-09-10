using NUnit.Framework;
using LotteryService;

namespace LotteryTests
{
    public class TestClass2
    {
        Class1 twoSortedNums = new Class1();

        [Test]
        public void ReturnTwoNumSorted()
        {
            int[] lotteryNums2 = new int[] { 20, 15 };
            var output = twoSortedNums.SortNumbers(lotteryNums2);
            int[] fakeLottery = new int[] { 30, 40, 10 };
            Assert.AreEqual(lotteryNums2, output);
        }
    }
}

