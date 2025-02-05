using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate obj1 = new Calculate();
            obj1.Num1 = 4.0;
            obj1.Num2 = 9.0;
            Console.WriteLine(obj1);
            Console.WriteLine("Квадратный корень из произведения: " + Math.Sqrt(obj1.Num1 * obj1.Num2));

            Calculate obj2 = new Calculate(2.0, 8.0);
            Console.WriteLine(obj2);
            Console.WriteLine("Квадратный корень из произведения: " + Math.Sqrt(obj2.Num1 * obj2.Num2));

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Calculate obj3 = new Calculate(num1, num2);
            Console.WriteLine(obj3);
            Console.WriteLine("Квадратный корень из произведения: " + Math.Sqrt(obj3.Num1 * obj3.Num2));

            Console.ReadKey();
        }

        class Calculate
        {
            public double Num1 { get; set; }
            public double Num2 { get; set; }

            public Calculate()
            {
                Num1 = 0.0;
                Num2 = 0.0;
            }

            public Calculate(double num)
            {
                Num1 = num;
                Num2 = num;
            }

            public Calculate(double num1, double num2)
            {
                Num1 = num1;
                Num2 = num2;
            }

            public override string ToString()
            {
                return $"Calculate(Num1={Num1}, Num2={Num2})";
            }
        }

    }
}

