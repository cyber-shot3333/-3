using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        private static string[] _first;
        private static string[] _second;
        private static string[] _third;

        static void Main()
        {
            _first = new[] { "cто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            _second = new[] { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            _third = new[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            Console.WriteLine("Введите число:");
            var str = Console.ReadLine();
            try
            {
                var n = Int32.Parse(str);

                if (n < 100)
                {
                    Console.WriteLine("Неправильный формат ввода, попробуйте еще раз!");
                    Main();
                }

                if (str.Length > 3)
                {
                    Console.WriteLine("Неправильный формат ввода, попробуйте еще раз!");
                    Main();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный формат ввода, попробуйте еще раз!");
                Main();
            }

            var chars = str.ToCharArray();

            var i = 0;
            var num = "";

            foreach (var ch in chars)
            {
                int n;
                switch (i)
                {
                    case 0:
                        n = Int32.Parse(ch.ToString()) - 1;
                        if (n >= 0)
                            num += _first[n] + " ";
                        break;
                    case 1:
                        n = Int32.Parse(ch.ToString()) - 1;
                        if (n >= 0)
                            num += _second[n] + " ";
                        break;
                    case 2:
                        n = Int32.Parse(ch.ToString()) - 1;
                        if (n >= 0)
                            num += _third[n] + " ";
                        break;
                }
             }

            Console.WriteLine(num);
            Main();
        }
    }
    
}
 

