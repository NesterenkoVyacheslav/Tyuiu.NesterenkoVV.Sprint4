using Tyuiu.NesterenkoVV.Sprint4.Task7.V22.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Нестеренко В. В. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПБ-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 695324951753684. Преобразуйте ее      *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string str = "695324951753684";
            int rows = 5;
            int coll = 3;
            var res = ds.Calculate(rows, coll, str);
            Console.WriteLine(res);
        }
    }
}
