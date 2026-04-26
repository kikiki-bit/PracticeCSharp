//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class10 {

//        static void Main(string[] args) {
//            var sale = new Sale {
//                ProductName = "商品A",
//                UnitPrice = 1300,
//                Quantity = 4
//            };
//            Console.WriteLine(sale.ProductName);
//            Console.WriteLine(sale.UnitPrice);
//            Console.WriteLine(sale.Quantity);

//            var nums = new int[] { -20, 30, 50, 80, 20, -30 };
//            Console.WriteLine(ArrayUtils.GetMin(nums, true));
//            Console.WriteLine(ArrayUtils.GetMin(nums));

//            var mypet = new VirtualPet("たそがれまる");
//            Console.WriteLine($"Name: {mypet.Name}");
//            Console.WriteLine($"Mood: {mypet.Mood}");
//            Console.WriteLine($"Energy: {mypet.Energy}");
//            for (var i = 0; i < 20; i++) {
//                mypet.MoodUp();
//            }
//            Console.WriteLine($"Mood: {mypet.Mood}");
//            for (var i = 0; i < 20; i++) {
//                mypet.MoodDown();
//            }
//            Console.WriteLine($"Mood: {mypet.Mood}");

//            var book = new Book("斜陽", "太宰治");
//            book.Pages = 256;
//            book.Rating = 4;
//            book.Print();

//        }

//        class Sale {
//            private int _unitPrice;
//            private int _quantity;
//            private string _productName;

//            public string ProductName {
//                get { return _productName; }
//                set { _productName = value; }
//            }

//            public int UnitPrice {
//                get { return _unitPrice; }
//                set { _unitPrice = value; }
//            }

//            public int Quantity {
//                get { return _quantity; }
//                set { _quantity = value; }
//            }


//        }

//        static class ArrayUtils {

//            public static int GetMin(int[] numbers, bool isPositive = false) {
//                var min = int.MaxValue;
//                foreach (var n in numbers) {
//                    if (isPositive && n <= 0)
//                    {
//                        continue;
//                    }
//                    min = Math.Min(min, n);
//                }
//                return min;
//            }

//        }

//        class VirtualPet {
//            public string Name { get; set; }

//            public int Mood { get; private set; }

//            public int Energy { get; set; }

//            public VirtualPet(string name) {
//                Name = name;
//                Mood = 5;
//                Energy = 100;
//            }

//            public void MoodUp() {
//                if (Mood < 10) {
//                    Mood++;
//                }
//            }

//            public void MoodDown() {
//                if (Mood > 1) {
//                    Mood--;
//                }
//            }
//        }

//        class Book {
//            public Book(string title, string author) {
//                Title = title;
//                Author = author;
//            }

//            public string Title { get; set; }
//            public string Author { get; set; }
//            public int Pages { get; set; }
//            public int Rating { get; set; }

//            public void Print() {
//                Console.WriteLine($"■{Title}");
//                Console.WriteLine($"  {Author}  {Pages}ページ  評価: {Rating}");
//            }
//        }
//    }
//}
