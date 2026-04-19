//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class6 {

//        static void Main(string[] args) {
//            Practice6of1();
//            Practice6of2();
//            Practice6of3();
//            Practice6of4();
//        }

//        static void Practice6of1() {
//            var nums = new int[8];
//            for (var i = 0; i < nums.Length; i++) {
//                var line = Console.ReadLine();
//                var num = int.Parse(line);
//                nums[i] = num;
//            }
//            var total = 0;
//            for (var i = 0; i < nums.Length; i++) {
//                total += nums[i];
//            }
//            var average = total / nums.Length;
//            Console.WriteLine($"合計{total}");
//            Console.WriteLine($"平均{average}");
//        }

//        static void Practice6of2() {
//            var nums = new int[20];
//            for (var i = 0; i < nums.Length; i++) {
//                nums[i] = 100 + i;
//                Console.WriteLine(nums[i]);
//            }
//        }

//        static void Practice6of3() {
//            string[] names = { "キリン", "ネコ", "チーター", "レッサーパンダ", "ドジョウ"};
//            var max = "";
//            foreach (var name in names) {
//                if (name.Length >= max.Length) {
//                    max = name;
//                }
//            }
//            Console.WriteLine(max);
//        }

//        static void Practice6of4() {
//            var array2d = new string[,]
//{
//                { "sun" , "日曜日" },
//                { "mon" , "月曜日" },
//                { "tue" , "火曜日" },
//                { "wed" , "水曜日" },
//                { "thu" , "木曜日" },
//                { "fri" , "金曜日" },
//                { "sat" , "土曜日" }
//};
//            for (var row = 0; row < array2d.GetLength(0); row++) {
//                Console.WriteLine($"{array2d[row, 1]} ({array2d[row, 0]})");
//            }
//        }
//    }
//}
