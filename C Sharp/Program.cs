using System;
namespace OopsConcept
{
    class Program
    {
        void language()
        {
            char a='c#';
            string b = 'java';
            string c = 'DotNet';
            Console.WriteLine(c);
        }
        void emp()
        {
            int id = 111;
            string name = 'KBK';
            Console.WriteLine(name);
        }
    }

    class Details : Program
    {
        void address()
        {
            string city = 'HYD';
            string dist = 'RR';
            Console.WriteLine(city);
        }
        void company()
        {
            string c1 = 'Abhra';
            string c2 = 'Techmo';
            Console.WriteLine(c1);
        }
    }
    static void Main(string[] args)
    {
       // Details d = new Details();
        Details d = new Program();
        d.emp();
        d.language();
        d.address();

        // Program p = new Program();
         Program p = new Details();
        p.emp();
        p.language();
        p.address();
        p.company();

        Console.ReadKey();
    }
}
