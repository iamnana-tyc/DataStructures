using System;
using BinaryTrees;

class Program 
{
    public static void Main(string[] args)
    {
        
        BinaryTree binaryTree = new BinaryTree();

        int[] valuesToAdd = { 120, 3, 46, 50, 30, 70, 20, 40, 60, 80 };
        Console.WriteLine("Adding nodes to the tree:");
        foreach(int values in valuesToAdd)
        {
            binaryTree.Add(values);
        }

        // Trying different cases
        Console.WriteLine("\nRemoving leaf node (3):");
        binaryTree.Remove(3);
        
        Console.WriteLine("\nRemoving node with one child (50):");
        binaryTree.Remove(50); 

        Console.WriteLine("\nRemoving node with two children (70):");
        binaryTree.Remove(70); 

        // Verify remaining tree structure
        Console.WriteLine("\nRemaining tree structure:");
        
        PrintInOrder(binaryTree.root);

        Console.WriteLine();

        Console.WriteLine("The task for In-Order-Tranversal");

        // Perform in-order traversal
        Console.WriteLine("In-order traversal of the tree:");
        binaryTree.InOrderTraversal(); 

        Console.WriteLine();

        Console.WriteLine("Moving on to the second TASK");

        // Task 2

        TreeNode treeNode = new TreeNode(1);
        treeNode.left = new TreeNode(2);
        treeNode.right= new TreeNode(3);
        treeNode.left.left= new TreeNode(4);
        treeNode.left.right = new TreeNode(5);
        treeNode.right.left= new TreeNode(6);
        treeNode.right.right = new TreeNode(7);

        

        Console.WriteLine("Pre-order Traversal:");
        treeNode.PreOrderTraverse(treeNode); 

        Console.WriteLine("\nPost-order Traversal:");
        treeNode.PostOrderTraversal(treeNode); 

        Console.WriteLine("\nIn-order Traversal:");
        treeNode.InOrderTraversal(treeNode) ; 

        Console.WriteLine(" ");

        Console.WriteLine("DEEP CLONING TEST");

        // clone the tree
        TreeNode clonedRoot = treeNode.Clone();

        Console.WriteLine("Original Tree Pre-order Traversal:");
        treeNode.PreOrderTraverse(treeNode);      // Expected Output: 1 2 4 5 3 6 7

        Console.WriteLine("\nCloned Tree Pre-order Traversal:");
        clonedRoot.PreOrderTraverse(clonedRoot); // Expected Output: 1 2 4 5 3 6 7

        Console.WriteLine(" ");

        Console.WriteLine("Clearing the tree...");

        // Clear the tree
        treeNode.Clear();
        treeNode = null;  // Set root to null to fully clear the tree

        Console.WriteLine("Tree has been cleared.");

    }

    private static void PrintInOrder(Node node)
    {
         if (node != null)
        {
            PrintInOrder(node.left);
            Console.WriteLine(node.data + " ");
            PrintInOrder(node.right);
        }
    }
}
