using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите возраст от 20 до 69");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a / 10)
            {
                case 2:
                    {
                        Console.Write("двадцать ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("тридцать ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("сорок ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пятьдесят ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шестьдесят ");
                        break;
                    }
            }
            switch (a % 10)
            {
                case 1:
                    {
                        Console.Write("один ");
                        break;
                    }
                case 2:
                    {
                        Console.Write("два ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("три ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("четыре ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пять ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шесть ");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семь ");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемь ");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девять ");
                        break;
                    }
            }
            if ((a % 10) == 1)
                Console.Write("год");
            if (((a % 10) >= 2) && (a % 10) <= 4)
                Console.Write("года");
            if (((a % 10) == 0) || ((a % 10) >= 5) && ((a % 10) <= 9))
                Console.Write("лет");
            Console.Read();

        }
    }
}
