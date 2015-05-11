using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i, total;

            Console.WriteLine("請輸入1~10");

            i = 0;
            total = 0;
            int x = int.Parse(Console.ReadLine());
            while (i < 10)
            {
                i += 1;
                if (i == x)
                    continue;
                total += i;
            }
        }
    }
}