using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class BinaryTree
    {
        public Node root = null;
        
        // a method that add value to the tree
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if(root == null)
            {
                root = newNode;
                Console.WriteLine("Setting the value " + value + " as root");
            }else
            {
                AddNode(root,newNode);
            }
        }

        private void AddNode(Node root, Node newNode)
        {
            // we go left
            if(newNode.data < root.data)
            {
                if (root.left != null)
                {
                    AddNode(root.left, newNode);
                }
                else
                {
                    Console.WriteLine("Added "+ newNode.data + " to the left side of the " + root.data);
                    root.left = newNode;
                }
            }
            // we go right
            else if (newNode.data > root.data)
            {
                if(root.right != null)
                {
                    AddNode(root.right, newNode);
                }
                else
                {
                    Console.WriteLine("Added "+ newNode.data + " to the right side of the " + root.data);
                    root.right = newNode;
                }
            }
            else
            {
                Console.WriteLine("Avoid duplicates values " + newNode.data +  " for easy implementation.");
            }
        }

        public void Remove(int value)
        {
            root = deleteNode(root, value);
        }

        private Node deleteNode(Node root, int value)
        {
            // we check if the root is null
            if(root == null)
            {
                Console.WriteLine("The value "+ value + " is not found in the tree.");
                return null;
            }
            // if value is less we go to the left side otherwise to the right.
            if (value < root.data)
            {
                root.left = deleteNode(root.left, value);
            }
            else if (value > root.data)
            {
               root.right = deleteNode(root.right, value); 
            }
            else
            {
                // NODE TO REMOVE - THREE CASES, 
                
                // CASE 1 - When there no children it returns null and delete node. 
                if(root.left == null && root.right == null )
                {
                    Console.WriteLine("Removing the node " + value);
                    return null;
                }
                // CASE 2 - When there is one child
                // If the node has only one child, return that child to link it directly to the parent.
                if(root.left == null){
                    Console.WriteLine("Removing node " + value + " with a right child");
                    return root.right;
                }
                if(root.right == null )
                {
                    Console.WriteLine("Removing node "+ value + " with left child ");
                    return root.left;
                }

                // CASE 3 - When there is two children
                Console.WriteLine("Removing node " + value + " with two children");
                Node successor = FindMin(root.right);
                root.data = successor.data; // this is to replace root data with successor data.
                root.right = deleteNode(root.right, successor.data); // this is to remove successor
            }
            return root;
        }

        private Node FindMin(Node root)
        {
            while(root.left != null)
            {
                root = root.left;
            }
            return root;
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }
        private void InOrderTraversal(Node node){
            if(node != null)
            {
                // 1. Traverse the left subtree
                InOrderTraversal(node.left);

                // 2. Go to the root
                Console.WriteLine(node.data + " ");

                // 3. Traverse the right subtree
                InOrderTraversal(node.right);
            }

        }
    }



    
}