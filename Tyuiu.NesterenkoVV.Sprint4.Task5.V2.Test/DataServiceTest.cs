using Tyuiu.NesterenkoVV.Sprint4.Task5.V2.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] nums = new int[5, 5] { { 1, 2, -2, 3, -10 }, { 1, 2, -2, 3, -10 }, { 1, 2, -2, 3, -10 }, { 1, 2, -2, 3, -10 }, { 1, 2, -2, 3, -10 } };
            int wait = 10;
            var res = ds.Calculate(nums);
            Assert.AreEqual(wait, res);
        }
    }
}
