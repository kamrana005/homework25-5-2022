using System;

namespace ConsoleApp111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 456, 657, 567, };
            int biggest;
            biggest = numbers[0];
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > biggest)
                
                    biggest = numbers[i];
                    
                   
                

                
            }
            
            Console.WriteLine(biggest);
            



        }
    }
}
