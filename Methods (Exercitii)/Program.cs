using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first value");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second value");
        int num2 = int.Parse(Console.ReadLine());

        int min = GetMin(num1, num2);
        Console.WriteLine("Smallest number is " +  min);
    }


    public static int GetMin(int a, int b)
    {

        if (a < b)
            return a;
        else
            return b;
    }
}
