//Write a method that prints if a number read from a console is positive or negative
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int number =  int.Parse(Console.ReadLine());
        CheckNumber(number);
    }

    static void CheckNumber(int number)
    {
       if (number < 0)
        {
            Console.WriteLine("Number is less than 0");
        }
        else if (number > 0)
        {
            Console.WriteLine("Number is grater than 0");
        }
        else
        {
            Console.WriteLine("Number is eqal with 0 ");
        }
    }
}
