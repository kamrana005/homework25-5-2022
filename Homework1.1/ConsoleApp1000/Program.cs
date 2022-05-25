using System;

namespace ConsoleApp1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1035, sum = 0;




            while ( number > 0 )
            {
                sum += (number % 10);
                number /= 10;
               
            }
            Console.WriteLine(sum);

        }
    }
}
