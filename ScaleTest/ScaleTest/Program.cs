using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScaleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Process p = Process.GetCurrentProcess())
                p.PriorityClass = ProcessPriorityClass.High;

            for (int i = 0; i < 10; i++)
            {
                Thread trehad = new Thread(() =>
                {

                    (new Program()).Slow();
                });
                trehad.Start();
            }
          
        }

        public void Slow()
        {
            long nthPrime = FindPrimeNumber(9999999); //set higher value for more time
        }

        public long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }


    }
}
