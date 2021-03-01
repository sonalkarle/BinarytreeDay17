using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeNameSpace
{
    public class BinarySearchTree<K> where K : IComparable
    {
        //Node root variable create to store the first node as root
        public BinarySearchTreeNode<K> Root;

        public void AddNode(K Key)
        {
            Root = AddRecursively(Root, Key);
        }
        public K GetRoot { get { return Root.Key; } }
        public K GetRootLeft { get { return Root.Left.Key; } }
        public K GetRootRight { get { return Root.Right.Key; } }



        private BinarySearchTreeNode<K> AddRecursively(BinarySearchTreeNode<K> Current, K Key)
        {
            //Check node is created or not and create Node
            //After Comparision current value become null to create new node and add to position
            if (Current == null)
                return new BinarySearchTreeNode<K>(Key);

            //Comapre the Node with Current(Root) Node
            int CompareResult = Key.CompareTo(Current.Key);
            //Comparision answer is zero then return current  node
            if (CompareResult == 0)
                return Current;
            //If comparision ans is smaller then go to left
            //If comparision ans is larger than go to right
            if (CompareResult < 0)
                Current.Left = AddRecursively(Current.Left, Key);
            
            else
                Current.Right = AddRecursively(Current.Right, Key);
            return Current;
        }
        public int GetSize()
        {
            return this.getSizeRecursively(Root);
        }

        private int getSizeRecursively(BinarySearchTreeNode<K> Current)
        {
            //checked node is present or not if present then it will return 1 for every node and will add at the end 
            return Current == null ? 0 : 1 + this.getSizeRecursively(Current.Left)
                                           + this.getSizeRecursively(Current.Right);
        }

        public bool SearchKey(K key)
        {
            return SearchRecursively(Root, key);
        }

        private bool SearchRecursively(BinarySearchTreeNode<K> Current, K key)
        {
            //First check if current is null then break statement
            if (Current == null)
                return false;
            //Then compare the current value with key 
            if (Current.Key.CompareTo(key) == 0)
                return true;
            else
                return SearchRecursively(Current.Left, key) || SearchRecursively(Current.Right, key);
        }
    }
}
