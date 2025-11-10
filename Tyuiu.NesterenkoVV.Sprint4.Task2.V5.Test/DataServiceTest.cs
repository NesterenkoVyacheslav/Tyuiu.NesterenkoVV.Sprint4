using Tyuiu.NesterenkoVV.Sprint4.Task2.V5.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = new int[] { 1, 2, 3, 4 };
            int wait = 8;
            var res = ds.Calculate(nums);
            Assert.AreEqual(wait, res);
        }
    }
}
