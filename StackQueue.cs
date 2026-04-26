using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            Stack<int> stack = new Stack<int>();


            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            stack.Pop();

            stack.Peek();
            Console.WriteLine(stack.Peek());

            stack.Count();
            Console.WriteLine(stack.Count());

            stack.WriteStack();

            Console.WriteLine();

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            queue.Dequeue();
            Console.WriteLine(queue.Dequeue());

            queue.WriteQueue();
        }

        public class Stack<T> {
            class Node {
                public T Item;
                public Node Next;
            }

            Node _top;
            int _count;

            /// <summary>
            /// 追加
            /// </summary>
            public void Push(T item) {
                var node = new Node() {
                    Item = item,
                    Next = _top
                };
                _top = node;
                _count++;
            }

            /// <summary>
            /// 一番、上の要素を出す
            /// </summary>
            public T Pop() {
                T item = _top.Item;   // 取り出す
                _top = _top.Next;     // 一つ下をトップに

                _count--;

                return item;
            }

            /// <summary>
            /// 一番、上の要素を確認
            /// </summary>
            public T Peek() {
                return _top.Item;
            }

            /// <summary>
            /// このコンテナに入っている要素の数
            /// </summary>
            public int Count() {
                return _count;
            }

            public void WriteStack() {
                Node current = _top;

                while (current != null) {
                    Console.WriteLine(current.Item);
                    current = current.Next;
                }
            }
        }

        public class Queue<T> {
            class Node {
                public T Item;
                public Node Next;
            }

            Node _front;
            Node _back;
            int _count;

            /// <summary>
            /// 追加
            /// </summary>
            public void Enqueue(T item) {
                Node node = new Node() {
                    Item = item,
                    Next = null // 追加するノードは最後なのでNextはnull
                };

                if (_back == null) {
                    // 空のとき
                    _front = node;
                    _back = node;
                } else {
                    _back.Next = node;
                    _back = node;      
                }

                _count++;
            }

            /// <summary>
            /// 一番、上の要素を出す
            /// </summary>
            public T Dequeue() {
                T item = _front.Item;   // 先頭を取得
                _front = _front.Next;   // 次を先頭にする

                _count--;

                return item;
            }

            /// <summary>
            /// このコンテナに入っている要素の数
            /// </summary>
            public int Count() {
                return _count;
            }

            public void WriteQueue() {
                Node current = _front;

                while (current != null) {
                    Console.WriteLine(current.Item);
                    current = current.Next;
                }
            }
        }
    }
}
