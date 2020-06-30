using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;
using System.Diagnostics;

namespace parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30000;
            int i = 1;
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            Parallel.For(1, n, i =>
            {
                int countNum = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        countNum++;
                }
                Console.WriteLine("for number:{0} result:{1}", i, countNum);
            });
            s1.Stop();
            Console.WriteLine("Time = " + s1.ElapsedMilliseconds);
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            for(i = 1; i<= n; i++)
            {
                int countNum = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        countNum++;
                }
                Console.WriteLine("for number:{0} result:{1}", i, countNum);
            }
            s2.Stop();
            Console.WriteLine("Time 1 = {0}, Time 2 = {1}", s1.ElapsedMilliseconds, s2.ElapsedMilliseconds);
        }
    }
}
