using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] res = new double[l];
            int j = 0;
            for (int i = startValue; i <= stopValue; i++)
            {

                double z = Math.Round((Math.Cos(i) + (Math.Sin(i) / (2 - (2 * i)))) - (4 * i), 2);
                if (2 - (2 * i) != 0)
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
