using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp {
    internal class Class14 {
        static void Main(string[] args) {
            var pets = new List<IVirtualPet>
            {
                new FoodiePet("エイミー"),
                new CheerfulPet("クー"),
                new SleepyPet("ライアン")
            };

            foreach (var pet in pets) {
                pet.Eat();
                pet.Play();
                pet.Rest();
                Console.WriteLine($"{pet.Name} 機嫌:{pet.Mood} エネルギー:{pet.Energy}");
            }

            object person = new Person {
                FirstName = "木場",
                LastName = "聖樹",
            };
            object employee = new Employee {
                Number = 801,
                FirstName = "田中",
                LastName = "太郎",
                HireDate = new DateTime(2015, 4, 1)
            };

            var str1 = person.ToString();
            Console.WriteLine(str1);
            var str2 = employee.ToString();
            Console.WriteLine(str2);

            Console.WriteLine(person);
            Console.WriteLine(employee);
        }

        interface IVirtualPet {
            string Name { get; }
            int Mood { get; set; }
            int Energy { get; set; }
            void Eat();
            void Play();
            void Sleep();
            void Rest();
        }

        class SleepyPet : IVirtualPet {
            public string Name { get; private set; }
            public int Mood { get; set; }
            public int Energy { get; set; }

            public SleepyPet(string name) {
                Name = name;
                Mood = 5;
                Energy = 100;
            }

            public void Eat() {
                Mood -= 1;
                Energy += 5;
                Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
            }

            public void Play() {
                Mood -= 1;
                Energy -= 10;
                Console.WriteLine("SleepyPet.Playメソッドが実行されました");
            }

            public void Sleep() {
                Mood += 2;
                Energy += 2;
                Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
            }
            public void Rest() {
                Mood += 1;
                Energy += 1;
                Console.WriteLine("SleepyPet.Restメソッドが実行されました");
            }
        }

        class FoodiePet : IVirtualPet {
            public string Name { get; private set; }
            public int Mood { get; set; }
            public int Energy { get; set; }

            public FoodiePet(string name) {
                Name = name;
                Mood = 5;
                Energy = 100;
            }

            public void Eat() {
                Mood += 3;
                Energy += 5;
                Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
            }

            public void Play() {
                Mood -= 1;
                Energy -= 10;
                Console.WriteLine("FoodiePet.Playメソッドが実行されました");
            }

            public void Sleep() {
                Mood -= 1;
                Energy += 2;
                Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
            }

            public void Rest() {
                Mood += 1;
                Energy += 1;
                Console.WriteLine("FoodiePet.Restメソッドが実行されました");
            }
        }

        class CheerfulPet : IVirtualPet {
            public string Name { get; private set; }
            public int Mood { get; set; }
            public int Energy { get; set; }

            public CheerfulPet(string name) {
                Name = name;
                Mood = 5;
                Energy = 100;
            }

            public void Eat() {
                Mood += 0;
                Energy += 5;
                Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
            }

            public void Play() {
                Mood += 3;
                Energy -= 10;
                Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
            }

            public void Sleep() {
                Mood -= 1;
                Energy += 2;
                Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
            }

            public void Rest() {
                Mood += 2;
                Energy += 2;
                Console.WriteLine("CheerfulPet.Restメソッドが実行されました");
            }
        }

        class Person {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName {
                get { return LastName + FirstName; }
            }
        }

        class Employee : Person {
            public int Number { get; set; }
            public DateTime HireDate { get; set; }

            public override string ToString() {
                var s = $"{Number} {FullName} " +
                        $"{HireDate.Year}年{HireDate.Month}月{HireDate.Day}日入社";
                return s;
            }
        }
    }
}
