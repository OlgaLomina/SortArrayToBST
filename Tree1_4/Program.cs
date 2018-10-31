using System;
//Tree1 Problems
//4. Given a sorted array, create a binary search tree with minimum height
namespace Tree1_4
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node()
        {
            data = 0;
            left = null;
            right = null;
        }
        public Node(int val)
        {
            data = val;
            left = null;
            right = null;
        }
    }

    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }

        public Node ArrToBST(int[] arr, int left, int right)
        {
            /*Recursion:
              Get the middle of the array, make it as root. 
              (By doing this we will ensure that half of the elements of array will be on the left side of the root and 
                half on the right side.)
              Take the left half of the array, call recursively and add it to root.left.
              Take the right half of the array, call recursively and add it to root.right.
              Return root.
             * */
            if (left > right)
                return null;

            int middle = (left + right) / 2;
            
            Node root = new Node(arr[middle]);

            root.left = ArrToBST(arr, left, (middle - 1));
            root.right = ArrToBST(arr, (middle + 1), right);

            return root;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 25, 35, 40, 50, 60, 62, 65, 70, 80, 90 };
            int i = arr.Length;

            Tree bst = new Tree();

            Node root = bst.ArrToBST(arr, 0, (i-1));

            //Console.WriteLine("Hello World!");
        }
    }
}
