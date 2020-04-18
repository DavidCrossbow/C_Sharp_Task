using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Calculation(); // Зацикливание выполнения метода, для возможности проведения нескольких вычислений
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void Calculation()
        {
            Console.Clear();
            Console.WriteLine("КАЛЬКУЛЯТОР\n");// здесь и далее ставлю \n для добавления пустой строки
            Console.WriteLine("Доступные операции:\n");
            Console.WriteLine("Сложение:\t +");
            Console.WriteLine("Вычитание:\t -");
            Console.WriteLine("Умножение:\t *");
            Console.WriteLine("Деление:\t /");
            double n1, n2, nr;
            nr = 0;
            Number_ins(out n1);
            Console.Write("\nВыберите операцию из перечисленных выше: ");
            switch (Console.ReadLine())
            {
                case "+":
                    {
                        Number_ins(out n2); 
                        nr = n1 + n2;
                    }
                    break;
                case "-":
                    {
                        Number_ins(out n2);
                        nr = n1 - n2;
                    }
                    break;
                case "*":
                    {
                        Number_ins(out n2);
                        nr = n1 * n2; 
                    }
                    break;
                case "/":
                    {
                        Number_ins(out n2);
                        if (n2==0)
                        {
                            Console.WriteLine("\nДеление на ноль невозможно");
                        }
                        else
                        {
                            nr = n1 / n2; 
                        }
                        
                    }
                    break;
                default:
                    Console.WriteLine("\nНЕВЕРНЫЙ ВВОД");
                    break;
            }
            Console.WriteLine($"\nРезультат операции: {nr}\n");
            Console.WriteLine("Нажмите любую клавишу для продолжения. Выход - ESC.");

        }
        static void Number_ins(out double x)
        {
            Console.Write("\nВведите число: ");
            x = 0;  
            try
            {
                x = double.Parse(Console.ReadLine());
                
            }
            catch (FormatException)
            {
                Console.WriteLine("\nНЕВЕРНЫЙ ВВОД");
                return;
            }
        }
    }
}
