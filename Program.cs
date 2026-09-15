using System;

namespace program
{
  class Program
  {
    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("1. Converting Celsius to Fahrenheit");
            Console.WriteLine("2. Converting Fahrenheit to Celsius");
            Console.WriteLine("3.Exit");
            Console.Write("Please select your option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                {
                    Console.Write("Enter temperature in Celsius: ");
                    string tempInput = Console.ReadLine();
          
                    if (double.TryParse(tempInput, out double celsius))
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature value!");
                    }
                    break;
                }
                case "2":
                {
                    Console.Write("Enter temperature in Fahrenheit: ");
                    string tempInput = Console.ReadLine();
          
                    if (double.TryParse(tempInput, out double fahrenheit))
                    {
                        double celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("Temperature in Celsius is: " + celsius);
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature value!");
                    }
                    break;
                }
                case "3":
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid option! Please run the program again.");
                    break;
                }
            }
        } while (input != "3");
    }
  }
};

