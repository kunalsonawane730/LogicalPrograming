using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public void FindPerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Enter starting number : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number : ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect numbers within given range of numbers : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
        }
    }
}
