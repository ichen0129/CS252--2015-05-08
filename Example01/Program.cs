using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("請輸入1~3的數字:");
            do
            {
                if (random.Next(1, 4) == int.Parse(Console.ReadLine()))
                    Console.WriteLine("恭禧您答對了");
                else
                    Console.WriteLine("答錯了");

                Console.Write("再來一遍? (y/n)");
            } while (Console.ReadLine() == "y");
        }
    }
}