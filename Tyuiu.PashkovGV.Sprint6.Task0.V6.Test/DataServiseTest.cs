using Tyuiu.PashkovGV.Sprint6.Task0.V6.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double y = 0.866;
            var res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(y, res);
        }
    }
}
