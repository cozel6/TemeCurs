


public class Program
{
    static void Main(string[] args)
    {
        #region //*Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.*/

        int[] array = { 1, 2, 3 ,4 ,5};

        Console.WriteLine("Afisam elementele: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]} si index: {i}");
        }
        /*
        Console.WriteLine("Accesam fiecare index :");
        for (int i = 0;i < array.Length; i++)
        {
            Console.WriteLine($"Index ul lor este {i}: {array[i]}");
        }
        */
        #endregion

        #region Write a method to reverse the order of the items in the array
        var arrayReverse = array.Reverse();
        foreach (var revesed in arrayReverse)
        {
            Console.WriteLine($"Inversul lor este {revesed}");
        }
        #endregion
    }
}




