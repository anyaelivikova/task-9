using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< задача 9 >>>");
            CycleList list = new CycleList();

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(50));
            }

            list.Show();

            int sum = list.Sum();
            Console.WriteLine($"Сумма эл-тов без рекурсии = {sum}");
            int sumRec = list.SumRecursive();
            Console.WriteLine($"Сумма эл-тов с рекурсией = {sumRec}");

            Console.ReadLine();
        }
    }
}
