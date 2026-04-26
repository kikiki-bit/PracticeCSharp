//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class11 {

//        static void Main(string[] args) {
//            Q1();

//            var person = new Person("聖樹", "木場", Gender.Male);
//            Console.WriteLine(person.FirstName);
//            Console.WriteLine(person.LastName);
//            Console.WriteLine(person.Gender);

//            var king = new Card(CardSuit.Spade, 13);
//            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
//            ChangeToAce(king);
//            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
//        }

//        static void Q1() {
//            Console.Write("あなたの生年月日は：");
//            var line = Console.ReadLine();
//            var date = DateTime.Parse(line);
//            if (date.DayOfWeek == DayOfWeek.Sunday) {
//                Console.WriteLine("日曜日に生まれました");
//            } else {
//                Console.WriteLine("日曜日生まれではありません");

//            }
//        }

//        enum Gender {
//            Male,
//            Female
//        }

//        class Person {
//            public string FirstName { get; set; }
//            public string LastName { get; set; }
//            public string Fullname {
//                get { return LastName + FirstName; }
//            }

//            public Gender Gender { get; set; }

//            public Person() {
//                FirstName = "";
//                LastName = "";
//            }

//            public Person(string firstName, string lastName, Gender gender) {
//                FirstName = firstName;
//                LastName = lastName;
//                Gender = gender;
//            }
//        }

//        private static void ChangeToAce(Card card) {
//            card.Number = 1;
//            card.Suit = CardSuit.Diamond;
//            card = new Card(CardSuit.Club, 1);
//        }

//        enum CardSuit {
//            Club, Spade, Heart, Diamond
//        }

//        //struct Card {
//        //    public CardSuit Suit { get; set; }
//        //    public int Number { get; set; }

//        //    public Card(CardSuit suit, int number) {
//        //        Suit = suit;
//        //        Number = number;
//        //    }
//        //}

//        class Card {
//            public CardSuit Suit { get; set; }
//            public int Number { get; set; }

//            public Card(CardSuit suit, int number) {
//                Suit = suit;
//                Number = number;
//            }
//        }
//    }
//}
