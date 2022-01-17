using System;
using System.Collections;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class PairsHashTable
{
    /*
    static Hashtable integers;
    static int output;
    
    static void Main(string[] args)
    {
        // Call numberOfWays() with test cases here

        int[] arr1 = { 1, 2, 3, 3, 4, 4, 6, 6, 6, 6, 7, 9, 9, 9, 9 };
        Console.WriteLine("output: " + numberOfWays(arr1, 6));
    }
    

    private static int numberOfWays(int[] arr, int k)
    {
        integers = new Hashtable();

        //GenerateHashTable(arr);
        PrintHashTable();
        CountPairs(k);

        return output;
    }

    public static void CountPairs(int k)
    {
        //Example visual case:
        // k = 12
        // array = {6,6,6,6} 
        // hashtable: 6: 4count
        // 4count / 2 = 2 pairs
        int pair1;
        int pair2;
        foreach (DictionaryEntry entry in integers)
        {
            //if we find exact key = k value
            if((int)entry.Key == k)
            {
                output += (int)entry.Value / 2;
            }
            
            //Calculating pairs
            pair1 = k - (int)entry.Key;
            pair2 = k - pair1;
            //If we find values lower than k
            if (pair1 > 0)
            {
                //Find Matching pair and how many
                if(integers.ContainsKey(pair2))
                {
                    //At this point Pair1 + Pair2 is always equal to k
                    //Then we count the biggest number of duplicates between both of them and add it to output
                    if((int)integers[pair1] >= (int)integers[pair2]){
                        output += (int)integers[pair1];
                    }
                    else
                    {
                        output += (int)integers[pair2];
                    }
                }
            }
        }
    }
    
    public static void GenerateHashTable(int[] arr)
    {
        // Generate Hashtable
        for (int i = 0; i < arr.Length; i++)
        {
            //Duplicate Add
            if (integers.ContainsKey(arr[i]))
            {
                integers[arr[i]] = (int)integers[arr[i]] + 1;
            }
            else //New Add
            {
                integers.Add(arr[i], 1);
            }
        }
    }
    
    public static void PrintHashTable()
    {
        //Debug print hashtable
        Console.WriteLine("Printing Hashtable...");
        foreach (DictionaryEntry a in integers)
        {
            Console.WriteLine("Key:" + a.Key + " " + "Value: " + a.Value);
        }
    }
    */
}
