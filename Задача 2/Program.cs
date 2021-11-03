using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите координаты точки A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C:");
            int C = Convert.ToInt32(Console.ReadLine());

            if ((B - A) < (C - A))
            {
                Console.WriteLine($"т.B ближе к т.A, расстояние = {B - A}");
            }
            else if ((B - A) > (C - A))
            {
                Console.WriteLine($"т.C ближе к т.А, расстояние = {C - A}");
            }
            else
            {
                Console.WriteLine($"B и C - находятся в одной точке, расстояние до т.А = {B - A}");
            }
            Console.ReadKey();
        }
        

    }
}
