
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int result = Divide(input1, input2);
            Console.WriteLine($"The result is {result}");
        }
      
        catch (OverflowException ex) // Exception for any number above int32
        {
            Console.WriteLine("Error: Number is too large or too small for Int32.");
            Console.WriteLine($"Debug details: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine($"Debug details: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex) //Exception i use for negative numbers
        {
            Console.WriteLine("Error: Negative numbers are not allowed.");
            Console.WriteLine($"Debug details: {ex.Message}");
        }
   
    }

    static int Divide(string input1, string input2)
    {
        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);

        if (number1 < 0 || number2 < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number1 / number2;
    }
}
