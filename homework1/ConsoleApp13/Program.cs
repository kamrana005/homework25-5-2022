using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 8, 100, 80, 12 };
            int[] numbers2 = { 110, 112, 234, 75, 80, 8, 100, 23, 12};
            bool check = false;
            for (int i = 0; i < numbers1.Length; i++)
            {
                check = false;
                for (int j=0; j < numbers2.Length; j++)
                {
                    if(numbers1[i] == numbers2[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                    break;
            }
            if (check)
                Console.WriteLine("var");
            else
                Console.WriteLine("yoxdur");
        
        
        
        
        
        }
    }
}
