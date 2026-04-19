//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeCSharp {
//    internal class Class8 {

//        static void Main(string[] args) {
//            var nums = new int[] { 5, 10, 8, 7, 21, -5, 14, -3 };
//            var max = ArrayUtils.Max(nums);
//            Console.WriteLine(max);
//            var min = ArrayUtils.Min(nums);
//            Console.WriteLine(min);

//            var bmi = BmiCalculator.GetBmi(158, 45);
//            var type = BmiCalculator.GetBodyType(bmi);
//            Console.WriteLine($"あなたは「{type}」です。");
//        }

//        static class ArrayUtils {
//            public static int Total(int[] numbers) {
//                int total = 0;
//                foreach (var n in numbers) {
//                    total += n;
//                }
//                return total;
//            }

//            public static double Average(int[] numbers) {
//                var total = Total(numbers);
//                return (double)total / numbers.Length;
//            }

//            public static double Max(int[] numbers) {
//                int max = numbers[0];
//                foreach (var n in numbers) {
//                    if (n > max) {
//                        max = n;
//                    }
//                }
//                return max;
//            }

//            public static double Min(int[] numbers) {
//                int min = numbers[0];
//                foreach (var n in numbers) {
//                    if (n < min) {
//                        min = n;
//                    }
//                }
//                return min;
//            }
//        }

//        static class BmiCalculator {
//            public static double GetBmi(int height, int weight) {
//                var metersTall = height / 100.0;
//                var bmi = weight / (metersTall * metersTall);
//                return bmi;
//            }

//            public static string GetBodyType(double bmi) {
//                var type = "";
//                if (bmi < 18.5) {
//                    type = "痩せ型";
//                } else if (bmi < 25) {
//                    type = "普通体重";
//                } else if (bmi < 30) {
//                    type = "肥満(1度)";
//                } else if (bmi < 35) {
//                    type = "肥満(2度)";
//                } else if (bmi < 40) {
//                    type = "肥満(3度)";
//                } else {
//                    type = "肥満(4度)";
//                }
//                return type;
//            }
//        }
//    }
//}
