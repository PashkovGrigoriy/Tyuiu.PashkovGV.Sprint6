using Tyuiu.PashkovGV.Sprint6.Task1.V21.Lib;
namespace Tyuiu.PashkovGV.Sprint6.Task1.V21.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string e;
            int x = -5;
            int y = 5;
            int w = y - x + 1;
            double[] ww;
            ww = new double[w];
            ww[0] = 20.36;
            ww[1] = 15.42;
            ww[2] = 10.99;
            ww[3] = 7.43;
            ww[4] = 4.33;
            ww[5] = 1.00;
            ww[6] = 0.00;
            ww[7] = -8.87;
            ww[8] = -13.03;
            ww[9] = -16.53;
            double[] res;
            ww[10] = -19.60;
            res = new double[w];
            res = ds.GetMassFunction(x, y);
            CollectionAssert.AreEqual(ww, res);
        }
    }
}
