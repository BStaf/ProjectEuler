using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
           // long i = 500;
            Console.WriteLine("begin");
            //int num = 1000000;
            Console.WriteLine(LatticePaths.Solve(1000,1000));
        }
    }
}
