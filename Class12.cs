using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp {
    internal class Class12 {

        static void Main(string[] args) {
            Q1();

            var books = new List<Book>();
            books.Add(new Book("人間失格", "太宰治", 212, 5));
            books.Add(new Book("吾輩は猫である", "夏目漱石", 610, 4));
            books.Add(new Book("女生徒", "太宰治", 279, 4));
            books.Add(new Book("銀河鉄道の夜", "宮沢賢治", 357, 3));
            books.Add(new Book("伊豆の踊子", "川端康成", 201, 3));
            books.Add(new Book("こゝろ", "夏目漱石", 378, 5));

            Ex01(books);
            Console.WriteLine();

            Ex02(books);
            Console.WriteLine();

            Ex03(books);
            Console.WriteLine();

            Ex04(books);
        }

        static void Q1() {
            var datelist = new List<DateTime>
            {
                new DateTime(2019,12, 9, 8,15, 0),
                new DateTime(2020, 8, 4,23, 6, 0),
                new DateTime(2010, 4, 5, 8, 1, 0),
                new DateTime(2018,12,12,10,13, 0),
                new DateTime(2016, 3,18,15,35, 0),
                new DateTime(2014, 4, 1,18,46, 0),
            };

            Console.WriteLine(datelist.Count);

            foreach (var date in datelist) {
                Console.WriteLine(date.ToString("yyyy年MM月dd日 HH:mm"));
            }
        }

        private static void Ex01(List<Book> books) {
            var query = books.Where(x => x.Rating >= 4);
            foreach (var book in query) {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        private static void Ex02(List<Book> books) {
            var query = books.OrderBy(x => x.Author);
            foreach (var book in query) {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        private static void Ex03(List<Book> books) {
            var array = books.Where(x => x.Pages >= 300)
                             .ToArray();
            foreach (var book in array) {
                Console.WriteLine($"{book.Title} {book.Pages}");
            }
        }

        private static void Ex04(List<Book> books) {
            var book = books.OrderByDescending(x => x.Pages)
                            .First();
            Console.WriteLine($"{book.Title} {book.Pages}");
        }
    }

    class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public Book(string title, string author, int pages, int rating) {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }
    }
}