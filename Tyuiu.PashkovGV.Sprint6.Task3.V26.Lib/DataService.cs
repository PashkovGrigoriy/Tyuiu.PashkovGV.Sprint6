using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PashkovGV.Sprint6.Task3.V26.Lib
{
    public class DataService : ISprint6Task3V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            int rowIndex = 2;

            if (rowIndex < r)
            {
                for (int col = 0; col < c; col++)
                {
                    if (matrix[rowIndex, col] % 2 == 0)
                    {
                        matrix[rowIndex, col] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
