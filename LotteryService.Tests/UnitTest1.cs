using NUnit.Framework;
using LotteryService;

namespace LotteryTests
{
    public class Tests
    {
        Class1 _testService = new Class1();
        [Test]
        public void ReturnArray()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0],output);
        }
    }
}