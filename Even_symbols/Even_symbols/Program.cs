using System;

namespace Even_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВЫВОД ЧЁТНЫХ СИМВОЛОВ ИЗ СТРОКИ");
            Console.WriteLine("Введите строку и нажмите Enter");
            String str = Console.ReadLine();
            char[] x = str.ToCharArray(); // преобразование строки в массив, первый символ строки стал нулевым элементом массива

            for (int i = 1; i < x.Length; i = i + 2) //  элементы массива выбираются через один, начиная с первого элемента (второй символ в строке) 
            {
                Console.Write($"{x[i]}"); // вывод элементов строкой
            }
            Console.WriteLine();
        }
    }
}
