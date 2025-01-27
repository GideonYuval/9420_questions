using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
using TreeDLR;
using Unit4.CollectionsLib;
using System.Runtime.Remoting.Messaging;

namespace _9420_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinNode<string> tree = VisualTree<string>.GetTree();

        }

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

        // Tree structure:
        //          Sunday
        //         /      \
        //      monday    friday
        //     /    \       /
        //  tuesday Wednesday Saturday
        //                 \
        //                 Thursday

        public static BinNode<int> BuildIntTree()
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

        static BinNode<int> BuildValidTree()
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


        //Q1
        //parameter - tree of strings
        //return - nothing
        //print all words starting with a capital letter
        //note: implement in-order
        //test with Days()
        static void PrintCapitals(BinNode<string> t)
        {

        }



        //Q2
        //parameter - tree of ints
        //return - nothing
        //to each node with only one child, add a second child with value 0
        //note: implement in-order
        //use BuildIntTree() to test
        static void AddSon(BinNode<int> root)
        {

        }



        //Q3
        //parameter - tree of ints
        //return - nothing
        //print values of all nodes which have only one child
        //note: implement in-order
        //use BuildIntTree to test

        static void PrintOneSon(BinNode<int> root)
        {


        }

        //Q4
        //parameter - tree of ints
        //return - int - number of nodes in the tree
        //note: implement pre-order, in-order and post-order
        //use BuildIntTree to test

        static int CountNodes(BinNode<int> root)
        {
            return 0;
        }

        //Q5
        //parameters - tree of ints, int
        //return - TRUE if the integer is in the tree, FALSE otherwise
        //use BuildIntTree to test

        static bool IsValueInTree(BinNode<int> root, int value)
        {
            return false;
        }

        //Q6
        //parameters - tree of ints
        //return - TRUE if ALL non-leaves have 2 children
        //use BuildIntTree to test for FALSE, BuildValidTree for TRUE

        static bool IsAll2Children(BinNode<int> root)
        {
            return false;
        }



    }


}
