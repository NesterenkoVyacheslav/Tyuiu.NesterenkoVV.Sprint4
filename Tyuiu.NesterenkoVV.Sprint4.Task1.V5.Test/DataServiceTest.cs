using Tyuiu.NesterenkoVV.Sprint4.Task1.V5.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int[] nums = new int[] { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int wait = 56;
            var res = ds.Calculate(nums);
            Assert.AreEqual(wait, res);
            
        }
    }
}
