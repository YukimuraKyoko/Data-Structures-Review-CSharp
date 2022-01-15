using System;
using System.Collections;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class Program
{

    static Hashtable integers;

    static void Main(string[] args)
    {
        // Call numberOfWays() with test cases here

        int[] arr1 = { 1, 2, 3, 3, 4 };
        numberOfWays(arr1, 6);
    }

    private static int numberOfWays(int[] arr, int k)
    {
        // Write your code here

        integers = new Hashtable();
        // Add 
        for(int i = 0; i < arr.Length; i++)
        {
            if (integers.ContainsKey(i))
            {
                //integers.Add(i, );
            }
            else
            {
                integers.Add(i, arr[i]);
            }
        }
        Console.WriteLine(integers[0]);
        Console.WriteLine(integers[1]);
        Console.WriteLine(integers[2]);
        Console.WriteLine(integers[3]);
        Console.WriteLine(integers[4]);

        return 0;
    }
}
