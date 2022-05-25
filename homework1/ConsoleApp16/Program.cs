using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adlar siyahinizin uzunlugunu daxil edin:");
            string CountStr = Console.ReadLine();
            int count=Convert.ToInt32(CountStr);
            string[] names = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ i + 1}. Adi daxil edin");
                names[i] = Console.ReadLine();
            }



            

            
            
        }
    }
}
