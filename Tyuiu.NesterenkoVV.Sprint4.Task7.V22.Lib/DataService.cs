using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NesterenkoVV.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int p = 1;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    matrix[i, j] = int.Parse(value[i*3+j].ToString());
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j]%2==0)
                    {
                        p*=matrix[i, j];
                    }
                }
            }
            return p;
        }
    }
}
