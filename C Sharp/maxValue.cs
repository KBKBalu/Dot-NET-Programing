using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxValue
{
    class maxValue
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter value to x:");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter value to y:");
            y = int.Parse(Console.ReadLine());

            if (x > y)
                Console.WriteLine("X is greater");
            else
            {
                if (x < y)
                    Console.WriteLine("Y is greater");
                else
                    Console.WriteLine("Both are Same");
                Console.ReadLine();
            }

        }
    }
}
