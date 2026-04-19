using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp {
    internal class Class9 {

        static void Main(string[] args) {
            //Ex1();
            //Ex2();

            var days = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine($"{days}日あります。");

            //var line = Console.ReadLine();
            //var date = DateTime.Parse(line);
            //var week = date.ToString("dddd");
            //Console.WriteLine($"{week}です");

            var path = "C:\\temp\\祇園精舎.txt";
            CreateFile(path);
            var count = CountChars(path);
            Console.WriteLine($"{count}文字あります");

            SplitComma(path);
        }

        private static void Ex1() {
            var line1 = Console.ReadLine();
            var n1 = double.Parse(line1);

            var line2 = Console.ReadLine();
            var n2 = double.Parse(line2);

            var min = Math.Min(n1, n2);

            Console.WriteLine($"小さい値は、{min} です");
        }

        private static void Ex2() {
            while (true) {
                var line = Console.ReadLine();
                if (line == "") {
                    break;
                }

                var n = double.Parse(line);
                var floor = Math.Floor(n);
                var ceil = Math.Ceiling(n);

                Console.WriteLine($"切り捨て: {floor}, 切り上げ: {ceil}");
            }
        }

        static int CountChars(string path) {
            var lines = File.ReadAllLines(path);
            var count = 0;
            foreach (var line in lines) {
                count += line.Length;
            }
            return count;
        }

        // Q3-2 読点で分割するメソッド
        private static void SplitComma(string path) {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines) {
                var phrases = line.Split('、');
                foreach (var phrase in phrases) {
                    Console.WriteLine(phrase);
                }
            }
        }

        // 祇園精舎.txt を作成するメソッド
        static void CreateFile(string path) {
            var lines = new string[]
            {
                    "祇園精舍の鐘の声、諸行無常の響きあり。",
                    "娑羅双樹の花の色、盛者必衰の理をあらはす。",
                    "奢れる人も久しからず、ただ春の夜の夢のごとし。",
                    "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ。"
            };
            File.WriteAllLines(path, lines);
        }
    }
}
