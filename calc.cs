using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag;
            do
            {
                double a;
                double b;
                string oper;
                double answer;
                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите текущую операцию (+, -, *, /):");
                oper = Convert.ToString(Console.ReadLine());
                if (oper == "+")
                {
                    answer = a + b;
                    Console.WriteLine("Ответ: " + a + " + " + b + " = " + answer);
                }
                else if (oper == "-")
                {
                    answer = a - b;
                    Console.WriteLine("Ответ: " + a + " - " + b + " = " + answer);
                }
                else if (oper == "*")
                {
                    answer = a * b;
                    Console.WriteLine("Ответ: " + a + " * " + b + " = " + answer);
                }
                else if (oper == "/")
                {
                    answer = a / b;
                    Console.WriteLine("Ответ: " + a + " / " + b + " = " + answer);
                }
                else
                    Console.WriteLine("Не знаю такой операции: " + oper);
                Console.WriteLine("Продолжим? (да/нет)");
                flag = Convert.ToString(Console.ReadLine());
            } while (flag == "да");

        }
    }
}