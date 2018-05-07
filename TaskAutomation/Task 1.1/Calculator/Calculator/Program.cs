using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    class Program
    {
       static void Main()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
           
            while (true)
                try
                {
                    {
                        Console.WriteLine("Введите первое число:");
                        string s = Console.ReadLine();
                        double a = Convert.ToDouble(s);

                        Console.WriteLine("Введите второе число:");
                        string s2 = Console.ReadLine();
                        double b = Convert.ToDouble(s2);
                        Console.WriteLine("Выберите операцию : Сумма (a); Вычитание (b);Умножение (c); Деление (d)");

                        string str = Console.ReadLine();
                        switch (str)
                        {

                            case "a":
                                sum(a, b);
                                break;
                            case "b":
                                sub(a, b);
                                break;
                            case "c":
                                mult(a, b);
                                break;
                            case "d":
                                div(a, b);
                                break;
                            default:
                                Console.WriteLine("Неверный выбор. Пожалуйста,выберите a, b, c or d");
                                break;
                        }

                        Console.ReadLine();
                    }
                }


                catch (FormatException)
                {
                    Console.WriteLine("Это не число!!!\n");

                }

        }

        static void sum(double a, double b)
        {

            double result = a + b;

            Console.WriteLine("Итог суммы данных чисел:");
            Console.WriteLine(result);

        }


        static void sub(double a, double b)
        {

            double result = a - b;

            Console.WriteLine("Итог вычитания данных чисел:");
            Console.WriteLine(result);

        }

        static void mult(double a, double b)
        {

            double result = a * b;

            Console.WriteLine("Итог умножения данных чисел:");
            Console.WriteLine(result);

        }





        static void div(double a, double b)
        {

            double result = a / b;
            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя!!!");
            }
            else
            {
                Console.WriteLine("Итог деления данных чисел:");
                Console.WriteLine(result);

            }
        }
    }
}








