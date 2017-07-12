using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDemo
{
    class switchDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Student number(1-6):");
            int sno = int.Parse(Console.ReadLine());

            switch (sno)
            {
                case 1:
                    Console.WriteLine("Student 1: Balu");
                    //Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Student 2: Sourabh");
                    break;

                case 3:
                    Console.WriteLine("Student 3: Murali");
                    break;

                case 4:
                    Console.WriteLine("Student 4: Anusha");
                    break;

                case 5:
                    Console.WriteLine("Student 5: Shruthi");
                    break;

                case 6:
                    Console.WriteLine("Student 6: Venkat");
                    break;

                default:
                    Console.WriteLine("Student Does not Exist");
                    break;

            }
            Console.ReadLine();
        }
    }
}
