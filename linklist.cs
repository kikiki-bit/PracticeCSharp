using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            var list = new Container<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.TryGet(2, out int item);

            list.RemoveAt(2);

            list.RemoveLast();

            list.Count();

            list.WriteList();
        }

        public class Container<T> {
            class Node {
                public T Item;
                public Node Prev;
                public Node Next;
            }

            Node _start;

            /// <summary>
            /// 追加
            /// 配列とは違って無限追加可能
            /// </summary>
            public void Add(T item) {
                // 最初が入ってなかったら入れる
                if (_start == null) {
                    _start = new Node();
                    _start.Item = item;
                } else {
                    // 新しい今のノードを作って入れておく
                    Node current = _start;

                    // 最後のノードを探す
                    while (current.Next != null) {
                        current = current.Next;
                    }

                    // 新しいノードを用意してつなぐ
                    Node next = new Node();
                    next.Item = item;

                    // 次と前をつなぐ
                    current.Next = next;
                    next.Prev = current;
                }
            }

            /// <summary>
            /// (index)番目のものを削除
            /// </summary>
            public void RemoveAt(int index) {
                if (_start == null) {
                    return;
                }

                Node current = _start;

                // index番目のノードを探す
                for (int i = 0; i < index; i++) {
                    // indexが大きすぎる場合は何もしない
                    if (current == null) {
                        return;
                    }
                    // Nextがあるまで追加し続ける
                    current = current.Next;
                }

                // indexが0の場合は先頭を削除する
                if (index == 0) {
                    _start = current.Next;
                    // 新しい先頭のPrevをnullにする
                    if (_start != null) {
                        _start.Prev = null;
                    }
                } else {
                    // 前のノードのNextをつなぎ替え
                    current.Prev.Next = current.Next;
                    // 次のノードがある場合Prevをつなぐ
                    if (current.Next != null) {
                        current.Next.Prev = current.Prev;
                    }
                }
            }

            /// <summary>
            /// 一番、後ろのものを削除
            /// </summary>
            public void RemoveLast() {
                if (_start == null) {
                    return;
                }

                // 1個しかない場合
                if (_start.Next == null) {
                    _start = null;
                    return;
                }

                // 最後まで移動
                Node current = _start;
                while (current.Next != null) {
                    current = current.Next;
                }

                // 1つ前のノードを最後にする
                // 一つ前の次は何もない状態にする
                current.Prev.Next = null;
            }

            /// <summary>
            /// (index)番目のものを取得
            /// </summary>
            public bool TryGet(int index, out T item) {
                // 取得できなかったらFalse
                // 取得できたらTrue
                // 
                item = default;

                // 空ならFalse
                if (_start == null) {
                    return false;
                }

                Node current = _start;

                for (int i = 0; i < index; i++) {
                    if (current == null) {
                        return false;
                    }
                    current = current.Next;
                }

                item = current.Item;
                return true;
            }

            /// <summary>
            /// このコンテナに入っている要素の数
            /// </summary>
            public int Count() {
                int count = 0;

                Node current = _start;

                // nullになるまでカウントし続ける
                while (current != null) {
                    count++;
                    current = current.Next;
                }

                return count;
            }

            public void WriteList() {
                Node current = _start;
                while (current != null) {
                    Console.WriteLine(current.Item);
                    current = current.Next; 
                }
            }
        }
    }
}
