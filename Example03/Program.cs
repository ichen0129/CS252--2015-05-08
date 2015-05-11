using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int ans;
            do
            {
                Console.Write("請輸入0~100的數字:");
                ans = int.Parse(Console.ReadLine());
            } while (ans < 0 || ans > 100);
        }
    }
}