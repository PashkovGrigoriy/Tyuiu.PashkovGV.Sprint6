using Tyuiu.PashkovGV.Sprint6.Task0.V6.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            double y = 0.866;
            var res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(y, res);
        }
    }
}
