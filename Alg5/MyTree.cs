using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg5
{
    public class MyTree // класс для дерева
    {
        private static List<int> Values = new List<int>(); // лист для хранения добавляемых значений дерева, используется для проверки их уникальности
        public static List<TreeNode<int>> ListTree = new List<TreeNode<int>>();// список для хранения нод дерева, в котором будет выполняться поиск

        public static TreeNode<int> Root = null;

        public static TreeNode<int> Tree(int n) // построение сбалансированного дерева с n узлами и уникальными значениями
        {

            TreeNode<int> newNode = null;


            if (n == 0)
                return null;
            else

            {

                var nl = n / 2;
                var nr = n - nl - 1;
                newNode = new TreeNode<int>();

                int MyNumber = 0;
                newNode.Value = 0;
                while (newNode.Value == 0)
                {
                    MyNumber = new Random().Next(10, 20);
                    if (!Values.Contains(MyNumber))
                    {
                        Values.Add(MyNumber);

                        newNode.Value = MyNumber;


                    }
                }
                ListTree.Add(newNode);
                newNode.LeftChild = Tree(nl);

                newNode.RightChild = Tree(nr);

            }
            Console.WriteLine("возвращаемое значение " + newNode.Value);


            Root = newNode;
            return newNode;

        }

        // вывод листа на печать

        public static void PrintList()
        {
            // проверка заполнения дерева

            for (int i = 0; i<ListTree.Count; i++)
            {
                Console.WriteLine(ListTree[i].Value);

                if (ListTree[i].LeftChild != null)
                {
                    Console.WriteLine("left" + ListTree[i].LeftChild.Value);
                }

                if (ListTree[i].RightChild != null)
                {
                    Console.WriteLine("right" + ListTree[i].RightChild.Value);
                }



            }

        }

    }
}
