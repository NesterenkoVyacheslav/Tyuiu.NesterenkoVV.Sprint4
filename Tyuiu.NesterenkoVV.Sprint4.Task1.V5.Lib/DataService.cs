using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NesterenkoVV.Sprint4.Task1.V5.Lib
{
    public class DataService : ISprint4Task1V5
    {
        public int Calculate(int[] array)
        {
            int p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) 
                {
                    p += array[i];
                }
            }
            return p;
        }
    }
}
