using Tyuiu.NesterenkoVV.Sprint4.Task7.V22.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "695324951753684";
            int rows = 5;
            int coll = 3;
            var res = ds.Calculate(rows, coll, str);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}
