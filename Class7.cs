//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class7 {

//        static void Main(string[] args) {
//            var book = new Book {
//                Title = "坊っちゃん",
//                Author = "夏目漱石",
//                Pages = 216,
//                Rating = 4,
//                Memo = "漱石の初期の代表作のひとつ"
//            };
//            book.Print();

//            // 一つ目のインスタンスを生成
//            var emp1 = new Employee {
//                Id = 500,
//                FamilyName = "吉村",
//                GivenName = "健太"
//            };
//            // 二つ目のインスタンスを生成
//            var emp2 = new Employee {
//                Id = 501,
//                FamilyName = "岸本",
//                GivenName = "結衣"
//            };
//            Console.WriteLine(emp1.GetFullName());
//            Console.WriteLine(emp2.GetFullName());
//        }

//        public class Book() {
//            public string Title { get; set; }
//            public string Author { get; set; }
//            public int Pages { get; set; }
//            public int Rating { get; set; }
//            public string Memo { get; set; }

//            public void Print() {
//                Console.WriteLine($"『{Title}』{Author}");
//                Console.WriteLine($"  {Pages}ページ、評価:{Rating}");
//                Console.WriteLine($"  {Memo}");
//            }
//        }

//        class Employee {
//            public int Id { get; set; }
//            public string FamilyName { get; set; }
//            public string GivenName { get; set; }
//            public string EmailAddress { get; set; }

//            public string GetFullName() {
//                return $"{FamilyName} {GivenName}";
//            }
//        }
//    }
//}
