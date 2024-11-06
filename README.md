# DataStructures

Practical Work No. 12. Binary Trees.

Objective: To gain practical skills in creating and working with binary trees, as well as to deepen understanding of dynamic data structures.

### Task Statement

You are required to implement classes for a binary tree, including basic operations such as adding, removing, and traversing the tree.

### Assignment

1. Forming a Binary Tree:
   - Write a class Node that will represent a node in the binary tree. The node should contain:
     - int data - the value of the node.
     - Node left - a reference to the left subtree.
     - Node right - a reference to the right subtree.
   - Write a class BinaryTree that will contain methods for working with the tree:
     - A method Add(int value) that adds a node to the tree. The tree should maintain the properties of a binary search tree (all nodes in the left subtree are less than the root, and all nodes in the right subtree are greater).
     - A method Remove(int value) that removes a node from the tree, if it exists.
     - A method InOrderTraversal(), which performs an in-order traversal of the tree (left subtree - root - right subtree) and prints the values of the nodes to the console.

2. Tree Traversal:
   - Implement three traversal methods:
     - PreOrderTraversal() - traversal of the tree "root - left subtree - right subtree".
     - PostOrderTraversal() - traversal of the tree "left subtree - right subtree - root".
     - InOrderTraversal() - as mentioned above.
   - When traversing the tree, print the values of the nodes in the order they are visited.

3. Creating the Tree:
   - In the Main() method, create an instance of BinaryTree and test the methods for adding and removing nodes.
   - Add several nodes with random values and display the tree to the console using each of the traversal methods.

4. Deep Cloning:
   - Implement a method Clone() that will create a new binary tree with the same node values as the original tree. Ensure that the copies of nodes in the new tree are created in new memory.

5. Deleting the Tree:
   - Write a method Clear() that recursively frees the memory occupied by the nodes of the tree.
