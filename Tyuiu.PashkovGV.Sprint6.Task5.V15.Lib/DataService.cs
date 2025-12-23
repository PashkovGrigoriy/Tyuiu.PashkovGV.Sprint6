using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            
            using ( StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] na = new double[len];
            int i = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while (( line = sr.ReadLine()) != null)
                {
                    na[i]= Convert.ToDouble(line);
                    i++;
                }
            }
            na = na.Where(x => x > 2 && x < 7).ToArray();
            return na;  
        }
    }
}
