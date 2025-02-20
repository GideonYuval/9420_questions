﻿using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
using TreeDLR;
using Unit4.CollectionsLib;
using System.Runtime.Remoting.Messaging;

namespace _9420
{
    // Tree 1                        Tree 2                        Tree 3                        Tree 4
    //          1                            1                           -1                            m
    //       /     \                      /     \                      /     \                      /     \
    //      3       2                    2       3                   -2      3                     a       r
    //     /       / \                  / \     / \                 /  \    /  \                  / \     / \
    //    9       6   8                4   5   6   7              -4    3  6   -8                z   d   e   w
    //     \
    //      7

    // Tree 5
    //          4
    //       /     \
    //      2       6
    //     / \     / \
    //    1   3   5   7
    internal class Program
    {
        static void Main(string[] args)
        {

            //BinNode<string> tree = VisualTree<string>.GetTree();


            //Q1
            Console.WriteLine(CountNodes(BuildTree1()));

            //Q2
            Console.WriteLine(SumNodes(BuildTree1()));

            //Q3
            Console.WriteLine(CountRightSon(BuildTree1()));

            //Q4
            Console.WriteLine(IsValueInTree(BuildTree1(), 1)); //true
            Console.WriteLine(IsValueInTree(BuildTree1(), 20)); //false

            //Q5
            Console.WriteLine(CountLeaves(BuildTree1()));
            Console.WriteLine(CountLeaves(BuildTree2()));

            //Q6
            Console.WriteLine(CountEdges(BuildTree1()));

            //Q7
            Console.WriteLine(CountGrandfathers(BuildTree1()));
            Console.WriteLine(CountGrandfathers(BuildTree2()));

            //Q8
            Console.WriteLine(MaxValue(BuildTree3()));

            //Q9
            Console.WriteLine(Height(BuildTree1()));

            //Q10
            Console.WriteLine(IsBalanced(BuildTree1())); //F
            Console.WriteLine(IsBalanced(BuildTree2())); //T


            //Q11
            //VisualTree<string>.DrawTree(Days());
            PrintCapitals(Days());



        }

        //helper functions

        public static bool IsLeaf(BinNode<int> root)
        {
            if (root == null) return false;
            return (!root.HasLeft() && !root.HasRight());
        }

        //Q1
        //parameter - tree of ints
        //return - int - number of nodes in the tree
        //note: implement pre-order, in-order and post-order

        static int CountNodes(BinNode<int> root)
        {
            return 0;
        }

        //Q2
        //parameter - tree of ints
        //return - sum of nodes
        static int SumNodes(BinNode<int> root)
        {
            return 0;

        }

        //Q3
        //parameter - tree of ints
        //return - how many right sons
        public static int CountRightSon(BinNode<int> root)
        {
            return 0;

        }



        //Q4
        //parameters - tree of ints, int
        //return - TRUE if the integer is in the tree, FALSE otherwise

        static bool IsValueInTree(BinNode<int> root, int value)
        {
            return false;
        }

        //Q5
        //parameters - tree of ints
        //return - number of leaves (no children)

        static int CountLeaves(BinNode<int> root)
        {
            return 0;

        }

        //Q6
        //parameters - tree of ints
        //return - number of edges קשתות

        static int CountEdges(BinNode<int> root)
        {
            return 0;

        }

        //Q7
        //parameters - tree of ints
        //return - number of grandfathers in tree
        //tip - first write: static bool IsGrandfather(BinNode<int> root) and think - how to define a grandfather?

        static bool IsGrandfather(BinNode<int> root)
        {
            return false;
        }

        static int CountGrandfathers(BinNode<int> root)
        {
            return 0;

        }

        //Q8
        //return max value of int tree (tree can also have negative values)
        static int MaxValue(BinNode<int> root)
        {
            return 0;

        }

        //Q9
        //return Height of tree
        static int Height(BinNode<int> root)
        {
            return 0;

        }

