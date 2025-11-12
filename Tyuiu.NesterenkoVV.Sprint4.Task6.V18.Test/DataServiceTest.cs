using Tyuiu.NesterenkoVV.Sprint4.Task6.V18.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] an = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            string[] wait = { "Попугай", "Черепаха" };
            var res = ds.Calculate(an);
            CollectionAssert.AreEquivalent(res, wait);
        }
    }
}
