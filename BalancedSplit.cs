using System;
using System.Collections.Generic;
using System.Text;


class BalancedSplit
{
    
    public static int[] arr1 = {1, 5, 7, 1};
    public static int[] arr2 = {12 , 7, 6, 7, 6};
    
    private static void Main(string[] args)
    {
        Array.Sort(arr1);
        Array.Sort(arr2);
        Console.WriteLine(balancedSplitExists(arr1));
        Console.WriteLine(balancedSplitExists(arr2));
    }
    
    public static bool balancedSplitExists(int[] arr)
    {
        if(arr == null || arr.Length == 0)
        {
            return false;
        }
        int lower = arr[0]; //Initialize first index
        int higher = arr[arr.Length - 1]; //Initialize last index

        int j = arr.Length - 1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            //If left side is lower than right side, as long as the indexes are not touching
            if (lower <= higher && (i != j) && arr[i] < arr[j])
            {
                Console.WriteLine("Adding " + arr[i] + " To lower");
                lower += arr[i];
            }
            else if (lower >= higher && (i != j) && arr[i] < arr[j]) //if lower side is now higher, then decrement j by 1, add that to higher, as long indexes are not matching
            {
                higher += arr[--j];
                Console.WriteLine("Adding " + arr[j] + " To higher");
            }
            else if (i == j && arr[i] < arr[j]) //if indexes align
            {
                Console.WriteLine("Both Equal");
                break;
            }
        }
        //i and j should be equal at this point, array is already iterated from left to right and right to left
        Console.WriteLine("lower: " + lower);
        Console.WriteLine("higher: " + higher);
        if(lower == higher)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

