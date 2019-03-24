using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTest
{
    public class Program
    {
        static void Main(string[] args) {
            //PrintSum();
            //PrintCandies();
            PrintAge();
        }

        static void PrintSum() {
            var mathCalculator = new MathCalculator();
            var sum = mathCalculator.Add(3, 5);
            Console.WriteLine(sum.Value);
        }

        static void PrintCandies() {
            int candies = 865;
            int bigBagCapacity = 25;
            int smallBagCapacity = 10;

            decimal firstDivision = candies / bigBagCapacity;

            var totalBigBags = Math.Truncate(firstDivision);
            Console.WriteLine("Total big bags: " + totalBigBags);

            //var remainCandies = candies - (totalBigBags * bigBagCapacity);
            //Console.WriteLine("Remain candies: " + remainCandies);

            var remainCandies = candies % bigBagCapacity;
            Console.WriteLine("Remain candies: " + remainCandies);

            var totalSmallBags = remainCandies / smallBagCapacity;
            Console.WriteLine("Total small bags: " + totalSmallBags);

            remainCandies = remainCandies % smallBagCapacity;
            Console.WriteLine("Remain candies: " + remainCandies);

            Console.WriteLine("Ceiling");
            decimal remainCandiesTwo = candies % bigBagCapacity;
            var totalSmallBagsTwo = Math.Ceiling(remainCandiesTwo / 10);

            Console.WriteLine("Total small bags two: " + totalSmallBagsTwo);
        }

        static void PrintAge() {
            Console.WriteLine("Hello... what is your age?");
            int ageInt = 0;
            var age = String.Empty;               

            do {
                age = Console.ReadLine();
                Int32.TryParse(age, out ageInt);

                if (ageInt == 0)
                    Console.WriteLine("Please write a valid number");
                
            } while (ageInt == 0);

            Console.WriteLine("Your age is: " + ageInt);
        }
    }
}
