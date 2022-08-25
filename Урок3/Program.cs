using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок3
{
    internal class Program
    {
        static void Main(string[] args) { 
        {
            double x;
            double k; // Пер. с заданм типом
            x = GetNum("x"); // Метод задаем и пере.
            k = GetNum("k");
            GetAnswer(x, k); // имя метода (пер. которые он будет исполь).
            Console.ReadKey();
        }
        static void GetAnswer(double x, double k)
        {
            if (x <= -5)
            { // условие
                Console.WriteLine($"Результат вычисления y = {2 * x + k}"); // выполнение условия 
                return;
            }
            if (x > -5 && x < 0)
            {
                Console.WriteLine($"Результат вычисления y = {x + 2 / k}");
                return;
            }
            if (x == 0)
            {
                Console.WriteLine($"Результат вычисления y = {k * k}");
                return;
            }
            if (x > 0 && x < 7)
            {
                Console.WriteLine($"Результат вычисления y = {k - x}");
                return;
            }
            if (x >= 7)
            {
                Console.WriteLine($"Результат вычисления y = {k * k - Math.Pow(x, k)}");
                return;
            }

            Console.WriteLine();
        }


        static double GetNum(string str)
        { // в консоли ввод чисел 
            while (true)
            {
                Console.Write("Введите число {0}: ", str);
                if (double.TryParse(Console.ReadLine(), out double number))
                { // перевод значений в Double, //Console.ReadLine(), out double number условие ввода числовых значений.
                    return number; // 
                    break;
                }

                Console.WriteLine("Внимание, введено не число!");
            }
        }
