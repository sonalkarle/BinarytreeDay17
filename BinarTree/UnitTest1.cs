using BinarySearchTreeNameSpace;
using NUnit.Framework;
using System;

namespace BinarTree
{
    public class Tests
    {
        BinarySearchTree<int> BinaryTree;
       [SetUp]
        public void Setup()
        {
            BinaryTree = new BinarySearchTree<int>();
        }
        /// <summary>
        /// TC1:Given three numbers added to the tree
        /// </summary>
      
        [Test]
        public void Given3Numbers_WhenAddedToBinaryTree_ShouldReturnSizeTh()
        {
            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);

            Assert.AreEqual(56, BinaryTree.GetRoot);
            Assert.AreEqual(30, BinaryTree.GetRootLeft);
            Assert.AreEqual(70, BinaryTree.GetRootRight);
        }

        
    }
}