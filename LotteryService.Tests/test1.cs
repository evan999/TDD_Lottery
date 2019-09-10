using NUnit.Framework;
using LotteryService;

namespace TestOne

{
    public class TestClass1
    {
        Class1 _OneNumSorted = new Class1();

        [Test]
        public void ReturnOneNumSorted()
        {
            int[] lotteryNums1 = new int[] { 25 };
            var output = _OneNumSorted.SortNumbers(lotteryNums1);
            Assert.AreEqual(lotteryNums1, output);

        }
    }

}

