using System;

namespace Labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            int a = 0;
            int b = 1;
            int [] c = new int [5];
            for(int i=0; i<5; i++)
            {
                c[i] = b;
                a = i;
                b++;
            }
            Console.WriteLine("a={0}",a);
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("c[{0}]={1}", i, c[i]);
            }
            
            Console.WriteLine("input={0}",input);
            Console.Read();
        }
    }
}
