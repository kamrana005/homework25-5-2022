using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        { bool hasdigit;
            string name;
            do {
                char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                Console.WriteLine("Ad daxil edin.");
                 name = Console.ReadLine();
                 hasdigit = false;
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < digits.Length; j++)
                    {
                        if (name[i] == digits[j])
                        {
                            hasdigit = true;
                            break;
                        }
                    }
                    if (hasdigit)
                        break;
                }
            




                
            }while (hasdigit);
            
                Console.WriteLine(name);
           
        }    
        
    }
}
