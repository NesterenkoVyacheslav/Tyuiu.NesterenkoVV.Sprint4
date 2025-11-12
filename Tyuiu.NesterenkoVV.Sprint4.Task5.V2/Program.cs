using Tyuiu.NesterenkoVV.Sprint4.Task5.V2.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Нестеренко В. В. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  двумерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПБ-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан  двумерный целочисленный массив 5 на 5 элементов                    *");
            Console.WriteLine("* случайными в диапазоне от -7 до 5 подсчитать кол-во отрицательных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Random rn = new Random();
            int[,] nums = new int[5, 5];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rn.Next(-7, 5);
                }
            }
            Console.WriteLine("Массив");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0;j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.Calculate(nums);
            Console.WriteLine(res);
        }
    }
}
