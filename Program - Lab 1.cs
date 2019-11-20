using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Lab01
    {
        private static void Main(String[] args)
        {
            string response;
            //char s, f;
            bool spicy, fancy;
            Console.Write("Do you like Spicy food? (y | n): ");
            response = Console.ReadLine();
            if (response.ToCharArray()[0] == 'y' || response.ToCharArray()[0] == 'y')
            {
                Console.Write("Do you want to go to a fancy restaurant? (y | n): ");
                response = Console.ReadLine();
                if (response.ToCharArray()[0] == 'y' || response.ToCharArray()[0] == 'Y')
                {
                    Console.WriteLine("I suggest you go to Thai Garden's place.");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("I suggest you go to Alberto's Tacqueria.");
                    Console.Read();
                }
            }
            else
            {
                Console.Write("Do you want to go to a fancy restaurant? (y | n): ");
                response = Console.ReadLine();
                String ans = (response.ToCharArray()[0] == 'y' || response.ToCharArray()[0] == 'Y') ? "I suggest you to go to Chez Paris" : "I suggest you to go to Joe's Dinner";
                Console.WriteLine(ans);
                Console.Read();
            }
        }
    }
}