using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumber
    {
        public int numb = 2;
        public int first = 0;
        public void FindReverseNumber()
        {
            Console.WriteLine("Enter number to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            Console.WriteLine(numb);
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse number is {0}", Reverse);
            Console.ReadLine();

        }
    }
}
