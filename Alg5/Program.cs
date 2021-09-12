using System;
using System.Collections;
using System.Collections.Generic;

namespace Alg5
{
    class Program
    {


        static void Main(string[] args)

        {
            // строим дерево с заданным количеством узлов
            MyTree.Tree(10);


            MyTree.PrintList();// просмотр  дерева

           
            TreeNode<int> Root = MyTree.Root;
            Console.WriteLine("root= " + MyTree.Root.Value); // корень дерева

            int searchValue = 16; // искомое значение в дереве

            // BFS поиск значения в ширину с помощью очереди
            var searchNodeQ = SearchByQueue(Root, searchValue);


            // DFS поиск значения в глубину с помощью стека
            var searchNodeS = SearchByStack(Root, searchValue);
        }

        public static Queue<TreeNode<int>> Q = new Queue<TreeNode<int>>(); //очередь для поиска

        public static Stack<TreeNode<int>> S = new Stack<TreeNode<int>>(); // стак для поиска

        public static TreeNode<int> SearchByQueue(TreeNode<int> root, int searchValue)
        {
            Q.Enqueue(root); // добавили в очередь корень
            foreach (TreeNode<int> i in MyTree.ListTree) // обходим весь список
            {
                if (Q is null)
                {
                    Console.WriteLine("Список пуст, значение не найдено");
                    return null;
                }
                else
                {
                    var n = Q.Dequeue(); // берем элемент из очереди
                    Console.WriteLine("test= " + n.Value);
                    if (n.Value == searchValue) // проверяем совпадение значения
                    {
                        Console.WriteLine("Искомый элемент найден");
                        return n;
                    }
                    else // если не совпало, добавляем в очередь дочерние элементы (с проверкой что они не null)
                    {
                        Console.WriteLine("delete from stack " + n.Value);
                        if (n.RightChild != null)

                        {
                            Q.Enqueue(n.RightChild);
                            Console.WriteLine("add to stack " + n.RightChild.Value);
                        }

                        if (n.LeftChild != null)
                        {
                            Q.Enqueue(n.LeftChild);
                            Console.WriteLine("add to stack " + n.LeftChild.Value);
                        }

                    }
                }
            }
            return null; // если ничего не нашли
        }

        
        public static TreeNode<int> SearchByStack(TreeNode<int> root, int searchValue ) // возвращает элемент по значению методом глубокого поиска
        {
            
            S.Push(root); // добавили в стак корень
            
            foreach (TreeNode<int> i in MyTree.ListTree) // обходим весь список
            {


                if (S is null)
                {
                    Console.WriteLine("Список пуст, значение не найдено");
                    return null;
                }
                else
                {
                    var n = S.Pop(); // берем элемент стака
                    Console.WriteLine("test= "+ n.Value);
                    if (n.Value == searchValue) // проверяем совпадение значения
                    {
                        Console.WriteLine("Искомый элемент найден");
                        return n;
                    }
                    else // если не совпало, добавляем в стак дочерние элементы (с проверкой что они не null)
                    {
                        Console.WriteLine("delete from stack " + n.Value);
                        if (n.RightChild != null)

                        {
                            S.Push(n.RightChild);
                            Console.WriteLine("add to stack " + n.RightChild.Value);
                        }

                        if (n.LeftChild != null)
                        {
                            S.Push(n.LeftChild);
                            Console.WriteLine("add to stack " + n.LeftChild.Value);
                        }
                    }
                }
            
            }


            return null; // если ничего не нашли
        }
    }
}
