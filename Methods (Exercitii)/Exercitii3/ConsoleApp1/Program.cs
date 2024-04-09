
#region Exercitii 2
public class Program
{
    
    public static int GetMin(int a, int b)
    {
        return Math.Min(a, b);
    }

    public static float GetMin(float a, float b)
    {
        return Math.Min(a, b);
    }

    public static decimal GetMin(decimal a, decimal b)
    {
        return Math.Min(a, b);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        decimal num1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        decimal num2 = decimal.Parse(Console.ReadLine());

        decimal min = GetMin(num1, num2);
        Console.WriteLine($"The smallest of the two numbers is: {min}");
    }
}
#endregion