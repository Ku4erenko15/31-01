using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._01_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time obj1 = new Time();
            obj1.Hours = 2;
            obj1.Minutes = 30;
            obj1.Seconds = 45;
            Console.WriteLine(obj1);

            Time obj2 = new Time(1, 45, 30);
            Console.WriteLine(obj2);

            Console.Write("Введите часы: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Time obj3 = new Time(hours, minutes, seconds);
            Console.WriteLine(obj3);
        }
        class Time
        {
            public int Hours;
            public int Minutes;
            public int Seconds;

            public Time()
            {
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }

            public Time(int hours)
            {
                Hours = hours;
                Minutes = 0;
                Seconds = 0;
            }

            public Time(int hours, int minutes)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = 0;
            }

            public Time(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public override string ToString()
            {
                return $"Time: {Hours}h {Minutes}m {Seconds}s";
            }
        }
    }
}
