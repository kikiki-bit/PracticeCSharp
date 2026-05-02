using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp {
    internal class Class13 {

        static void Main(string[] args) {
            var employee = new Employee {
                FirstName = "木場",
                LastName = "聖樹",
                Birthday = new DateTime(2001, 5, 8)
            };
            var customer = new Customer {
                FirstName = "田中",
                LastName = "太郎",
                Birthday = new DateTime(1998, 11, 18)
            };
            Console.WriteLine($"{employee.FullName} {employee.Birthday}");
            Console.WriteLine($"{customer.FullName} {customer.Birthday}");

            object book = new Book("人間失格", "太宰治", 212, 4);
            Console.WriteLine(book);
        }

        class Person {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string FullName {
                get { return LastName + FirstName; }
            }

            public string EMail { get; set; }

            public DateTime Birthday { get; set; }
        }

        class Employee : Person {
            public int Number { get; set; }
            public DateTime HireDate { get; set; }

            public override string ToString()
            {
                var s = $"{Number} {FullName} " +
                        $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
                return s;
            }
        }

        class Customer : Person {
            public string Id { get; set; }
            public int Rank { get; set; }
            public string CreditCardNumber { get; set; }
        }

        //class Book {
        //    public string Title { get; set; }
        //    public string Author { get; set; }
        //    public int Pages { get; set; }
        //    public int Rating { get; set; }
        //    public Book(string title, string author, int pages, int rating) {
        //        Title = title;
        //        Author = author;
        //        Pages = pages;
        //        Rating = rating;
        //    }

        //}

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

            public override string ToString() {
                return $"{Title} {Author} {Pages}ページ 評価:{Rating}";
            }
        }
    }
}