        //Q10
        //return true if tree is "balanced" = max height difference for all sub trees is 1
        //null tree is balanced
        static bool IsBalanced(BinNode<int> root)
        {
            return false;
        }

        //Q11
        //parameter - tree of strings
        //return - nothing
        //print all words starting with a capital letter
        //note: implement in-order
        //test with Days()
        static void PrintCapitals(BinNode<string> t)
        {

        }


        public static BinNode<int> BuildTree1()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left subtree
            BinNode<int> node3 = new BinNode<int>(3);
            node3.SetLeft(new BinNode<int>(9));
            node3.GetLeft().SetRight(new BinNode<int>(7));

            // Right subtree
            BinNode<int> node2 = new BinNode<int>(2);
            node2.SetLeft(new BinNode<int>(6));
            node2.SetRight(new BinNode<int>(8)); // Hidden child set to 8

            // Attach left and right subtrees to root
            root.SetLeft(node3);
            root.SetRight(node2);

            return root;
        }

        // Tree structure:
        //          1
        //       /     \
        //      3       2
        //     /       / \
        //    9       6   8
        //     \
        //      7

        static BinNode<int> BuildTree2()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left subtree
            BinNode<int> leftChild = new BinNode<int>(2);
            leftChild.SetLeft(new BinNode<int>(4));
            leftChild.SetRight(new BinNode<int>(5));

            // Right subtree
            BinNode<int> rightChild = new BinNode<int>(3);
            rightChild.SetLeft(new BinNode<int>(6));
            rightChild.SetRight(new BinNode<int>(7));

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }

        // Tree structure:
        //          1
        //       /     \
        //      2       3
        //     / \     / \
        //    4   5   6   7

        static BinNode<int> BuildTree3()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(-1); // Root value is negative

            // Left subtree
            BinNode<int> leftChild = new BinNode<int>(-2); // Left child of root
            leftChild.SetLeft(new BinNode<int>(-4));       // Left child of node -2
            leftChild.SetRight(new BinNode<int>(3));       // Right child of node -2

            // Right subtree
            BinNode<int> rightChild = new BinNode<int>(3); // Right child of root
            rightChild.SetLeft(new BinNode<int>(6));       // Left child of node 3
            rightChild.SetRight(new BinNode<int>(-8));     // Right child of node 3 (negative)

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }

        // Tree structure:
        //         -1
        //       /    \
        //     -2      3
        //    /  \    /  \
        //  -4    5  6   -7

        static BinNode<char> BuildTree4()
        {
            // Root node
            BinNode<char> root = new BinNode<char>('m'); // Root value

            // Left subtree
            BinNode<char> leftChild = new BinNode<char>('a'); // Left child of root
            leftChild.SetLeft(new BinNode<char>('z'));       // Left child of node 'a'
            leftChild.SetRight(new BinNode<char>('d'));      // Right child of node 'a'

            // Right subtree
            BinNode<char> rightChild = new BinNode<char>('r'); // Right child of root
            rightChild.SetLeft(new BinNode<char>('e'));        // Left child of node 'r'
            rightChild.SetRight(new BinNode<char>('w'));       // Right child of node 'r'

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }
        // Tree structure:
        //          m
        //       /     \
        //      a       r
        //     / \     / \
        //    z   d   e   w

        static BinNode<string> Days()
        {
            BinNode<string> root = new BinNode<string>("Sunday");
            root.SetLeft(new BinNode<string>("monday"));
            root.GetLeft().SetLeft(new BinNode<string>("tuesday"));
            root.GetLeft().SetRight(new BinNode<string>("Wednesday"));
            root.GetLeft().GetRight().SetRight(new BinNode<string>("Thursday"));
            root.SetRight(new BinNode<string>("friday"));
            root.GetRight().SetLeft(new BinNode<string>("Saturday"));
            return root;
        }

    }


}
