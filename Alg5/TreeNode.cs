using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg5
{
   public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> LeftChild { get; set; }

        public TreeNode<T> RightChild { get; set; }
    }
}
