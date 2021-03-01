using BinarySearchTreeNameSpace;
using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree search");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();
            ///<summary>
            ///UC1: Add the node in the tree
            /// </summary>
            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(11);
            BinaryTree.AddNode(63);
            BinaryTree.AddNode(67);
            BinaryTree.AddNode(16);
            BinaryTree.AddNode(60);
            BinaryTree.AddNode(95);
            BinaryTree.AddNode(65);
            BinaryTree.AddNode(3);
            ///<summary>
            ///UC2:Find the size of tree
            /// </summary>
            int Size = BinaryTree.GetSize();
            Console.WriteLine(Size);
            
            ///<summary>
            ///UC3:Serach node through the tree
            /// </summary>
            bool result = BinaryTree.SearchKey(63);
            Console.WriteLine(result);
            
           

        }
    }
}
