using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NesterenkoVV.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
