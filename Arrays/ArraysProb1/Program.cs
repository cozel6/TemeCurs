using System.Runtime.ExceptionServices;

public class Program
{
    static void Main(string[] args)
    {
        #region Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes

        int[] array = { 1, 2, 3 ,4 ,5};

        Console.WriteLine("Afisam elementele: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]} si indexul este: {i}");
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
        #region Write a method to get the number of occurrences of a specified element in an array
        int target = 2;
        int count = 0;
        foreach(int number in array)
        {
            if (number == target)
            {
                count++;
                Console.WriteLine($"Target ul este {number}");
            }
        }
        #endregion
        #region Write a method to insert a new item before the second element in an existing array

        array = array.Concat(new int[] {6}).ToArray();
        Console.WriteLine($"Numarul adaugat este {array[5]}");
        #endregion
        #region Write a method to remove a specified item using the index from an array.

        array = RemoveItemAt(array, 2);
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
        static int[] RemoveItemAt(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    newArray[j++] = array[i];

                }
            }
            return newArray;
        }
        #endregion
        #region Write a program to find the sum of all elements of the array
        int sum = array.Sum();
        Console.WriteLine($"Suma lor este {sum}");
        #endregion
        #region Write a program to print all unique elements in an array.

        int[] arrayUnique = { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 9, 1 };



        #endregion
    }
}



