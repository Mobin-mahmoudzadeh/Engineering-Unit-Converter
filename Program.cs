using System;

namespace program
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter temperature in Calsius: ");
      string input = Console.ReadLine();
      double celsius = Convert.ToDouble(input);
      
      double fahrenheit = (celsius * 9 / 5) + 32;
      
      Console.WriteLine("Temperature in Fahrenheit is:" + fahrenheit);
    }
  }
};

