using System;
using System.Collections;
using System.Collections.Generic;

namespace AssignmentContainer {
    internal class Program {
        static void Main(string[] args) {
            List();
            Stack();
            Queue();
        }

        static void List() {
            // 整数のリストに対して以下を実装

            // 問題
            // 1から10までの整数を追加して表示する
            // 偶数だけ削除
            // 残った要素を昇順で表示

            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++) {
                list.Add(i);
            }

            for (int i = 1; i <= list.Count; i++) {
                if (list[i] % 2 == 0) {
                    list.RemoveAt(i);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }

        static void Stack() {
            // 文字列ABCDEを1文字ずつStackに入れて取り出して逆順の文字列を作る
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            stack.Push('E');

            foreach (char c in stack) {
                Console.WriteLine(c);
            }
        }

        static void Queue() {
            // 整数１～５をQueueに入れて、すべて取り出しながら表示する
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= 5; i++) {
                queue.Enqueue(i);
            }

            Console.WriteLine(string.Join(", ", queue));
            // OR
            foreach (int i in queue) {
                Console.WriteLine(i);
            }
        }
    }
}