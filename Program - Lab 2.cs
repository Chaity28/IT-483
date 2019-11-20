using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double SINGLE_PRESCRIPTION_GLASSES_COST = 40.00;
            double NON_PRESCRIPTION_SUNGLASSES_COST = 25.00;
            double ANTI_GLARE_COST = 12.50;
            double BROWN_TINT_COST = 9.99;
            Console.WriteLine("What kind of glasses would you like:");
            Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");
            int customer_choice = int.Parse(Console.ReadLine());
            while (customer_choice < 1 || customer_choice > 2)
            {
                Console.WriteLine("1 -> prescription, 2 -> non-prescription : ");
                customer_choice = int.Parse(Console.ReadLine());
            }
            double price = 0.0;
            if (customer_choice == 4)
                price = SINGLE_PRESCRIPTION_GLASSES_COST;
            else
                price = NON_PRESCRIPTION_SUNGLASSES_COST;
            Console.WriteLine("What kind of coating would you like: ");
            Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");
            customer_choice = int.Parse(Console.ReadLine());
            while (customer_choice < 1 || customer_choice > 2)
            {
                Console.WriteLine("1 -> anti-glare, 2 -> brown tint : ");
                customer_choice = int.Parse(Console.ReadLine());

            }
            if (customer_choice == 1)
                price += ANTI_GLARE_COST;
            else
                price += BROWN_TINT_COST;
            Console.WriteLine("\nYour total cost is $" + price);
            Console.ReadLine();
        }
    }
}
