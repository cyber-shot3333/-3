using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int y4 = 0;
            int x4 = 0;
            if (x1 == x2)
            {
                if (y3 == y2)
                {
                    y4 = y1;
                    x4 = x3;
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else Console.WriteLine("Стороны не параллельны!");
            }
            else if (x2 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x1;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                }
                else Console.WriteLine("Стороны не параллельны!");
            }
            else if (x1 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else if (y3 == y1)
                {
                    x4 = x2;
                    y4 = y2;
                }
                else Console.WriteLine("Стороны не параллельны!");
            }
            else Console.WriteLine("Стороны не параллельны!");
            Console.WriteLine("Координата x1 = {0}, координата y1 = {1}", x1 , y1);
            Console.WriteLine("Координата x2 = {0}, координата y2 = {1}", x2 , y2);
            Console.WriteLine("Координата x3 = {0}, координата y3 = {1}", x3 , y3);
            Console.WriteLine("Координата x4 = {0}, координата y4 = {1}", x4 , y4);
            Console.ReadKey();
        }
    }
}
