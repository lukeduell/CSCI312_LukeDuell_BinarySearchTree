/* Luke Duell
 * Instructor: 
 * CSCI 312
 * Assignment 5
 * Description: This program uses binary search tree in C#. 
 *              The program uses add, find, preorder, inorder, 
 *              postorder, and size to output the binary search 
 *              tree of the string elements. 
 */

using System;

class WritetoConsole
{
    static void Main()
    {
        List<string> list = new List<string>();

        //adding element to the BST
        list.Add("A");
        list.Add("B");
        list.Add("C");
        list.Add("D");
        list.Add("E");
        list.Add("F");
        list.Add("G");

        //binary search or find
        int search = list.BinarySearch("B");
        Console.WriteLine("Find(element)\n");
        Console.WriteLine(search);

        //preorder of elements
        int[] preorder = new int[7];
        for (int i = 0; i < preorder.Length; i++)
        {
            preorder[i] = list.BinarySearch("A");
            preorder[i] = list.BinarySearch("B");
            preorder[i] = list.BinarySearch("C");
            preorder[i] = list.BinarySearch("D");
            preorder[i] = list.BinarySearch("E");
            preorder[i] = list.BinarySearch("F");
            preorder[i] = list.BinarySearch("G");
        }
        Console.WriteLine("Preorder(node)\n");
        for (int i = 0; i < preorder.Length; i++)
        {
            Console.Write($"{preorder[i]}\t");
        }


        //inorder of the elements
        list.Sort();
        int[] inorder = new int[7];
        for (int i = 0; i < inorder.Length; i++)
        {
            inorder[i] = list.BinarySearch("A");
            inorder[i] = list.BinarySearch("B");
            inorder[i] = list.BinarySearch("C");
            inorder[i] = list.BinarySearch("D");
            inorder[i] = list.BinarySearch("E");
            inorder[i] = list.BinarySearch("F");
            inorder[i] = list.BinarySearch("G");
        }
        Console.WriteLine("\nInorder(node)\n");
        for (int i = 0; i < inorder.Length; i++)
        {
            Console.Write($"{inorder[i]}\t");
        }

        //postorder of elements
        int[] postorder = new int[7];
        for (int i = 0; i < postorder.Length; i++)
        {
            postorder[i] = list.BinarySearch("G");
            postorder[i] = list.BinarySearch("F");
            postorder[i] = list.BinarySearch("E");
            postorder[i] = list.BinarySearch("D");
            postorder[i] = list.BinarySearch("C");
            postorder[i] = list.BinarySearch("B");
            postorder[i] = list.BinarySearch("A");
        }
        Console.WriteLine("\nPostorder(node)\n");
        for (int i = 0; i < postorder.Length; i++)
        {
            Console.Write($"{postorder[i]}\t");
        }

        int size = list.Capacity;
        Console.WriteLine("\nSize\n");
        Console.WriteLine(size);
    }
}

