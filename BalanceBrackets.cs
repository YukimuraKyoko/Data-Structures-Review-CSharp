using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    using System;
    using System.Collections;
    // We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            // Call isBalanced() with test cases here
            string test1 = "{[()]}";
            string test2 = "{}()";
            string test3 = "{(})";
            string test4 = ")";
            Console.WriteLine(isBalanced(test1));
            Console.WriteLine(isBalanced(test2));
            Console.WriteLine(isBalanced(test3));
            Console.WriteLine(isBalanced(test4));
        }

        private static bool isBalanced(string s)
        {
            // Write your code here

            return false;
        }
    }
}
