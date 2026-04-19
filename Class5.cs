//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class5 {

//        static void Main(string[] args) {
//            Practice5of1();
//            Practice5of2();
//            Practice5of3();
//            Practice5of4();
//            Practice5of5();
//        }

//        static void Practice5of1() {
//            while (true) {
//                var line = Console.ReadLine();
//                var n = int.Parse(line);
//                Console.WriteLine(n);
//                if (n < 0) {
//                    break;
//                }
//            }
//        }

//        static void Practice5of2() {
//            var maxline = "";
//            for (var i = 0; i < 10; i++) {
//                var line = Console.ReadLine();
//                var len = line.Length;
//                if (len > maxline.Length) {
//                    maxline = line;    // 最大長の文字列を覚えておく
//                }
//            }
//            Console.WriteLine($"最大の長さの文字列は{maxline}です");
//        }

//        static void Practice5of3() {
//            var count = 0;
//            for (var num = 1; num <= 500; num++) {
//                if (((num % 3 == 0) || (num % 7 == 0)) &&
//                    (num % 2 == 1)) {
//                    count++;
//                }
//            }
//            Console.WriteLine(count);
//        }

//        static void Practice5of4() {
//            var total = 0.0;
//            while (true) {
//                var line = Console.ReadLine();
//                var num = double.Parse(line);
//                if (num <= 0) {
//                    break;
//                }
//                total += num;
//            }
//            Console.WriteLine(total);
//        }

//        static void Practice5of5() {
//            var line = Console.ReadLine();
//            var count = int.Parse(line);
//            for (var n = 0; n < count; n++) {
//                var star = "*";
//                for (var i = 0; i < n; i++) {
//                    star += '*';
//                }
//                Console.WriteLine(star);
//            }
//        }

//    }
//}
