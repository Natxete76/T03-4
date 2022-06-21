using System;

namespace T03_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            int N = 8;
            Console.WriteLine(N);
            Console.WriteLine(N += 77);
            Console.WriteLine(N -=3);
            Console.WriteLine(N*=2);

            Console.ReadKey();
        }
    }
}
