using NUnit.Framework;
using LotteryService;

namespace LotteryTests
{
    public class TestClass3
    {
        Class1 threeSortedNumbers = new Class1();

        [Test]
        public void ReturnThreeNumSorted()
        {
            int[] lotteryNums3 = new int[] { 120, 45, 60 };
            var output = threeSortedNumbers.SortNumbers(lotteryNums3);
            Assert.AreEqual(lotteryNums3, output);
        }
    }
}

