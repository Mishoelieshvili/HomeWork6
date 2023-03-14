using System.Linq;
using System;

class Program
{
    static void Main(string[] args)

    #region Task3

    {
        string[] participants = { "Gio", "Toko", "Nini", "Nita", "Lizi" };
        int[] scores = { 80, 90, 70, 85, 75 };

        Console.Write("Enter the number of top participants to display: ");
        var n = int.Parse(Console.ReadLine());


        int[] topIndices = scores.Select((score, index) => new { Score = score, Index = index })
                                 .OrderByDescending(item => item.Score)
                                 .Select(item => item.Index)
                                 .Take(n)
                                 .ToArray();

        Console.WriteLine($"Top {n} participants:");
        for (int i = 0; i < n && i < topIndices.Length; i++)
        {
            int index = topIndices[i];
            Console.WriteLine($"{i + 1}. {participants[index]} - {scores[index]}");
        }

        Console.WriteLine();

        #endregion


        #region Task 2



        #endregion


        #region Task 1

        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] evenNumbers = Array.FindAll(array, element => element % 2 == 0);
        int[] oddNumbers = Array.FindAll(array, element => element % 2 != 0);

        Console.WriteLine("Even numbers:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Odd numbers:");
        foreach (int number in oddNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

      #endregion
    }
}



   


