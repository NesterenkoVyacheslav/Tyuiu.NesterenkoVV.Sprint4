using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NesterenkoVV.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] matrix)
        {
            int min = int.MaxValue;
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (j == 1 & matrix[i, j] < min)
                    {
                    min = matrix[i, j];
                    }
                }
            }
            return min;
        }
    }
}
