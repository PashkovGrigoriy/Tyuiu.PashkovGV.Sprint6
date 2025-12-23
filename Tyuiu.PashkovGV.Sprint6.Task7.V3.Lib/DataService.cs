using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);

                    // Если первый столбец (j=0) и число чётное
                    if (j == 0 && matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = -1;
                    }
                }
            }

            return matrix;
        }
    }
}
