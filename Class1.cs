using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class ReverseToMakeEqual {
    /*
        static Hashtable table1;
        static Hashtable table2;

        
        static void Main(string[] args)
        {
            table1 = new Hashtable();
            table2 = new Hashtable();

            // Call areTheyEqual() with test cases here
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 1, 4, 3, 2 };
            GenerateHashTable(table1, arr1);
            PrintHashTable(table1);
            GenerateHashTable(table2, arr2);
            PrintHashTable(table2);

            Console.WriteLine("Are they Equal: " + areTheyEqual(table1, table2));
        }
        

        public static void GenerateHashTable(Hashtable table, int[] arr)
        {
            // Generate Hashtable
            for (int i = 0; i < arr.Length; i++)
            {
                //Duplicate Add
                if (table.ContainsKey(arr[i]))
                {
                    table[arr[i]] = (int)table[arr[i]] + 1;
                }
                else //New Add
                {
                    table.Add(arr[i], 1);
                }
            }
        }

        public static void PrintHashTable(Hashtable table)
        {
            //Debug print hashtable
            Console.WriteLine("Printing Hashtable ");
            foreach (DictionaryEntry a in table)
            {
                Console.WriteLine("Key:" + a.Key + " " + "Value: " + a.Value);
            }
        }

        private static bool areTheyEqual(Hashtable table1, Hashtable table2)
        {
            bool tablesEqual = false;
            foreach(DictionaryEntry t1 in table1)
            {
                //Looks for no matching key and value entries
                if (!table2.ContainsKey(t1.Key) && !table2.ContainsValue(t1.Value))
                {
                    tablesEqual = false;
                    //break as soon as an unmatching pair is found, so that tablesEqual won't become true again
                    break;
                }
                else
                {
                    tablesEqual = true;
                }
                
            }
            //return table1.Equals(table2);

            return tablesEqual;
        }
        */
}