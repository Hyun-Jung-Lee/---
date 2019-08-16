using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg4CloneTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            Node tree = Util.BuildTree(a, 0, a.Length - 1);
            Console.WriteLine();
            //Console.WriteLine(tree.val); //print Tree root
            Console.WriteLine("Deep first In order loop the tree: ");
            Util.DFS(tree);
            Console.WriteLine( );
            //Console.WriteLine("Deep first pre order loop the tree: ");
            //Util.DFSPreOrder(tree);

            Console.WriteLine("Breadth first loop the tree: ");
            Util.BFS(tree);
            Console.WriteLine();

            //Clone Tree
            Node newTree = Util.CloneTree(tree);
            Console.WriteLine("Deep first In order loop the tree: ");
            Util.DFS(newTree);
            Console.WriteLine();
        }
    }
}
