using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {
        public void FindPrimeNumber()
        {
            int num, i, result = 0;
            Console.Write("enter number to check prime: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    result++;
                    break;
                }
            }
            if (result == 0 && num != 1)
                Console.WriteLine("{0} is a prime number.\n", num);
            else
                Console.WriteLine("{0} is not a prime number\n", num);
        }
    }
}
