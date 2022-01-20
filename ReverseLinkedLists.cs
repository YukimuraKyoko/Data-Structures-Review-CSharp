using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /*
    public class Node
    {
        public int data;
        public Node next;
        public Node(int x)
        {
            data = x;
            next = null;
        }
    }


    public static class ReverseLinkedLists
    {
        static int[] arr1 = { 1, 2, 8, 9, 12, 16};

        static void Main(string[] args)
        {
            Node head = createLinkedList(arr1);
            reverse(head);
            Console.WriteLine(printLinkedList(head));
        }

        public static bool isEven(int num)
        {
            return (num % 2 == 0);
        }

        public static Node reverseNodes(Node node)
        {
            Node current = node;
            Node previous = null;
            while(current != null && isEven(current.data))
            {
                Node next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            node.next = current;
            return previous;
        }

        public static Node reverse(Node head)
        {
            Node temp = new Node(0);
            temp.next = head;
            Node previous = temp;
            Node current = head;
            while (current != null)
            {
                if (isEven(current.data))
                {
                    previous.next = reverseNodes(current);
                }
                previous = current;
                current = current.next;
            }
            return temp.next;
        }

        public static Node createLinkedList(int[] arr)
        {
            Node head = null;
            Node tempHead = head;
            foreach(int v in arr)
            {
                if (head == null)
                {
                    head = new Node(v);
                    tempHead = head;
                }
                else
                {
                    head.next = new Node(v);
                    head = head.next;
                }
            }
            return tempHead;
        }

        public static string printLinkedList(Node head)
        {
            string output = "[";
            while (head != null)
            {
                output += head.data;
            head = head.next;
            if (head != null)
            {
                    output += " ";
            }
            }
            output += "]";
            return output;
        }
    }
    */
}
