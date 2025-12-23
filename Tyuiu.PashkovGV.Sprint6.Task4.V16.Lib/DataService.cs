using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task4.V16.Lib
{
    public class DataService : ISprint6Task4V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] res = new double[l];
            int j = 0;
            for (int i = startValue; i <= stopValue; i++)
            {

                double z = Math.Round(((Math.Cos(i)/(i - 0.4))+(Math.Sin(i)* (8*i))+2), 2);
                if ((i - 0.4) != 0)
                {
                    res[j] = z;
                    j++;
                }
                else
                {
                    res[j] = 0;
                    j++;
                }
            }
            return res;
        }
    }
}
