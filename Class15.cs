using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp {
    internal class Class15 {
        static void Main(string[] args) {
            //Ex01();
            Ex02();

            Ex03();

        }

        private static void Ex01() {
            while (true) {
                try {
                    var total = 1000;
                    var line = Console.ReadLine();
                    var count = int.Parse(line);
                    var ans = total / count;
                    Console.WriteLine(ans);
                    Console.WriteLine("正常終了");
                    break;
                } catch {
                    Console.WriteLine("入力した値が正しくありません.再度入力してください");
                }
            }
        }

        private static void Ex02() {
            while (true) {
                var total = 1000;
                var line = Console.ReadLine();
                if (int.TryParse(line, out var count)) {
                    if (count == 0) {
                        Console.WriteLine("0は入力できません");
                    } else {
                        var ans = total / count;
                        Console.WriteLine(ans);
                        Console.WriteLine("正常終了");
                        break;
                    }
                } else {
                    Console.WriteLine("入力した値が正しくありません.再度入力してください");
                }
            }
        }

        private static void Ex03() {
            var array = new int[] { 1, 2, 3, 4, 5 };

            try {
                Console.WriteLine(array[5]);
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
