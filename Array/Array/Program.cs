using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("СУММИРОВАНИЕ ЧЁТНЫХ ЧИСЕЛ В МАССИВЕ");
            Console.WriteLine("Введите число элементов массива:");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            int[] x = new int[n]; //объявление и инициализация массива x длиной n
            int y = 0; //объявление и инициализация переменной y для дальнейшего сложения чётных чисел
            Random rnd = new Random(); // объявление и инициализация переменной rnd как случайное число
            Console.WriteLine("Заполнить массив вручную y/n");
            switch (Console.ReadLine())
            {
                case "y":
                    {
                        for (int i = 0; i < x.Length; i++)
                        {
                            Console.WriteLine("Введите {0} элемент", i);
                            x[i] = int.Parse(Console.ReadLine());
                            Even_check(x[i], y, out y); //Вызов  метода, осуществляющего проверку на чётность и сложение
                        }
                    }
                    break;
                case "n":
                    {
                        Console.WriteLine("Массив заполнен случайными числами в диапазоне 0 - 20:");
                        for (int i = 0; i < x.Length; i++)
                        {
                            x[i] = rnd.Next(0, 20); //заполнение массива случайными числами в диапазоне 0 - 20
                            Console.WriteLine("\t" + x[i]); // вывод получившегося массива
                            Even_check(x[i], y, out y);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
            Console.WriteLine("\t\t Сумма={0}", y); // вывод суммы чётных элементов
        }
        static void Even_check(int n, int p, out int m) //Метод проверки на чётность и сложения чётных чисел
        {
            m = p; 
            if (n % 2 == 0) //проверка значения элемента массива на чётность
            {
                m = p + n; //сложение чётных элементов
            }
        }

    }
}
