using System;
using System.Linq;
using Behavioral.Iterator.TreeTraversal;

namespace Behavioral.Iterator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
          //    1
          //   / \
          //  2   3
          // in-order: 213
          // preorder: 123
          // postorder: 231

          var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
          // var iterator = new InOrderIterator<int>(root);
          //
          // while (iterator.MoveNext())
          // {
          //     Console.Write(iterator.Current.Value);
          //     Console.Write(',');
          // }
          // Console.WriteLine();

          var tree = new BinaryTree<int>(root);
          
          Console.WriteLine(string.Join(",", 
              tree.NaturalInOrder.Select(x => x.Value)));

          foreach (var node in tree)
          {
              Console.WriteLine(node.Value);
          }
        }
    }
}