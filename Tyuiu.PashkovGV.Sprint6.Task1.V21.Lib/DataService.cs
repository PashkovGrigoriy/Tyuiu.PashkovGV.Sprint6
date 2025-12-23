using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // startValue = -5;
            // stopValue = 5;
            int l = stopValue - startValue + 1 ;
            double[] res = new double[l];
            int j = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                
                double z = Math.Round((Math.Cos(i) + (Math.Sin(i) / (2 - (2 * i)))) - (4 * i), 2);
                if (2 - ( 2 * i ) != 0)
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
