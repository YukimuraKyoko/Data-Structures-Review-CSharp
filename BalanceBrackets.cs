using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    using System;
    using System.Collections;
    // We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
    class BalancedBrackets
    {
        public static Stack stacc;

        static void Main(string[] args)
        {
            stacc = new Stack();

            // Call isBalanced() with test cases here
            string test1 = "{[()]}"; //true
            string test2 = "{}()"; //true
            string test3 = "{(})"; //false
            string test4 = ")"; //false
            Console.WriteLine(isBalanced(test1));
            Console.WriteLine(isBalanced(test2));
            Console.WriteLine(isBalanced(test3));
            Console.WriteLine(isBalanced(test4));
        }

        private static bool isBalanced(string s)
        {
            // Write your code here
            //Algorihm:
            //For every left bracket, push into stack, for every right bracket, peek top element of stack to see if it's a matching pair
            //If it matches, pop it, if it doesn't match, then return that this string is unbalanced
            //Or if the string is fully iterated with remaining data in the stack, also return unbalanced.
            if(s == string.Empty)
            {
                return true;
            }
            else if(s.Length == 1)
            {
                return false;
            }
            for(int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '{':
                        stacc.Push(s[i]);
                        break;
                    case '(':
                        stacc.Push(s[i]);
                        break;
                    case '[':
                        stacc.Push(s[i]);
                        break;
                }
                switch (s[i])
                {
                    case '}':
                        if((char)stacc.Peek() == '{')
                        {
                            stacc.Pop();
                        }
                        break;
                    case ')':
                        if ((char)stacc.Peek() == '(')
                        {
                            stacc.Pop();
                        }
                        break;
                    case ']':
                        if ((char)stacc.Peek() == '[')
                        {
                            stacc.Pop();
                        }
                        break;
                }
            }
            //After iterating, check if stack is empty
            if(stacc.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
