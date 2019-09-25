using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            double age;
            double weight;
            double height;
            double bmi;

            Console.WriteLine("Enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + firstName + ".");

            Console.WriteLine("What's your age?");
            age = Convert.ToDouble(Console.ReadLine());
            if (age < 20 || 60 < age)
            {
                Console.WriteLine("Sorry, but unfortunately program calculates BMI only for ages 20-60.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter your height in meters:");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your weight in kilograms:");
                weight = Convert.ToDouble(Console.ReadLine());
                bmi = weight / Math.Pow(height, 2);
                Console.WriteLine("Your BMI is " + bmi);
                Console.ReadLine();
            }



        }
    }
}
