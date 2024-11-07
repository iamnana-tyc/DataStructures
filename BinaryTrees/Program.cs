using BinaryTrees;

class Program 
{
    public static void Main(string[] args)
    {
        BinaryTree binaryTree = new BinaryTree();

        int[] valuesToAdd = { 50, 30, 70, 20, 40, 60, 80 };
        Console.WriteLine("Adding nodes to the tree:");
        foreach(int values in valuesToAdd)
        {
            binaryTree.Add(values);
        }

        // Trying different cases
        Console.WriteLine("\nRemoving leaf node (20):");
        binaryTree.Remove(20);
        
        Console.WriteLine("\nRemoving node with one child (30):");
        binaryTree.Remove(30); // Node with one child (after removal of 20)

        Console.WriteLine("\nRemoving node with two children (50):");
        binaryTree.Remove(50); // Node with two children

        // Verify remaining tree structure
        Console.WriteLine("\nRemaining tree structure:");
        PrintInOrder(binaryTree.root);

        System.Console.WriteLine();
        
        // Perform in-order traversal
        Console.WriteLine("In-order traversal of the tree:");
        binaryTree.InOrderTraversal();  // Expected output: 20 30 40 50 60 70 80
    }

    private static void PrintInOrder(Node node)
    {
         if (node != null)
        {
            PrintInOrder(node.left);
            Console.Write(node.data + " ");
            PrintInOrder(node.right);
        }
    }
}
