// HW1b Grade

// Ava Eichinger
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("What is your student id number?");
            int studentidnumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double homeworks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = Convert.ToDouble(Console.ReadLine());

            

            double final_grade =
                (homeworks * 0.20) +
                (participation * 0.15) +
                (quizzes * 0.15) +
                (midterm * 0.25) +
                (final * 0.25);



            Console.WriteLine($"{firstname} {lastname} ({studentidnumber}), your final grade is {final_grade:F2}%");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
