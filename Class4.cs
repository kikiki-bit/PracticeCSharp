using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp {
    internal class Class4 {

        static void Main(string[] args) {
            Practice4of1();
            Practice4of2();
            Practice4of3();
            Practice4of4();
            Practice4of5();
        }
        static void Practice4of1() {
            var line = Console.ReadLine();
            if (line == "") {
                Console.WriteLine("空文字列です");
            }
        }
        static void Practice4of2() {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num < 0) {
                Console.WriteLine("負数です");
            } else if (num == 0) {
                Console.WriteLine("0です");
            } else {
                Console.WriteLine("正数です");
            }
        }

        static void Practice4of3() {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if ((num % 3 == 0) && (num % 5 == 0)) {
                Console.WriteLine("numは3でも5で割り切れます");
            }
        }

        static void Practice4of4() {
            var word = Console.ReadLine();
            var term = "";
            switch (word) {
                case "API":
                    term = "Application Programming Interface";
                    break;
                case "RDB":
                    term = "Relational Database";
                    break;
                case "UI":
                    term = "User Interface";
                    break;
                case "IDE":
                    term = "Integrated Development Environment";
                    break;
                case "HTML":
                    term = "HyperText Markup Language";
                    break;
            }
            if (term != "") {
                Console.WriteLine("{0}は {1} の略です。", word, term);
            }
        }

        static void Practice4of5() {
            var line = Console.ReadLine();
            var num = int.Parse(line);
            if (num < 0 || 100 < num) {
                Console.WriteLine("入力した数値に誤りがあります");
                return;
            }
            if (num <= 30) {
                Console.WriteLine("不可");
            } else if (num <= 60) {
                Console.WriteLine("可");
            } else if (num <= 80) {
                Console.WriteLine("良");
            } else if (num <= 100) {
                Console.WriteLine("優");
            }
        }
    }
}
