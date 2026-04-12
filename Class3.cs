//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class3 {
//        static void Main(string[] args) {
//            Practice3of1();
//            Practice3of2();
//            Practice3of3();
//            Practice3of4();
//            Practice3of5();
//        }
//        static void Practice3of1() {
//            string count = Console.ReadLine();
//            int value = int.Parse(count);

//            double tax = value * 0.1;
//            Console.WriteLine(tax);
//        }

//        static void Practice3of2() {
//            var n1 = 100;               // int
//            var n2 = 13;                // int
//            var a1 = n1 + n2;           // int
//            var a2 = -n1 / n2;          // int
//            var a3 = (double)n1 / n2;   // double
//            var a4 = a2 - n1;           // int
//            var a5 = a3 * -2;           // double
//            var a6 = a4 * 2.0M;         // decimal

//            Console.WriteLine(n1);
//            Console.WriteLine(n2);
//            Console.WriteLine(a1);
//            Console.WriteLine(a2);
//            Console.WriteLine(a3);
//            Console.WriteLine(a4);
//            Console.WriteLine(a5);
//            Console.WriteLine(a6);
//        }

//        static void Practice3of3() {
//            var x = 10;
//            var a = 5;
//            var b = 3;
//            var n = 2;
//            var k = 1;

//            x /= 2;
//            a += b * 2;
//            n *= k + 4;

//            Console.WriteLine(x);
//            Console.WriteLine(a);
//            Console.WriteLine(n);
//        }

//        static void Practice3of4() {
//            var a = 10;
//            var b = 20;

//            Console.WriteLine($"a={a} b={b}");

//            var amount = a;
//            a = b;
//            b = amount;

//            Console.WriteLine($"a={a} b={b}");
//        }

//        static void Practice3of5() {
//            var count = Console.ReadLine();
//            var amount = int.Parse(count);
//            var point = (int)(amount * 0.01) * 5;
//            Console.WriteLine($"金額:{amount} ポイント:{point}");
//        }

//    }
//}
