using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mulTable
{
    class mulTableApplication
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value:");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
                return;
            for (int i = 1; i < 10; i++)
                Console.WriteLine("{0} * {1}={2}", x, i, x * i);
            Console.ReadLine();

        }
    }
}
