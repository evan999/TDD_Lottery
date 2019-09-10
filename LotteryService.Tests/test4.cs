using NUnit.Framework;
using LotteryService;

namespace LotteryTests
{
    public class TestClass4
    {

        Class1 tenSortedNumbers = new Class1();
        [Test]
        public void ReturnTenNumSorted()
        {
            int[] lotteryNums10 = new int[] { 120, 45, 60, 90, 13, 0, 94, 78, 42, 51 };
            int[] fakeLottery = new int[] { 5, 90 };
            var output = tenSortedNumbers.SortNumbers(lotteryNums10);
            Assert.AreEqual(lotteryNums10, output);
        }
    }
}

