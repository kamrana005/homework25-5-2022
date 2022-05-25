using System;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] name = { "Abbas",  "Ayten",  "Ali" };
            bool isStartWithA=true;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i][0] != 'A')
                { isStartWithA = false; break; }

            }
            if (isStartWithA)
                Console.WriteLine("Hamisi A ile baslayir"); 
            else Console.WriteLine("A ile baslamiyan ad var");
        }
    }
}
