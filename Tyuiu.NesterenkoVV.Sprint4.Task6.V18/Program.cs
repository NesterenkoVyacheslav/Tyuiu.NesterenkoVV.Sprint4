using Tyuiu.NesterenkoVV.Sprint4.Task6.V18.Lib;
namespace Tyuiu.NesterenkoVV.Sprint4.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Нестеренко В. В. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПБ-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Собака, Кошка, Кролик, Хомяк, Попугай,     *");
            Console.WriteLine("* Рыбка, Черепаха] используя класс Array, выведите элементы массива, длина*");
            Console.WriteLine("* которых больше 6 символов                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] an = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            var p = ds.Calculate(an);
            for (int i = 0; i < p.Length; i++)
            {
                Console.Write(p[i] + " ");
            }
        }
    }
}
