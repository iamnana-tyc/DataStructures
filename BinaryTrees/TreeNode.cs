using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int data)
        {
            value = data;
            left = null;
            right = null;
        }

        public void PreOrderTraverse(TreeNode node)
        {
            if(node == null)
            return;

            // we need to visit root node first 
            Console.WriteLine(node.value + " ");

            // we need to visit left subnode 
            PreOrderTraverse(node.left);

            // we need to visit the right subtree
            PreOrderTraverse(node.right);

        }

        // Implement method PostOrderTraversal() - traversal of the tree "left subtree - right subtree - root".
        public void PostOrderTraversal(TreeNode node)
        {
            if (node == null)
            return;

            // we visit the left subtree
            PostOrderTraversal(node.left);

            // we visit the right subtree
            PostOrderTraversal(node.right);

            // we visit the root
            Console.WriteLine( node.value + " ");
        }

        // in-order traversal of the tree (left subtree - root - right subtree)
        public void InOrderTraversal(TreeNode node)
        {
            if(node == null)
            return;

            // visit subtree first 
            InOrderTraversal(node.left);

            // visit root 
            Console.WriteLine(node.value + " ");

            // visit the right subtree
            InOrderTraversal(node.right);

        }

        public TreeNode Clone()
        {
            // this creates a new node witht the current node's value.
            TreeNode newNode = new TreeNode(this.value);

            // Recursively clone the left subtree if it exists
            if(this.left != null)
            {
                newNode.left = this.left.Clone();
            }

            // Recursively clone the right subtree if it exists
            if(this.right != null)
            {
                newNode.right = this.right.Clone();
            }

            // Return the new cloned node, which is the root of the cloned subtree
            return newNode;

        }

        public void Clear()
        {
            if (left != null)
            {
                left.Clear();
                left = null;
            }

            if (right != null )
            {
                right.Clear();
                right = null;
            }
        }


    }

}