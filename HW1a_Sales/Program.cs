// HW1a Sales Total

// Ava Eichinger
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string itemname;
            double subtotal;
            double salestax;
            double salestotal;

            Console.WriteLine("What is the item you're purchasing?");
            itemname = Console.ReadLine();

            Console.WriteLine("How many tickets do you want to buy?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("What is the price of each ticket?");
            double price = Convert.ToDouble(Console.ReadLine());

            const double tax_rate = 0.085;
            
             subtotal = (price * quantity);
             salestax = (tax_rate *  subtotal);
             salestotal = (subtotal + salestax);

         

            Console.WriteLine($"Your Subtoal is " + subtotal.ToString("C2"));
            Console.WriteLine($"Your Salestax is "  + salestax.ToString("C2"));
            Console.WriteLine($"Your Salestotal is " + salestotal.ToString("C2"));

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();



            


            
        
            

           
        }
    }
}
