using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg4CloneTree
{
    class Node
    {
        public int val;
        public Node left;
        public Node right;

        //Construtor, set value, pointer default null;
        public Node(int val)
        {
            this.val = val;
        }
    }

    class Util
    {
        // recurvise method to build a balance tree, from an ordered array
        public static Node BuildTree(int[] a, int li, int hi)
        {
            if (hi < li) return null;
            int mi = li + (hi - li) / 2;

            Node node = new Node(a[mi]); // Set the middle value as up root
            //Console.WriteLine("Current node: " + node.val);
            node.left = BuildTree(a, li, mi-1);
            node.right = BuildTree(a, mi + 1, hi);            


            return node;//return root
        }

        //Deep first search In order and print every node value
        public static void DFS(Node root)
        {
            if (root == null) return;
            DFS(root.left);
            Console.Write(root.val + " ");
            DFS(root.right);
        }

        //Deep first search In order and print every node value
        public static void DFSPreOrder(Node root)
        {
            if (root == null) return;
            Console.Write(root.val + " ");
            DFSPreOrder(root.left);            
            DFSPreOrder(root.right);
        }

        //Bread first search  and print every node value
        public static void BFS(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                //dequeue one node, then check enqueue his children.
                Node temp = q.Dequeue();
                Console.Write(temp.val + " ");
                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
            }           

        }

        //Clone the a new tree by Bread first search 
        public static Node CloneTree(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            //create a root of new tree and enqueue
            Node newRoot = new Node(root.val);
            q.Enqueue(root);
            q.Enqueue(newRoot);
            while (q.Count > 0)
            {
                //dequeue one node, then check enqueue his children.
                Node temp = q.Dequeue();
                Node cloned = q.Dequeue();
                
                if (temp.left != null)
                {
                    cloned.left = new Node(temp.left.val);
                    q.Enqueue(temp.left);
                    q.Enqueue(cloned.left);
                }
                if (temp.right != null)
                {
                    cloned.right = new Node(temp.right.val);
                    q.Enqueue(temp.right);
                    q.Enqueue(cloned.right);
                }
            }
            return newRoot;

        }
    }
}
