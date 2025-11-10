using Tyuiu.NesterenkoVV.Sprint4.Task0.V4.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = new int[] {5, 3, 7, 1, 3, 9, 8, 7, 9 ,4};
            int wait = 32;
            var res = ds.GetMultEvenArrEl(nums);
            Assert.AreEqual(wait, res);

        }
    }
}
