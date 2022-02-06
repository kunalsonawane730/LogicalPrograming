using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        public int firstNum = 0, secondNum = 1, result = 0;

        public void FindFibonacciSeries()
        {
            Console.WriteLine("Please enter number to generate series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User number is: " + num);
            result = firstNum + secondNum;
            Console.WriteLine("series are:" + firstNum + "\t" + secondNum);
            for (int i = 2; i < num; i++)
            {
                firstNum = secondNum;
                secondNum = result;
                Console.WriteLine("\t" + result);
                result = firstNum + secondNum;
            }
        }
    }
}
