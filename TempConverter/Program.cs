using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal celsiusToF;
            decimal fahrenheitToC;

            while (1 < 2)
            {


                Console.WriteLine("Welcome to the Temperature Converter!");

                Console.Write("What is the temperature?");
                string num = Console.ReadLine();
                decimal inputNumber = decimal.Parse(num);


                Console.Write("What unit is that? (F = Fahrenheit, C = Celsius)");
                string userInput = Console.ReadLine();

                if (userInput == "C" || userInput == "c" || userInput == "Celsius" || userInput == "celsius")
                {
                    celsiusToF = (inputNumber * 1.8m) + 32;
                    Console.WriteLine($"{inputNumber} degrees Celsius is {celsiusToF} degrees Fahrenheit.");
                    if (celsiusToF > 80)
                    {
                        Console.WriteLine("That's really warm!");
                    }
                }
                else if (userInput == "F" || userInput == "f" || userInput == "Fahrenheit" || userInput == "fahrenheit")
                {
                    fahrenheitToC = (inputNumber - 32) * .55555555555m;
                    Console.WriteLine($"{inputNumber} degrees Fahrenheit is {fahrenheitToC} degrees Celsius.");
                    if (fahrenheitToC > 26.7m)
                    {
                        Console.WriteLine("That's really warm!");
                    }
                }

                Console.WriteLine("Would you like to convert another temperature? (Y / N)");
                string userInput2 = Console.ReadLine();

                if (userInput2 == "Y" || userInput2 == "y")
                {
                    continue;

                }
                else
                {
                    break;
                }
            }
        }
    }
}
//TempConverter temp = new TempConverter();