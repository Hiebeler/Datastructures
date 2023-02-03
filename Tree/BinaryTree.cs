using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace Tree
{
    public class BinaryTree
    {

        private Node Root;

        public void Add(int Data)
        {
            if (Root == null)
            {
                Root = new Node(Data);
                return;
            }

            addDataToExistingTree(Data);
        }

        private void addDataToExistingTree(int Data)
        {
            Node curNode = Root;
            while (true)
            {
                if (Data == curNode.Data)
                    throw new Exception("this number already exists");
                if (Data < curNode.Data)
                {
                    if (curNode.left == null)
                    {
                        curNode.left = new Node(Data);
                        return;
                    }

                    curNode = curNode.left;
                }
                else if (Data > curNode.Data)
                {
                    if (curNode.right == null)
                    {
                        curNode.right = new Node(Data);
                        return;
                    }
                    curNode = curNode.right;
                }
            }
        }

        public Node FindNode(int Data)
        {
            Node? curNode = Root;
            while (true)
            {
                if (Data == curNode.Data)
                    return curNode;
                
                if (Data < curNode.Data)
                    curNode = curNode.left;
                
                else if (Data > curNode.Data)
                    curNode = curNode.right;
                
            }
        }

        public void Delete(int Data)
        {
            Node nodeToDelete = FindNode(Data);
            if (Root.isLeaf())
                deleteRoot();
            else if (nodeToDelete.isLeaf())
                deleteLeaf(nodeToDelete);
            else
            {
                deleteMiddleNode(nodeToDelete);
            }
        }

        private void deleteRoot()
        {
            Root = null;
        }

        private void deleteLeaf(Node leaf)
        {
            setPrevChildNode(leaf, null);
        }

        private void deleteMiddleNode(Node nodeToDelete)
        {
            if (nodeToDelete.right == null || nodeToDelete.left == null)
            {
                Node nodeToReplace;
                if (nodeToDelete.right == null)
                    nodeToReplace = nodeToDelete.left!;
                else
                    nodeToReplace = nodeToDelete.right;
                setPrevChildNode(nodeToDelete, nodeToReplace);
            }
            else
            {
                deleteMiddleNodeWithTwoChilds(nodeToDelete);
            }
        }

        private void setPrevChildNode(Node startNode, Node? replaceNode)
        {
            Node prevNode = getPreviousNode(startNode);
            if (prevNode.left != null)
                if (prevNode.left.Data == startNode.Data)
                    prevNode.left = replaceNode;

            if (prevNode.right != null)
                if (prevNode.right.Data == startNode.Data)
                    prevNode.right = replaceNode;
        }

        private Node getPreviousNode(Node node)
        {
            Node prevNode = Root;
            Node? curNode = Root;
            while (true)
            {
                if (node.Data == curNode.Data)
                    return prevNode;

                if (node.Data < curNode.Data)
                {
                    prevNode = curNode;
                    curNode = curNode.left;
                }

                else if (node.Data > curNode.Data)
                {
                    prevNode = curNode;
                    curNode = curNode.right;
                }
            }
        }

        private void deleteMiddleNodeWithTwoChilds(Node nodeToDelete)
        {
            Node leftSmallestNode = getLeftSmallestNode(nodeToDelete);
            if (leftSmallestNode == nodeToDelete.left)
            {
                nodeToDelete.Data = leftSmallestNode.Data;
                nodeToDelete.left = null;
                return;
            }
            Node prevSmallstNode = getPreviousNode(leftSmallestNode);
            nodeToDelete.Data = leftSmallestNode.Data;
            if (leftSmallestNode.isLeaf())
                prevSmallstNode.right = null;
            else
                prevSmallstNode.right = leftSmallestNode.left;
        }

        private Node getLeftSmallestNode(Node startNode)
        {
            Node curNode = startNode.left;
            while (curNode.right != null)
            {
                curNode = curNode.right;
            }

            return curNode;
        }

        public override string ToString()
        {
            return getElementsAsString(Root);
        }
        string getElementsAsString(Node element)
        {
            String result = "";
            if (element == null)
                return "";
            result += getElementsAsString(element.left);
            result += getElementsAsString(element.right);
            result += element.Data.ToString();
            return result;
        }
    }
}