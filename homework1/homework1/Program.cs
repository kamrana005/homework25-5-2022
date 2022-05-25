using System;

namespace homework1
{
    internal class Program
    {   
      
        static void Main(string[] args)

        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 34, 45, 55, 67, 98,100, 120, 150 };
           
            int n = 100;

            int max = numbers.Length - 1;
            int min = 0;
            int index = -1;

             while(min<=max)
            { 
                int mid = (min+max)/2;
                if (n == numbers[mid])
                { 
                    index = mid;
                    break;
                }
                else if (n > numbers[mid])
                {
                    min = mid + 1;
                 }
                else 
                { 
                    max = mid - 1;
                  }
              }

             if(index == -1)
            { 
                Console.WriteLine("Eded tapilmadi");
            }
            else
            { Console.WriteLine( n + " ededi " + index + " nomreli indexde yerlesir"); 
                //Console.WriteLine($"{n} ededi {index} nomreli indexde yerlesir");
            }




        }
    }
}
