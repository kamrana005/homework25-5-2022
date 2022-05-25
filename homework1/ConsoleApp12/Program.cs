using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mixNumbers = { 3, 45, 67, 8, 56, 78, 90, 12, 14, 60 };
            
            for (int i = 0; i < mixNumbers.Length-1; i++) 
            {  
                for (int a = 0; a < mixNumbers.Length-1-i; a++)
                { 
                    if (mixNumbers[a] > mixNumbers[a + 1])
                    {
                        int temp = mixNumbers[a];
                        mixNumbers[a]=mixNumbers[a + 1];
                        mixNumbers[a + 1] = temp;


                    }
                            
                }
                    


            }

            for (int i = 0; i < mixNumbers.Length; i++)
            
            { 
                Console.WriteLine(mixNumbers[i]); 
            }



            
        }
    }
}
