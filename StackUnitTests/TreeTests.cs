using System;
using NUnit.Framework;
using Tree;

namespace DatastructurTests
{
    public class TreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_AddFiveElements_AddedRight()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(3);
            tree.Add(4);
            Assert.AreEqual(tree.ToString(), "43765");
        }

        [Test]
        public void Delete_DeleteRoot_DeletedRoot()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Delete(5);
            Assert.AreEqual(tree.ToString(), "");
        }

        [Test]
        public void Delete_DeleteLeaf_DeletedLeaf()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(3);
            tree.Add(4);
            tree.Delete(4);
            Assert.AreEqual(tree.ToString(), "3765");
        }

        [Test]
        public void Delete_DeleteMiddleNode_DeletedMiddleNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(3);
            tree.Add(4);
            tree.Delete(3);
            Assert.AreEqual(tree.ToString(), "4765");
        }

        [Test]
        public void Delete_DeleteMiddleNodeManyChildren_DeletedMiddleNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(3);
            tree.Add(4);
            tree.Add(0);
            tree.Add(-1);
            tree.Add(2);
            tree.Add(1);
            tree.Delete(3);
            Assert.AreEqual(tree.ToString(), "-110425");
        }

        [Test]
        public void Delete_DeleteMiddleNodeManyChildren2_DeletedMiddleNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(6);
            tree.Add(3);
            tree.Add(8);
            tree.Add(2);
            tree.Add(9);
            tree.Add(7);
            tree.Delete(8);
            Assert.AreEqual(tree.ToString(), "23976");
        }
    }
}
